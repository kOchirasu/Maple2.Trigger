using System;

namespace Maple2.Trigger._02020300_bf {
    public static class _elevator {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State메시지_대기(context);

        private class State메시지_대기 : TriggerState {
            internal State메시지_대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "elevator", value: 1)) {
                    context.State = new State엘리베이터_정지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_정지 : TriggerState {
            internal State엘리베이터_정지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020300_BF__MAIN__12$", arg3: new int[] {5000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.SetBreakable(arg1: new int[] {5001}, arg2: false);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "elevator", value: 0)) {
                    context.State = new State메시지_대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}