using System;

namespace Maple2.Trigger._02000368_bf {
    public static class _mob_02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7201}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "1001")) {
                    context.State = new State전투01(context);
                    return;
                }

                if (context.UserDetected(arg1: "1002")) {
                    context.State = new State전투01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투01 : TriggerState {
            internal State전투01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201, 211}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {201, 211})) {
                    context.State = new State전투02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투02 : TriggerState {
            internal State전투02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSkill(arg1: new int[] {7201}, arg2: true);
                context.CreateMonster(arg1: new int[] {202}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {202})) {
                    context.State = new State종료(context);
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