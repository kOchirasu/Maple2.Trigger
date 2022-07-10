namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_1_4 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn_phase_1") == 1) {
                    return new State전투Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Phase : TriggerState {
            internal State전투Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000006}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000006})) {
                    return new StateMonster리젠(context);
                }

                if (context.GetUserValue(key: "respawn_phase_1_end") == 1) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster리젠 : TriggerState {
            internal StateMonster리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{4000008})) {
                    return new State전투Phase(context);
                }

                if (context.GetUserValue(key: "respawn_phase_1_end") == 1) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State끝 : TriggerState {
            internal State끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{4000006}, arg2: false);
                context.DestroyMonster(spawnIds: new []{4000008}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
