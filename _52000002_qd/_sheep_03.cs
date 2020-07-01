using System;

namespace Maple2.Trigger._52000002_qd {
    public static class _sheep_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {613}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000614}, arg2: 0)) {
                    context.State = new StateNPC교체(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {101})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetInteractObject(arg1: new int[] {10000614}, arg2: 2);
                context.CreateMonster(arg1: new int[] {1093});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateNPC이동(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {101})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
                context.SetEffect(arg1: new int[] {613}, arg2: true);
                context.MoveNpc(arg1: 1093, arg2: "MS2PatrolData_1093");
                context.SetConversation(arg1: 1, arg2: 1093, arg3: "$52000002_QD__SHEEP_03__0$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateNPC소멸(context);
                    return;
                }

                if (!context.UserDetected(arg1: new int[] {101})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1093});
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