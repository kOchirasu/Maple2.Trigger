namespace Maple2.Trigger._99999844 {
    public static class _operate2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "summon") == 1) {
                    context.State = new State몬스터소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {206, 207}, arg2: false);
                context.SetUserValue(triggerId: 99990003, key: "summon", value: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "summon") == 2) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}