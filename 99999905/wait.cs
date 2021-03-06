namespace Maple2.Trigger._99999905 {
    public static class _wait {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "10", arg2: 10, arg3: false);
                context.SetEventUI(arg1: 1, script: "$99999905__WAIT__0$", arg3: 5000, arg4: "0");
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 101) == 10) {
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