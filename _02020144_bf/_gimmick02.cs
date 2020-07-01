namespace Maple2.Trigger._02020144_bf {
    public static class _gimmick02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Plant") == 1) {
                    return new State몬스터소환(context);
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터소환 : TriggerState {
            internal State몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State힌트(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State힌트 : TriggerState {
            internal State힌트(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 4000)) {
                    return new State알림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State알림 : TriggerState {
            internal State알림(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 25000)) {
                    return new State종료(context);
                }

                if (context.MonsterDead(arg1: new[] {301, 302, 303, 304})) {
                    context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {301, 302, 303, 304}, arg2: false);
                context.SetUserValue(triggerId: 900004, key: "Plant", value: 0);
            }

            public override TriggerState Execute() {
                return new State대기(context);
            }

            public override void OnExit() { }
        }
    }
}