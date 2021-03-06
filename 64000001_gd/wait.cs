namespace Maple2.Trigger._64000001_gd {
    public static class _wait {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 10, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 104) == 6) {
                    return new StateStart(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State시간표확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "88", arg2: 1200, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    return new State시간표확인(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}