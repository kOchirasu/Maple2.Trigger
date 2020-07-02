namespace Maple2.Trigger._02020111_bf {
    public static class _summon_02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

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
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_1") == 1) {
                    return new StateMonsterAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear : TriggerState {
            internal StateMonsterAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new StateStart(context);
                }

                if (context.GetUserValue(key: "Summon_Enemy_2") == 1) {
                    return new StateMonsterAppear_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterAppear_2 : TriggerState {
            internal StateMonsterAppear_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121, 122, 123, 124, 131, 132, 133, 134});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_Enemy_1") == 0) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}