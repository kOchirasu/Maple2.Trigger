namespace Maple2.Trigger._64000001_gd {
    public static class _wait {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 104) == 6) {
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
