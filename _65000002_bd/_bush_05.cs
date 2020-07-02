namespace Maple2.Trigger._65000002_bd {
    public static class _bush_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 1001005, arg2: 70000075);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 1001005) == 1) {
                    return new StateBuff발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff발동 : TriggerState {
            internal StateBuff발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1001005}, arg2: 70000075, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StateBuff발동(context);
                }

                if (context.GetUserCount(boxId: 1001005) > 1) {
                    return new StateWait(context);
                }

                if (!context.UserDetected(arg1: new[] {1001005})) {
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