namespace Maple2.Trigger._61000009_me {
    public static class _timer_quest {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetTimer(id: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateReady_Idle_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "60", arg2: 60, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    return new StateDaily_quest(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDaily_quest : TriggerState {
            internal StateDaily_quest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 799, arg2: "trigger", arg3: "dailyquest_start");
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}