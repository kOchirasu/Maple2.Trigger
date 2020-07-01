namespace Maple2.Trigger._02020027_bf {
    public static class _battle_6 {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990009, key: "summon_2", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1003})) {
                    context.State = new State스킬사용(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬사용 : TriggerState {
            internal State스킬사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "summon_2") == 1) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: false, arg3: 1000);
            }

            public override void Execute() {
                if (true) {
                    // context.State = new State길막삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}