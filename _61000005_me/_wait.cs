namespace Maple2.Trigger._61000005_me {
    public static class _wait {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "90", arg2: 90, arg3: true, arg4: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {196})) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__WAIT__0$", arg3: 5000, arg4: "0");
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 196) == 20) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.TimeExpired(arg1: "90")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$61000005_ME__WAIT__1$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}