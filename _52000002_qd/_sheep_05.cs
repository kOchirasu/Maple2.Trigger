namespace Maple2.Trigger._52000002_qd {
    public static class _sheep_05 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {615}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000615}, arg2: 0)) {
                    context.State = new StateNPC교체(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
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
                context.CreateMonster(arg1: new[] {1095});
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.SetInteractObject(arg1: new[] {10000615}, arg2: 2);
                    context.State = new StateNPC이동(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
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
                context.SetEffect(arg1: new[] {615}, arg2: true);
                context.MoveNpc(arg1: 1095, arg2: "MS2PatrolData_1095");
                context.SetConversation(arg1: 1, arg2: 1095, arg3: "$52000002_QD__SHEEP_05__0$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateNPC소멸(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    context.State = new StateNPC소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소멸 : TriggerState {
            internal StateNPC소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1095});
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