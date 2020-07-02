namespace Maple2.Trigger._02020112_bf {
    public static class _reconnect {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reconnect") == 1) {
                    return new StateBuff쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff쏴주기 : TriggerState {
            internal StateBuff쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {916}, arg2: 70002105, arg3: 1, arg5: false);
                context.SetTimer(arg1: "1", arg2: 5, arg3: false, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Reconnect") == 2) {
                    return new StateEnd(context);
                }

                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {931}, arg2: 70002112, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}