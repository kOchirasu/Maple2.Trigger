using System;

namespace Maple2.Trigger._02000347_bf {
    public static class _heal01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10000803}, arg2: 0);
                context.SetSkill(arg1: new int[] {701}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}