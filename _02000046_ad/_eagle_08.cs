using System;

namespace Maple2.Trigger._02000046_ad {
    public static class _eagle_08 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000300}, arg2: 1);
                context.SetActor(arg1: 208, arg2: true, arg3: "Dead_A");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000300}, arg2: 0)) {
                    context.State = new State오브젝트반응(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트반응 : TriggerState {
            internal State오브젝트반응(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.State = new StateNPC이동(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetActor(arg1: 208, arg2: false, arg3: "Dead_A");
                context.CreateMonster(arg1: new int[] {308}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 308, arg2: "MS2PatrolData_208");
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$02000046_AD__EAGLE_08__0$", arg4: 2);
                context.SetTimer(arg1: "1", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {308});
            }

            public override void Execute() {
                if (true) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}