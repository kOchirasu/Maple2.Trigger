namespace Maple2.Trigger._02020144_bf {
    public static class _gimmick02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Plant") == 1) {
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
                context.CreateMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State힌트(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State힌트 : TriggerState {
            internal State힌트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State알림(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {301, 302, 303, 304})) {
                    context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
                context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
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