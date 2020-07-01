namespace Maple2.Trigger._02020097_bf {
    public static class _message {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new State대기상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기상태 : TriggerState {
            internal State대기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {12})) {
                    return new State경비병도움안내(context);
                }

                if (context.GetUserValue(key: "StairsOk2nd") == 1) {
                    return new State트리거종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State경비병도움안내 : TriggerState {
            internal State경비병도움안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200001, textId: 29200001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State트리거종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200001);
            }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}