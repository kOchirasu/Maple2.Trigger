namespace Maple2.Trigger._02000329_bf {
    public static class _cave {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {711})) {
                    context.State = new State동굴전환시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State동굴전환시작 : TriggerState {
            internal State동굴전환시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6701}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}