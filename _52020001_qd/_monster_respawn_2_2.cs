namespace Maple2.Trigger._52020001_qd {
    public static class _monster_respawn_2_2 {
        public class State체력조건 : TriggerState {
            internal State체력조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "respawn") == 1) {
                    return new State몬스터사망(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터사망 : TriggerState {
            internal State몬스터사망(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {6000031})) {
                    return new State몬스터생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터생성 : TriggerState {
            internal State몬스터생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {6000031}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State몬스터사망(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}