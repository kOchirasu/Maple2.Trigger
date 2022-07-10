namespace Maple2.Trigger._52020001_qd {
    public static class _monster_respawn_2_2 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new StateMonsterDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDead : TriggerState {
            internal StateMonsterDead(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{6000031})) {
                    return new StateMobCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMobCreation : TriggerState {
            internal StateMobCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{6000031}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateMonsterDead(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
