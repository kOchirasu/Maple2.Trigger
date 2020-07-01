namespace Maple2.Trigger._02020101_bf {
    public static class _deathflowernotice {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "notice") == 1) {
                    context.State = new State경고(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경고 : TriggerState {
            internal State경고(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02020101_BF__DEATHFLOWERNOTICE__0$", arg3: 3000);
                context.SetUserValue(triggerId: 900005, key: "notice", value: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "notice") == 0) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "notice", value: 0);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}