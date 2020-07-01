namespace Maple2.Trigger._02000315_bf {
    public static class _wounded_105 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "BridgeOpen", value: 0);
                context.SetInteractObject(arg1: new[] {10001040}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001040}, arg2: 0)) {
                    return new StateWakeUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWakeUp : TriggerState {
            internal StateWakeUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001040}, arg2: 2);
                context.CreateMonster(arg1: new[] {105}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BridgeOpen") == 2) {
                    return new StatePatrol02(context);
                }

                if (context.GetUserValue(key: "BridgeOpen") == 3) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol02 : TriggerState {
            internal StatePatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_1051");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BridgeOpen") == 3) {
                    return new StatePatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrol03 : TriggerState {
            internal StatePatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_1052");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}