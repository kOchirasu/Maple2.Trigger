namespace Maple2.Trigger._02020062_bf {
    public static class _movepanel4 {
        public class StateSetupReset : TriggerState {
            internal StateSetupReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
                context.SetUserValue(triggerId: 99990027, key: "MovePanel04", value: 0);
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MovePanel04") == 1) {
                    return new StateLeverCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLeverCreation : TriggerState {
            internal StateLeverCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000118}, arg2: 0)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup이동 : TriggerState {
            internal StateSetup이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleBreakableObject(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: true);
                context.SetInteractObject(arg1: new[] {12000118}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9203})) {
                    context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: true);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {2300, 2301, 2302, 2303, 2304, 2305, 2306, 2307, 2308}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}