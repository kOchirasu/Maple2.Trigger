namespace Maple2.Trigger._52100013_qd {
    public static class _error {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new Stateidle(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new Statequest_idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
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
                context.MoveRandomUser(arg1: 52100013, arg2: 2, arg3: 702, arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statequest_idle : TriggerState {
            internal Statequest_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    return new Stateend(context);
                }

                if (context.UserDetected(arg1: new[] {702})) {
                    return new Statequest_error(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {1})) {
                    return new Stateend(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100080}, arg3: new byte[] {2})) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statequest_error : TriggerState {
            internal Statequest_error(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 52100013, arg2: 2, arg3: 702, arg4: 4);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new Statequest_idle(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {1})) {
                    return new Stateend(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100080}, arg3: new byte[] {2})) {
                    return new Stateend(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}