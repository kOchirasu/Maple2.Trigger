namespace Maple2.Trigger._02000443_bf {
    public static class _error {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateBuff_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_1 : TriggerState {
            internal StateBuff_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 49200002, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new StateBuff_2(context);
                }

                if (context.GetUserValue(key: "debuff") == 1) {
                    // return new State끝(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_2 : TriggerState {
            internal StateBuff_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 49200002, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 60000)) {
                    return new StateBuff_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}