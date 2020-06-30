using System;

namespace Maple2.Trigger._02020101_bf {
    public static class _debuff {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Debuff", value: 1)) {
                    context.State = new State디버프시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State디버프시작 : TriggerState {
            internal State디버프시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "Debuff", value: 0);
                context.AddBuff(arg1: new int[] {1004}, arg2: 70002122, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Debuff", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900002, key: "Debuff", value: 0);
                context.RemoveBuff(arg1: 1004, arg2: 70002122, arg3: "true");
                context.AddBuff(arg1: new int[] {1004}, arg2: 70002123, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Debuff", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}