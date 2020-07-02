namespace Maple2.Trigger._99999988_plantest_11 {
    public static class _mobregen01 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {100})) {
                    return new State웜리젠91(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웜리젠91 : TriggerState {
            internal State웜리젠91(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1, 2, 3});
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1, 2, 3})) {
                    return new State웜리젠91CoolTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State웜리젠91CoolTime : TriggerState {
            internal State웜리젠91CoolTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "9");
                context.SetTimer(arg1: "9", arg2: 30);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.ResetTimer(arg1: "9");
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}