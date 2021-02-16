namespace Maple2.Trigger._02020062_bf {
    public static class _message {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020062_BF__MESSAGE__0$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "FieldGameStart") == 1) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "FieldGameStart") == 2) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}