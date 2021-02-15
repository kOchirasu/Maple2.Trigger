namespace Maple2.Trigger._02020300_bf {
    public static class _elevator {
        public class State메시지_Wait : TriggerState {
            internal State메시지_Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "elevator") == 1) {
                    return new State엘리베이터_정지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터_정지 : TriggerState {
            internal State엘리베이터_정지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020300_BF__MAIN__12$", arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.SetBreakable(arg1: new[] {5001}, arg2: false);
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "elevator") == 0) {
                    return new State메시지_Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}