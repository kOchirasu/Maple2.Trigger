using System;

namespace Maple2.Trigger._65000002_bd {
    public static class _move {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State이동(context);

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 102, arg2: 10)) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}