namespace Maple2.Trigger._02020097_bf {
    public static class _message {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10})) {
                    return new StateWait상태(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait상태 : TriggerState {
            internal StateWait상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {12})) {
                    return new State경비병도움안내(context);
                }

                if (context.GetUserValue(key: "StairsOk2nd") == 1) {
                    return new StateTrigger종료(context);
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
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200001);
            }
        }

        private class StateTrigger종료 : TriggerState {
            internal StateTrigger종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}