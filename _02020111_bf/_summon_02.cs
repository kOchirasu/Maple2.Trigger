namespace Maple2.Trigger._02020111_bf {
    public static class _summon_02 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new State소환준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환준비 : TriggerState {
            internal State소환준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new State시작(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_1") == 1) {
                    return new State몬스터등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new State시작(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_2") == 1) {
                    return new State몬스터등장_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장_2 : TriggerState {
            internal State몬스터등장_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}