namespace Maple2.Trigger._99999883 {
    public static class _testtrigger2 {
        public class StateState1 : TriggerState {
            internal StateState1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DebugString(message: "현재 State1");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "test") == 1) {
                    return new StateState2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateState2 : TriggerState {
            internal StateState2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "test", value: 0);
                context.DebugString(message: "현재 State2");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateState1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}