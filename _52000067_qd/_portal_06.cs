using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _portal_06 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 702, arg2: 1)) {
                    context.State = new Stateportal(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal : TriggerState {
            internal Stateportal(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {806}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {806})) {
                    context.State = new Stateportal_off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 114, arg3: "$52000067_QD__PORTAL_06__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 109, arg3: "$52000067_QD__PORTAL_06__1$", arg4: 3, arg5: 1);
                context.SetEffect(arg1: new int[] {7015}, arg2: false);
                context.SetEffect(arg1: new int[] {7115}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}