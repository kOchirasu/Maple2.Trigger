namespace Maple2.Trigger._02010057_bf {
    public static class _main {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}