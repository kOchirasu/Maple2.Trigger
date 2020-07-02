namespace Maple2.Trigger._02000311_bf {
    public static class _buff_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Buff_02") == 1) {
                    return new StateBuff_02_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_02_Ready : TriggerState {
            internal StateBuff_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    return new StateBuff_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_02 : TriggerState {
            internal StateBuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    return new StateBuff_02_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_02_Start : TriggerState {
            internal StateBuff_02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {702}, arg2: 50003006, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBuff_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}