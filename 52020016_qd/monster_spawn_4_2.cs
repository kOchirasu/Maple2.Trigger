namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_4_2 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.CreateMonster(arg1: new[] {4000403}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 4000403, arg3: "왜 저만 죽어야 하죠?", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 4000403) <= 0.20f) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4000403}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}