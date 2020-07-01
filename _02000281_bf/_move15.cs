namespace Maple2.Trigger._02000281_bf {
    public static class _move15 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {815}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {195})) {
                    return new State발판발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판발동 : TriggerState {
            internal State발판발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: false);
                context.SetBreakable(arg1: new[] {815}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}