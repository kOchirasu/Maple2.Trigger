namespace Maple2.Trigger._99999849 {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Test") == 2) {
                    // return new State두번(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}