namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel2 {
        public class StateSetupReset : TriggerState {
            internal StateSetupReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, visible: false);
                context.SetUserValue(triggerId: 99990025, key: "MovePanel02", value: 0);
                context.SetInteractObject(interactIds: new []{12000116}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MovePanel02") == 1) {
                    return new StateLeverCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCreation : TriggerState {
            internal StateLeverCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000116}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000116}, arg2: 0)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup이동 : TriggerState {
            internal StateSetup이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, visible: true);
                context.SetInteractObject(interactIds: new []{12000116}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9201})) {
                    context.SetBreakable(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, enabled: true);
                    return new StateWait(context);
                }

                if (context.UserDetected(boxIds: new []{9204})) {
                    context.SetBreakable(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, enabled: true);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9204})) {
                    context.SetBreakable(triggerIds: new []{2100, 2101, 2102, 2103, 2104, 2105, 2106, 2107, 2108}, enabled: false);
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
