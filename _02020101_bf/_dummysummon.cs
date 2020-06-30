using System;

namespace Maple2.Trigger._02020101_bf {
    public static class _dummysummon {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Dummy", value: 1)) {
                    context.CreateMonster(arg1: new int[] {401}, arg2: false);
                    context.State = new State더미소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State더미소환 : TriggerState {
            internal State더미소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 900008, key: "Dummy", value: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {101})) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "Dummy", value: 0)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}