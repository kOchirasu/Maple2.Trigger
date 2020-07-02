namespace Maple2.Trigger._99999849 {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

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