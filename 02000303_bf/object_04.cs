namespace Maple2.Trigger._02000303_bf {
    public static class _object_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000601, 10000602, 10000603, 10000604, 10000605}, state: 0);
                context.SetEffect(triggerIds: new []{60601, 60602, 60603, 60604, 60605}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreationRandom : TriggerState {
            internal StateCreationRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new StateCreation01(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateCreation02(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateCreation03(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateCreation04(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation01 : TriggerState {
            internal StateCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60601}, visible: true);
                context.SetInteractObject(interactIds: new []{10000601}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000601}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60601}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation02 : TriggerState {
            internal StateCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60602}, visible: true);
                context.SetInteractObject(interactIds: new []{10000602}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000602}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60602}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation03 : TriggerState {
            internal StateCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60603}, visible: true);
                context.SetInteractObject(interactIds: new []{10000603}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000603}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60603}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation04 : TriggerState {
            internal StateCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60604}, visible: true);
                context.SetInteractObject(interactIds: new []{10000604}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000604}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60604}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation05 : TriggerState {
            internal StateCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60605}, visible: true);
                context.SetInteractObject(interactIds: new []{10000605}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000605}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60605}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "120", seconds: 120);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "120")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
