namespace Maple2.Trigger._02020021_bf {
    public static class _timer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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
                context.SetTimer(timerId: "BattleTimer", seconds: 300, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                return new State타이머체크(context);
            }

            public override void OnExit() { }
        }

        private class State타이머체크 : TriggerState {
            internal State타이머체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "BattleTimer")) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "BattleTimer");
                context.SetUserValue(triggerId: 99990002, key: "Timer", value: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
