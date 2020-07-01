namespace Maple2.Trigger._02000281_bf {
    public static class _move13 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {813}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {193})) {
                    context.State = new State발판발동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State발판발동 : TriggerState {
            internal State발판발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30, arg3: false);
                context.SetBreakable(arg1: new[] {813}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}