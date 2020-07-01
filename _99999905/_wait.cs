namespace Maple2.Trigger._99999905 {
    public static class _wait {
        public class State시간표확인 : TriggerState {
            internal State시간표확인(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10, arg3: false);
                context.SetEventUI(arg1: 1, arg2: "$99999905__WAIT__0$", arg3: 5000, arg4: "0");
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 101) == 10) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "88", arg2: 1200, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "88")) {
                    context.State = new State시간표확인(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}