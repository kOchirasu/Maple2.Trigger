using System;

namespace Maple2.Trigger._03100000_se_common {
    public static class _gettrophy {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StategetTrophy(context);

        private class StategetTrophy : TriggerState {
            internal StategetTrophy(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}