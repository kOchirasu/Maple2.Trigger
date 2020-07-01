namespace Maple2.Trigger._99999849 {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Test") == 2) {
                    // context.State = new State두번(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}