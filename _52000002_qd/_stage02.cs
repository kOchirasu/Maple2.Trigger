namespace Maple2.Trigger._52000002_qd {
    public static class _stage02 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
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
                context.ShowGuideSummary(entityId: 25200205, textId: 25200205);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000612, 10000613, 10000614, 10000615, 10000616}, arg2: 2)) {
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
                context.HideGuideSummary(entityId: 25200205);
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