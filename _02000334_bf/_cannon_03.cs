namespace Maple2.Trigger._02000334_bf {
    public static class _cannon_03 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "cannon_03") == 1) {
                    return new State마킹비표시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마킹비표시 : TriggerState {
            internal State마킹비표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98012}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90013, arg2: new[] {190})) {
                    return new State마킹표시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마킹표시 : TriggerState {
            internal State마킹표시(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {98012}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.NpcDetected(arg1: 90013, arg2: new[] {190})) {
                    return new State마킹비표시(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}