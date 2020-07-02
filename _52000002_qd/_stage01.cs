namespace Maple2.Trigger._52000002_qd {
    public static class _stage01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    return new State안내시작(context);
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200204, textId: 25200204);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000607, 10000608, 10000609, 10000610, 10000611}, arg2: 0)) {
                    return new StateEnd(context);
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200204);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}