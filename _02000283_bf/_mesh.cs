using System;

namespace Maple2.Trigger._02000283_bf {
    public static class _mesh {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State종료(context);

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}