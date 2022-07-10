namespace Maple2.Trigger._02020145_bf {
    public static class _summon_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new State소환Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환Prepare : TriggerState {
            internal State소환Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_1") == 1) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_2") == 1) {
                    return new StateMonsterSpawn_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn_2 : TriggerState {
            internal StateMonsterSpawn_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
