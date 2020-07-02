namespace Maple2.Trigger._02020111_bf {
    public static class _message {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Message") == 0) {
                    return new State메세지출력(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State메세지출력 : TriggerState {
            internal State메세지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020111_BF__MESSAGE__0$", arg3: 4000);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Message") == 1) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}