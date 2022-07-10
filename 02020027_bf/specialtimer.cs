namespace Maple2.Trigger._02020027_bf {
    public static class _specialtimer {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SpecialTimer") == 1) {
                    return new State타이머시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State타이머시작 : TriggerState {
            internal State타이머시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "SpecialTimer", seconds: 180, clearAtZero: true, display: false);
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
                if (context.TimeExpired(timerId: "SpecialTimer")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990002, key: "SpecialTimer", value: 0);
                context.ResetTimer(timerId: "SpecialTimer");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
