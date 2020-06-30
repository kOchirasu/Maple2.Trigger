using System;

namespace Maple2.Trigger._02020201_bf {
    public static class _altar1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "901")) {
                    context.State = new State전투시작체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작체크 : TriggerState {
            internal State전투시작체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {101})) {
                    context.State = new State생성대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성대기 : TriggerState {
            internal State생성대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "gogo", value: 1)) {
                    context.State = new State생성대기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성대기2 : TriggerState {
            internal State생성대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State전투체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {101})) {
                    context.State = new State제단생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제단생성 : TriggerState {
            internal State제단생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State제단파괴체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제단파괴체크 : TriggerState {
            internal State제단파괴체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201})) {
                    context.State = new State제단재생성시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제단재생성시간 : TriggerState {
            internal State제단재생성시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "Sidephase", value: 1, isModify: "true");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 40000)) {
                    context.SetAiExtraData(key: "Sidephase", value: -1, isModify: "true");
                    context.State = new State전투체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}