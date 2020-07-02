namespace Maple2.Trigger._02020101_bf {
    public static class _dummysummon {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Dummy") == 1) {
                    context.CreateMonster(arg1: new[] {401}, arg2: false);
                    return new State더미소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State더미소환 : TriggerState {
            internal State더미소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900008, key: "Dummy", value: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateWait(context);
                }

                if (context.GetUserValue(key: "Dummy") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}