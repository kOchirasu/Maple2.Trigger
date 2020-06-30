using System;

namespace Maple2.Trigger._02000244_bf {
    public static class _trigger_03_01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {705, 706}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}