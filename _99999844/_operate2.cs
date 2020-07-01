namespace Maple2.Trigger._99999844 {
    public static class _operate2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon") == 1) {
                    return new State몬스터소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {206, 207}, arg2: false);
                context.SetUserValue(triggerId: 99990003, key: "summon", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon") == 2) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}