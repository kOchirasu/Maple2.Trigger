namespace Maple2.Trigger._02000471_bf {
    public static class _elite_05 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "10002023clear") != 1 && context.GetUserValue(key: "SpawnCheck") == 1) {
                    return new StateSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSpawn : TriggerState {
            internal StateSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Buff") == 1) {
                    return new StateBuff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff : TriggerState {
            internal StateBuff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1999}, skillId: 70002041, level: 1, arg4: true, arg5: false);
                context.AddBuff(boxIds: new []{305}, skillId: 70002041, level: 1, arg4: true, arg5: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
