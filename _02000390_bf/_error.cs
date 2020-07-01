namespace Maple2.Trigger._02000390_bf {
    public static class _error {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new Statequest_idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new Stateerror(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateerror : TriggerState {
            internal Stateerror(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000390, arg2: 2, arg3: 702, arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequest_idle : TriggerState {
            internal Statequest_idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Error") == 1) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new Statequest_error(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001518}, arg3: new byte[] {1})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001517}, arg3: new byte[] {2})) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequest_error : TriggerState {
            internal Statequest_error(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveRandomUser(arg1: 02000390, arg2: 2, arg3: 702, arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statequest_idle(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001518}, arg3: new byte[] {1})) {
                    context.State = new Stateend(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50001517}, arg3: new byte[] {2})) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1001, 1002}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}