namespace Maple2.Trigger._02020065_bf {
    public static class _battle3_object2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{812}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_2") == 1) {
                    return new StateTurretEnabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurretEnabled : TriggerState {
            internal StateTurretEnabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{812}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_2") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{812})) {
                    return new StateTurretDisabled(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTurretDisabled : TriggerState {
            internal StateTurretDisabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_2") == 0) {
                    return new StateWait(context);
                }

                if (context.MonsterDead(spawnIds: new []{801})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{812}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Battle3_TurretSpawn_2") == 1) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
