namespace Maple2.Trigger._63000038_cs {
    public static class _guide_boss {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "BossGuide") == 1) {
                    return new State가이드분기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드분기 : TriggerState {
            internal State가이드분기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199}, arg2: 100)) {
                    return new State가이드출력(context);
                }

                if (context.UserDetected(arg1: new[] {199}, arg2: 110)) {
                    return new State퀘스트체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘스트체크 : TriggerState {
            internal State퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {199}, arg2: new[] {40002651}, arg3: new byte[] {1})) {
                    return new State가이드출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State가이드출력 : TriggerState {
            internal State가이드출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 26300384, textId: 26300384);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.HideGuideSummary(entityId: 26300384);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}