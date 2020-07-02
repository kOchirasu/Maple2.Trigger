namespace Maple2.Trigger._02000329_bf {
    public static class _cave {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {711})) {
                    return new State동굴전환시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동굴전환시작 : TriggerState {
            internal State동굴전환시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6701}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}