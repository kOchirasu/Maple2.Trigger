namespace Maple2.Trigger._02000441_bf {
    public static class _boss_2 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "monster_respawn") == 1) {
                    return new StateMonsterHealth_75(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterHealth_75 : TriggerState {
            internal StateMonsterHealth_75(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 209) <= 0.75f) {
                    return new StateMonsterHealth_35(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{210, 211, 212, 213}, arg2: true);
            }
        }

        private class StateMonsterHealth_35 : TriggerState {
            internal StateMonsterHealth_35(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 209) <= 0.35f) {
                    return new StateMonster_마지막_리Spawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_마지막_리Spawn : TriggerState {
            internal StateMonster_마지막_리Spawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{214, 215, 216, 217}, arg2: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
