namespace Maple2.Trigger._99999905 {
    public static class _wait {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10, clearAtZero: false);
                context.SetEventUI(arg1: 1, script: "$99999905__WAIT__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 101) == 10) {
                    return new StateStart(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new State시간표확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "88", seconds: 1200, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "88")) {
                    return new State시간표확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
