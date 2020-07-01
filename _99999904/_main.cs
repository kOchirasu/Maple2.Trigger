using System;

namespace Maple2.Trigger._99999904 {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000084}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {902})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000084}, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State비활성화 : TriggerState {
            internal State비활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000084}, arg2: 2, arg3: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}