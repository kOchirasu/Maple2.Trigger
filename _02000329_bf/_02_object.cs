using System;

namespace Maple2.Trigger._02000329_bf {
    public static class _02_object {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State오브젝트_01(context);

        private class State오브젝트_01 : TriggerState {
            internal State오브젝트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {10001}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "100")) {
                    context.State = new State오브젝트_01_작동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State오브젝트_01_작동 : TriggerState {
            internal State오브젝트_01_작동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new int[] {10001}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}