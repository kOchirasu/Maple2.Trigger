namespace Maple2.Trigger._02000432_bf {
    public static class _error {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    // return new Statebuff_1(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}