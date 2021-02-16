namespace Maple2.Trigger._02000303_bf {
    public static class _object_01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000586, 10000587, 10000588, 10000589, 10000590}, arg2: 0);
                context.SetEffect(arg1: new[] {60586, 60587, 60588, 60589, 60590}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreationRandom : TriggerState {
            internal StateCreationRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 20f)) {
                    return new StateCreation01(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateCreation02(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateCreation03(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateCreation04(context);
                }

                if (context.RandomCondition(arg1: 20f)) {
                    return new StateCreation05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation01 : TriggerState {
            internal StateCreation01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60586}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000586}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000586}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60586}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation02 : TriggerState {
            internal StateCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000587}, arg2: 1);
                context.SetEffect(arg1: new[] {60587}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000587}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60587}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation03 : TriggerState {
            internal StateCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60588}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000588}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000588}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60588}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation04 : TriggerState {
            internal StateCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60589}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000589}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000589}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60589}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation05 : TriggerState {
            internal StateCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60590}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000590}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000590}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60590}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "120", arg2: 120);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "120")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}