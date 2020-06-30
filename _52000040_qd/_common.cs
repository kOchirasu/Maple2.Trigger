using System;

namespace Maple2.Trigger._52000040_qd {
    public static class _common {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateend_01(context);

        private class Stateend_01 : TriggerState {
            internal Stateend_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}