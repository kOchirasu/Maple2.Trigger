namespace Maple2.Trigger._02020101_bf {
    public static class _dummysummon {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Dummy") == 1) {
                    context.CreateMonster(arg1: new[] {401}, arg2: false);
                    context.State = new State더미소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State더미소환 : TriggerState {
            internal State더미소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900008, key: "Dummy", value: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.GetUserValue(key: "Dummy") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}