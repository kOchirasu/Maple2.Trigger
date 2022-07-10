namespace Maple2.Trigger._61000009_me {
    public static class _timer_quest {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    return new StateReady_Idle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReady_Idle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "60", seconds: 60, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "60")) {
                    return new StateDaily_quest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDaily_quest : TriggerState {
            internal StateDaily_quest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 799, type: "trigger", code: "dailyquest_start");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
