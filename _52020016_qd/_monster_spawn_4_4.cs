namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_4_4 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "respawn_phase_4") == 1) {
                    context.State = new State전투페이즈(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투페이즈 : TriggerState {
            internal State전투페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000405}, arg2: false);
                context.SetConversation(arg1: 1, arg2: 4000405, arg3: "그만 죽어주세요!!", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.GetNpcHpRate(spawnPointId: 4000405) <= 0.20f) {
                    context.State = new State몬스터소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소멸 : TriggerState {
            internal State몬스터소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {4000405}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) { }
            }

            public override void OnExit() { }
        }
    }
}