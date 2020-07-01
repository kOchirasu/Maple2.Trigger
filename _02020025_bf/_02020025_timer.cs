namespace Maple2.Trigger._02020025_bf {
    public static class _02020025_timer {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Timer") == 1) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "BattleTimer", arg2: 300, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
                return new State타이머체크(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크 : TriggerState {
            internal State타이머체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "BattleTimer")) {
                    return new State종료(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "BattleTimer");
                context.SetUserValue(triggerId: 99990002, key: "Timer", value: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}