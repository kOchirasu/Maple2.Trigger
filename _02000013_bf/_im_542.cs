using System;

namespace Maple2.Trigger._02000013_bf {
    public static class _im_542 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000542}, arg2: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {101});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000542}, arg2: 0)) {
                    context.State = new State시간텀(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {1101});
            }
        }

        private class State시간텀 : TriggerState {
            internal State시간텀(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 1101, arg2: "MS2PatrolData_542");
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000013_BF__IM_542__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 1101, arg3: "$02000013_BF__IM_542__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 542, arg2: new int[] {1101})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1101});
                context.SetTimer(arg1: "1", arg2: 20);
                context.RemoveBalloonTalk(spawnPointID: 1101);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}