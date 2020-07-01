namespace Maple2.Trigger._61000009_me {
    public static class _timer_quest {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    context.State = new StateReady_Idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateReady_Idle_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle_02 : TriggerState {
            internal StateReady_Idle_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.State = new Statedaily_quest(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statedaily_quest : TriggerState {
            internal Statedaily_quest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 799, arg2: "trigger", arg3: "dailyquest_start");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}