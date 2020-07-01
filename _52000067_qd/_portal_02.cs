namespace Maple2.Trigger._52000067_qd {
    public static class _portal_02 {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 702) == 1) {
                    return new Stateportal(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateportal : TriggerState {
            internal Stateportal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {805}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {805})) {
                    return new Stateportal_off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 114, arg3: "$52000067_QD__PORTAL_02__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 109, arg3: "$52000067_QD__PORTAL_02__1$", arg4: 3, arg5: 1);
                context.SetEffect(arg1: new[] {7011}, arg2: false);
                context.SetEffect(arg1: new[] {7111}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}