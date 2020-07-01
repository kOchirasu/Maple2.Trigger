namespace Maple2.Trigger._52000067_qd {
    public static class _portal_04 {
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
                context.CreateMonster(arg1: new[] {804}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {804})) {
                    return new Stateportal_off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$52000067_QD__PORTAL_04__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 105, arg3: "$52000067_QD__PORTAL_04__1$", arg4: 3, arg5: 2);
                context.SetEffect(arg1: new[] {7013}, arg2: false);
                context.SetEffect(arg1: new[] {7113}, arg2: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}