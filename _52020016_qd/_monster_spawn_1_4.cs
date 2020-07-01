namespace Maple2.Trigger._52020016_qd {
    public static class _monster_spawn_1_4 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn_phase_1") == 1) {
                    return new State전투페이즈(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투페이즈 : TriggerState {
            internal State전투페이즈(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000006}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {4000006})) {
                    return new State몬스터리젠(context);
                }

                if (context.GetUserValue(key: "respawn_phase_1_end") == 1) {
                    return new State끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터리젠 : TriggerState {
            internal State몬스터리젠(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {4000008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {4000008})) {
                    return new State전투페이즈(context);
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
                context.DestroyMonster(arg1: new[] {4000006}, arg2: false);
                context.DestroyMonster(arg1: new[] {4000008}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}