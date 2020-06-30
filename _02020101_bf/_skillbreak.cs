using System;

namespace Maple2.Trigger._02020101_bf {
    public static class _skillbreak {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900001, key: "SkillBreakFail", value: 0);
            }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 70002181, level: 1)) {
                    context.State = new State스킬브레이크_실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬브레이크_실패 : TriggerState {
            internal State스킬브레이크_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {1003}, arg2: 70002151, arg3: 1, arg5: false);
                context.SetUserValue(triggerID: 900001, key: "SkillBreakFail", value: 1);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
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