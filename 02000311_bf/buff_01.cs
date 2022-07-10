namespace Maple2.Trigger._02000311_bf {
    public static class _buff_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Buff_01") == 1) {
                    return new StateBuff_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_Ready : TriggerState {
            internal StateBuff_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateBuff_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_01 : TriggerState {
            internal StateBuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateBuff_01_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_01_Start : TriggerState {
            internal StateBuff_01_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 50003006, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBuff_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
