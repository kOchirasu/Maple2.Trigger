namespace Maple2.Trigger._02000432_bf {
    public static class _wave01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "wave01") == 1) {
                    context.State = new State소환(context);
                    return;
                }

                if (context.GetUserValue(key: "EndDungeon") == 1) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909}, isAutoTargeting: true, randomPickCount: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.GetUserValue(key: "EndDungeon") == 1) {
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