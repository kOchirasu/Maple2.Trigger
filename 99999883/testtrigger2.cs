namespace Maple2.Trigger._99999883 {
    public static class _testtrigger2 {
        public class State1 : TriggerState {
            internal State1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "현재 State1");
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "test") == 1) {
                    return new State2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2 : TriggerState {
            internal State2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "test", value: 0);
                context.DebugString(message: "현재 State2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
