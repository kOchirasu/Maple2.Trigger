using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _reconnect {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Reconnect", value: 1)) {
                    context.State = new State버프쏴주기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프쏴주기 : TriggerState {
            internal State버프쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {916}, arg2: 70002105, arg3: 1, arg5: false);
                context.SetTimer(arg1: "1", arg2: 5, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Reconnect", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {931}, arg2: 70002112, arg3: 1, arg5: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}