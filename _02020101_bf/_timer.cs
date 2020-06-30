using System;

namespace Maple2.Trigger._02020101_bf {
    public static class _timer {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "TimerReset", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 1)) {
                    context.State = new State타이머1_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머1_시작 : TriggerState {
            internal State타이머1_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "TimerStart", value: 0)) {
                    context.State = new State리셋_1(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State리셋_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋_1 : TriggerState {
            internal State리셋_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "TimerReset", value: 1);
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "TimerStart", value: 2)) {
                    context.State = new State타이머2_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머2_시작 : TriggerState {
            internal State타이머2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "TimerStart", value: 0)) {
                    context.State = new State리셋_2(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State리셋_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋_2 : TriggerState {
            internal State리셋_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "TimerReset", value: 2);
                context.ResetTimer(arg1: "2");
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "TimerStart", value: 3)) {
                    context.State = new State타이머3_시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State타이머3_시작 : TriggerState {
            internal State타이머3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.UserValue(key: "TimerStart", value: 0)) {
                    context.State = new State리셋_3(context);
                    return;
                }

                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State리셋_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋_3 : TriggerState {
            internal State리셋_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "TimerReset", value: 3);
                context.ResetTimer(arg1: "3");
            }

            public override void Execute() {
                if (context.UserValue(key: "TimerStart", value: 9)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "2");
                context.ResetTimer(arg1: "3");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}