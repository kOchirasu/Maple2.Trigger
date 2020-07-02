namespace Maple2.Trigger._99999844 {
    public static class _operate2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon") == 1) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {206, 207}, arg2: false);
                context.SetUserValue(triggerId: 99990003, key: "summon", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "summon") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}