namespace Maple2.Trigger._02000303_bf {
    public static class _object_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000591, 10000592, 10000593, 10000594, 10000595}, state: 0);
                context.SetEffect(triggerIds: new []{60591, 60592, 60593, 60594, 60595}, visible: false);
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
                if (context.RandomCondition(rate: 20f)) {
                    return new StateCreation01(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateCreation02(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateCreation03(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateCreation04(context);
                }

                if (context.RandomCondition(rate: 20f)) {
                    return new StateCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation01 : TriggerState {
            internal StateCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000591}, state: 1);
                context.SetEffect(triggerIds: new []{60591}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000591}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60591}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation02 : TriggerState {
            internal StateCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000592}, state: 1);
                context.SetEffect(triggerIds: new []{60592}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000592}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60592}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation03 : TriggerState {
            internal StateCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000593}, state: 1);
                context.SetEffect(triggerIds: new []{60593}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000593}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60593}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation04 : TriggerState {
            internal StateCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{60594}, visible: true);
                context.SetInteractObject(interactIds: new []{10000594}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000594}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60594}, visible: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation05 : TriggerState {
            internal StateCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000595}, state: 1);
                context.SetEffect(triggerIds: new []{60595}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000595}, arg2: 0)) {
                    context.SetEffect(triggerIds: new []{60595}, visible: false);
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
