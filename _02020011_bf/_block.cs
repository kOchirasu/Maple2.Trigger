using System;

namespace Maple2.Trigger._02020011_bf {
    public static class _block {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true, arg5: 5f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State딜레이(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이 : TriggerState {
            internal State딜레이(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State사라짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State사라짐 : TriggerState {
            internal State사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false, arg5: 5f);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {101})) {
                    context.State = new State딜레이2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State딜레이2 : TriggerState {
            internal State딜레이2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}