namespace Maple2.Trigger._52100002_qd {
    public static class _wave01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "wave01") == 1) {
                    return new State소환(context);
                }

                if (context.GetUserValue(key: "EndDungeon") == 1) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SpawnNpcRange(rangeId: new[] {1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909}, isAutoTargeting: true, randomPickCount: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State대기(context);
                }

                if (context.GetUserValue(key: "EndDungeon") == 1) {
                    return new State종료(context);
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