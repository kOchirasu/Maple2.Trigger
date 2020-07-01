namespace Maple2.Trigger._99999840 {
    public static class _badmob3 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "BadMob", value: 0);
            }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 913) == true) {
                    return new State몬스터스폰(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터스폰 : TriggerState {
            internal State몬스터스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {993}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {991, 992, 993})) {
                    return new State신호쏴주기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State신호쏴주기 : TriggerState {
            internal State신호쏴주기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "BadMob", value: 1);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetDungeonVariable(id: 913) == false) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}