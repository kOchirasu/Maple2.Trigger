using System;

namespace Maple2.Trigger._02000116_bf {
    public static class _ia_108 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000007}, arg2: 1);
                context.SetActor(arg1: 1081, arg2: true, arg3: "SOS_B");
            }

            public override void Execute() {
                if (true) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {304});
            }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000007}, arg2: 0)) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 1081, arg2: false, arg3: "SOS_B");
                context.DestroyMonster(arg1: new int[] {304});
                context.CreateMonster(arg1: new int[] {108});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 108, arg2: "MS2PatrolData108");
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$02000116_BF__IA_108__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$02000116_BF__IA_108__1$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 108, arg2: new int[] {108})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {108});
                context.SetTimer(arg1: "108", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "108")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}