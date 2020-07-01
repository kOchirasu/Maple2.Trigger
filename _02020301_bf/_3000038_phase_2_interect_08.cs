namespace Maple2.Trigger._02020301_bf {
    public static class _3000038_phase_2_interect_08 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    // context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}