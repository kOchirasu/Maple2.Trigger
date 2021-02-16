namespace Maple2.Trigger._52000002_qd {
    public static class _sheep_04 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {614}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000616}, arg2: 0)) {
                    return new StateNPC교체(context);
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC교체 : TriggerState {
            internal StateNPC교체(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 1);
                context.SetInteractObject(arg1: new[] {10000616}, arg2: 2);
                context.CreateMonster(arg1: new[] {1094});
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateNPC이동(context);
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "6", arg2: 6);
                context.MoveNpc(arg1: 1094, arg2: "MS2PatrolData_1094");
                context.SetEffect(arg1: new[] {614}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 1094, script: "$52000002_QD__SHEEP_04__0$", arg4: 2);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    return new StateNPCDestroy(context);
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1094});
            }

            public override TriggerState Execute() {
                return new StateWaitStart(context);
            }

            public override void OnExit() { }
        }
    }
}