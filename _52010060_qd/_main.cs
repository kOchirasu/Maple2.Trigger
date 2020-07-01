namespace Maple2.Trigger._52010060_qd {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001}, arg2: 0)) {
                    context.State = new State크림슨발록등장(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크림슨발록등장 : TriggerState {
            internal State크림슨발록등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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