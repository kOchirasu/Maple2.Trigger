namespace Maple2.Trigger._02020098_bf {
    public static class _message {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {11})) {
                    return new State크리스탈활용안내DisplayGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State크리스탈활용안내DisplayGuide : TriggerState {
            internal State크리스탈활용안내DisplayGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 29200002, textId: 29200002);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    return new StateTrigger종료(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 29200002);
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