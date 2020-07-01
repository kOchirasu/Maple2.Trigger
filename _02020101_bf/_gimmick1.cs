namespace Maple2.Trigger._02020101_bf {
    public static class _gimmick1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "summon") == 1) {
                    context.State = new State몬스터소환(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203, 204}, arg2: false);
                context.SetUserValue(triggerId: 900003, key: "summon", value: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {201, 202, 203, 204}, arg2: false);
                context.SetUserValue(triggerId: 900003, key: "summon", value: 2);
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