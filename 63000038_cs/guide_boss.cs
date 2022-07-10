namespace Maple2.Trigger._63000038_cs {
    public static class _guide_boss {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "BossGuide") == 1) {
                    return new StateGuide분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide분기 : TriggerState {
            internal StateGuide분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{199}, jobCode: 100)) {
                    return new StateGuide출력(context);
                }

                if (context.UserDetected(boxIds: new []{199}, jobCode: 110)) {
                    return new StateQuest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest체크 : TriggerState {
            internal StateQuest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{199}, questIds: new []{40002651}, questStates: new byte[]{1})) {
                    return new StateGuide출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGuide출력 : TriggerState {
            internal StateGuide출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300384, textId: 26300384);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{105})) {
                    context.HideGuideSummary(entityId: 26300384);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
