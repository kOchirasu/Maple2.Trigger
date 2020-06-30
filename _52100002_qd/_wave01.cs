using System;

namespace Maple2.Trigger._52100002_qd {
    public static class _wave01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "wave01", value: 1)) {
                    context.State = new State소환(context);
                    return;
                }

                if (context.UserValue(key: "EndDungeon", value: 1)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeID: new int[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909},
                    isAutoTargeting: true, randomPickCount: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.UserValue(key: "EndDungeon", value: 1)) {
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