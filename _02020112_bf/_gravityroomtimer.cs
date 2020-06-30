using System;

namespace Maple2.Trigger._02020112_bf {
    public static class _gravityroomtimer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 99990020, key: "TimerReset", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Timer", value: 1)) {
                    context.State = new State타이머시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 10, arg3: true, arg4: true, arg5: -40);
            }

            public override void Execute() {
                if (context.UserValue(key: "Timer", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋 : TriggerState {
            internal State리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.SetUserValue(triggerID: 99990020, key: "TimerReset", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "Timer", value: 2)) {
                    context.State = new State종료(context);
                    return;
                }

                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.SetUserValue(triggerID: 99990020, key: "TimerReset", value: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}