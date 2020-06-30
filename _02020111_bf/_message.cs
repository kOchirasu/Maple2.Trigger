using System;

namespace Maple2.Trigger._02020111_bf {
    public static class _message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Message", value: 0)) {
                    context.State = new State메세지출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메세지출력 : TriggerState {
            internal State메세지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020111_BF__MESSAGE__0$", arg3: new int[] {4000});
            }

            public override void Execute() {
                if (context.UserValue(key: "Message", value: 1)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}