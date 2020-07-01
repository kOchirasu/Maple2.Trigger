namespace Maple2.Trigger._02000389_bf {
    public static class _error {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    return new Stateend(context);
                }

                if (context.UserDetected(arg1: new[] {702})) {
                    return new Stateerror(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateerror : TriggerState {
            internal Stateerror(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000389, arg2: 5, arg3: 702, arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}