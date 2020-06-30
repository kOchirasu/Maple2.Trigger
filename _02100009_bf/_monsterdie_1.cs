using System;

namespace Maple2.Trigger._02100009_bf {
    public static class _monsterdie_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State유저감지(context);

        private class State유저감지 : TriggerState {
            internal State유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new int[] {1000049}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {100000001})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {100000002}, arg2: 50000217, arg3: 1, arg4: true, arg5: false);
                context.SetSkill(arg1: new int[] {1000049}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) { }
            }

            public override void OnExit() { }
        }
    }
}