namespace Maple2.Trigger._02020112_bf {
    public static class _gravityroomtimer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990020, key: "TimerReset", value: 0);
            }

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
                context.SetTimer(timerId: "1", seconds: 10, autoRemove: true, display: true, vOffset: -40);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Timer") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new State리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋 : TriggerState {
            internal State리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.SetUserValue(triggerId: 99990020, key: "TimerReset", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Timer") == 2) {
                    return new StateEnd(context);
                }

                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.SetUserValue(triggerId: 99990020, key: "TimerReset", value: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
