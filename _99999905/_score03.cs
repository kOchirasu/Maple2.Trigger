namespace Maple2.Trigger._99999905 {
    public static class _score03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {604}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000415}, arg2: 0)) {
                    context.State = new State점수(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State점수 : TriggerState {
            internal State점수(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {604}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}