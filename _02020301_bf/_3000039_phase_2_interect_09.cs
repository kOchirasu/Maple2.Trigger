using System;

namespace Maple2.Trigger._02020301_bf {
    public static class _3000039_phase_2_interect_09 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
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