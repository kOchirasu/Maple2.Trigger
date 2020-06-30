using System;

namespace Maple2.Trigger._99999849 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Test", value: 2)) {
                    // context.State = new State두번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}