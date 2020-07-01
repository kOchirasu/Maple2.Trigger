namespace Maple2.Trigger._02020101_bf {
    public static class _debuff {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 1) {
                    return new State디버프시작(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State디버프시작 : TriggerState {
            internal State디버프시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "Debuff", value: 0);
                context.AddBuff(arg1: new[] {1004}, arg2: 70002122, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 0) {
                    return new State대기(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900002, key: "Debuff", value: 0);
                context.RemoveBuff(arg1: 1004, arg2: 70002122, arg3: true);
                context.AddBuff(arg1: new[] {1004}, arg2: 70002123, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Debuff") == 0) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}