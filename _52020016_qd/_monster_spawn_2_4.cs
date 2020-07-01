namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_2_4 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn_phase_2") == 1) {
                    return new State전투페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투페이즈 : TriggerState {
            internal State전투페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000104}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 4000104, arg3: "하하하하 어디 한번 발버둥 쳐봐라!!", arg4: 3, arg5: 0);
            }

            public override TriggerState Execute() {
                if (context.GetNpcHpRate(spawnPointId: 4000104) <= 0.20f) {
                    return new State몬스터소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4000104}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}