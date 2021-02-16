namespace Maple2.Trigger._02000303_bf {
    public static class _object_03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000596, 10000597, 10000598, 10000599, 10000600}, arg2: 0);
                context.SetEffect(arg1: new[] {60596, 60597, 60598, 60599, 60600}, arg2: false);
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
                context.SetEffect(arg1: new[] {60596}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000596}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000596}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60596}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation02 : TriggerState {
            internal StateCreation02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60597}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000597}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000597}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60597}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation03 : TriggerState {
            internal StateCreation03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60598}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000598}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000598}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60598}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation04 : TriggerState {
            internal StateCreation04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60599}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000599}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000599}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60599}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation05 : TriggerState {
            internal StateCreation05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {60600}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000600}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000600}, arg2: 0)) {
                    context.SetEffect(arg1: new[] {60600}, arg2: false);
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