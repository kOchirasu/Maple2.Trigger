namespace Maple2.Trigger._02000303_bf {
    public static class _object_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000586, 10000587, 10000588, 10000589, 10000590}, state: 0);
                context.SetEffect(triggerIds: new []{60586, 60587, 60588, 60589, 60590}, visible: false);
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
                context.SetEffect(triggerIds: new []{60586}, visible: true);
                context.SetInteractObject(interactIds: new []{10000586}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000586}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60586}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation02 : TriggerState {
            internal StateCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000587}, state: 1);
                context.SetEffect(triggerIds: new []{60587}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000587}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60587}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation03 : TriggerState {
            internal StateCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60588}, visible: true);
                context.SetInteractObject(interactIds: new []{10000588}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000588}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60588}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation04 : TriggerState {
            internal StateCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60589}, visible: true);
                context.SetInteractObject(interactIds: new []{10000589}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000589}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60589}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation05 : TriggerState {
            internal StateCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60590}, visible: true);
                context.SetInteractObject(interactIds: new []{10000590}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000590}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60590}, visible: false);
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
