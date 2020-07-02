namespace Maple2.Trigger._02020301_bf {
    public static class _3000039_phase_2_interect_09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    // return new StateStart(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}