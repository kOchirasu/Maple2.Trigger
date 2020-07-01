namespace Maple2.Trigger._02020201_bf {
    public static class _altar1 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new State전투시작체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투시작체크 : TriggerState {
            internal State전투시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    return new State생성대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성대기 : TriggerState {
            internal State생성대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "gogo") == 1) {
                    return new State생성대기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성대기2 : TriggerState {
            internal State생성대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State전투체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterInCombat(arg1: new[] {101})) {
                    return new State제단생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단생성 : TriggerState {
            internal State제단생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State제단파괴체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단파괴체크 : TriggerState {
            internal State제단파괴체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    return new State제단재생성시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State제단재생성시간 : TriggerState {
            internal State제단재생성시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Sidephase", value: 1, isModify: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    context.SetAiExtraData(key: "Sidephase", value: -1, isModify: true);
                    return new State전투체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}