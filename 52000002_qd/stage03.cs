namespace Maple2.Trigger._52000002_qd {
    public static class _stage03 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000612, 10000613, 10000614, 10000615, 10000616}, arg2: 2)) {
                    return new State박스체크(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State박스체크 : TriggerState {
            internal State박스체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    return new State안내시작(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200206, textId: 25200206);
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{105})) {
                    return new StateEnd(context);
                }

                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200206);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
