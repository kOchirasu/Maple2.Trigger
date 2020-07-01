namespace Maple2.Trigger._02000347_bf {
    public static class _guide {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    context.State = new State대기_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기_02 : TriggerState {
            internal State대기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 8);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000347_BF__MAIN1__5$", arg3: 5000, arg4: "0");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}