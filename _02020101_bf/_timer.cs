namespace Maple2.Trigger._02020101_bf {
    public static class _timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "TimerReset", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 1) {
                    return new State타이머1_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머1_시작 : TriggerState {
            internal State타이머1_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerStart") == 0) {
                    return new State리셋_1(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new State리셋_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋_1 : TriggerState {
            internal State리셋_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "TimerReset", value: 1);
                context.ResetTimer(arg1: "1");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerStart") == 2) {
                    return new State타이머2_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머2_시작 : TriggerState {
            internal State타이머2_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerStart") == 0) {
                    return new State리셋_2(context);
                }

                if (context.TimeExpired(arg1: "2")) {
                    return new State리셋_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋_2 : TriggerState {
            internal State리셋_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "TimerReset", value: 2);
                context.ResetTimer(arg1: "2");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerStart") == 3) {
                    return new State타이머3_시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머3_시작 : TriggerState {
            internal State타이머3_시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 20, arg3: true, arg4: true, arg5: -40);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerStart") == 0) {
                    return new State리셋_3(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State리셋_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋_3 : TriggerState {
            internal State리셋_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "TimerReset", value: 3);
                context.ResetTimer(arg1: "3");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "TimerStart") == 9) {
                    return new State종료(context);
                }

                return null;
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

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}