namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel2 {
        public class StateSetupReset : TriggerState {
            internal StateSetupReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
                context.SetUserValue(triggerId: 99990025, key: "MovePanel02", value: 0);
                context.SetInteractObject(arg1: new[] {12000116}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MovePanel02") == 1) {
                    return new State레버Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State레버Creation : TriggerState {
            internal State레버Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000116}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000116}, arg2: 0)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup이동 : TriggerState {
            internal StateSetup이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000116}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9201})) {
                    context.SetBreakable(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: true);
                    return new StateWait(context);
                }

                if (context.UserDetected(arg1: new[] {9204})) {
                    context.SetBreakable(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: true);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9204})) {
                    context.SetBreakable(arg1: new[] {2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, arg2: false);
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}