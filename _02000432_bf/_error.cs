using System;

namespace Maple2.Trigger._02000432_bf {
    public static class _error {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    // context.State = new Statebuff_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}