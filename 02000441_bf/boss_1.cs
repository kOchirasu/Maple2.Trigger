namespace Maple2.Trigger._02000441_bf {
    public static class _boss_1 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "monster_buff") == 1) {
                    return new StateMonster_Dead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster_Dead : TriggerState {
            internal StateMonster_Dead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{401}) || context.MonsterDead(spawnIds: new []{402})) {
                    return new State초강력Buff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State초강력Buff : TriggerState {
            internal State초강력Buff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{401, 402}, skillId: 49200001, level: 1, arg4: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
