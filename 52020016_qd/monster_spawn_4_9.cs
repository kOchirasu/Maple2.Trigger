namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_4_9 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "respawn_phase_4") == 1) {
                    return new State전투Phase(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투Phase : TriggerState {
            internal State전투Phase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{4000410}, arg2: false);
                context.SetConversation(type: 1, spawnId: 4000410, script: "이만 죽어주세요!!", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetNpcHpRate(spawnId: 4000410) <= 0.20f) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{4000410}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
