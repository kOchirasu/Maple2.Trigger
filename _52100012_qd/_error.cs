namespace Maple2.Trigger._52100012_qd {
    public static class _error {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    return new StateEnd(context);
                }

                if (context.UserDetected(arg1: new[] {702})) {
                    return new StateError(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateError : TriggerState {
            internal StateError(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 52100012, arg2: 5, arg3: 702, arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}