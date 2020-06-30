using System;

namespace Maple2.Trigger._02010057_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}