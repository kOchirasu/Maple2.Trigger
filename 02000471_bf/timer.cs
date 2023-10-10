namespace Maple2.Trigger._02000471_bf {
    public static class _timer {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040301, key: "TimerEnd", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimerStart") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "Timer", seconds: 420, autoRemove: true, display: true, vOffset: 0);
                context.SetEventUI(arg1: 1, script: "$02000471_BF__TIMER__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "Timer")) {
                    return new StateEnd_fail(context);
                }

                if (context.GetUserValue(key: "InteractClear") == 1) {
                    return new StateEnd_clear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_fail : TriggerState {
            internal StateEnd_fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040301, key: "TimerEnd", value: 1);
                context.ResetTimer(timerId: "Timer");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_clear : TriggerState {
            internal StateEnd_clear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2040301, key: "InteractClear", value: 1);
                context.ResetTimer(timerId: "Timer");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
