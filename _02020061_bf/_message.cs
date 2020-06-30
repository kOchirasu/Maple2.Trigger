using System;

namespace Maple2.Trigger._02020061_bf {
    public static class _message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020061_BF__MESSAGE__0$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.UserValue(key: "FieldGameStart", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "FieldGameStart", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}