namespace Maple2.Trigger._02000311_bf {
    public static class _buff_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateBuff_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_02 : TriggerState {
            internal StateBuff_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateBuff_02_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_02_Start : TriggerState {
            internal StateBuff_02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{702}, skillId: 50003006, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBuff_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
