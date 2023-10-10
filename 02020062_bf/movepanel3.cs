namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel3 {
        public class StateSetupReset : TriggerState {
            internal StateSetupReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, visible: false);
                context.SetUserValue(triggerId: 99990026, key: "MovePanel03", value: 0);
                context.SetInteractObject(interactIds: new []{12000117}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "MovePanel03") == 1) {
                    return new StateLeverCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCreation : TriggerState {
            internal StateLeverCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000117}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000117}, arg2: 0)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup이동 : TriggerState {
            internal StateSetup이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(triggerIds: new []{2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, visible: true);
                context.SetInteractObject(interactIds: new []{12000117}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9202})) {
                    context.SetBreakable(triggerIds: new []{2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, enabled: true);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{2200, 2201, 2202, 2203, 2204, 2205, 2206, 2207, 2208}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
