using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _reward {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000011}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {11000012}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
                    // context.State = new State생성조건(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}