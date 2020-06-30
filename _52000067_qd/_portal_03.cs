using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _portal_03 {
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
                context.CreateMonster(arg1: new int[] {801}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {801})) {
                    context.State = new Stateportal_off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 108, arg3: "$52000067_QD__PORTAL_03__0$", arg4: 3, arg5: 1);
                context.SetConversation(arg1: 1, arg2: 115, arg3: "$52000067_QD__PORTAL_03__1$", arg4: 3, arg5: 1);
                context.SetEffect(arg1: new int[] {7012}, arg2: false);
                context.SetEffect(arg1: new int[] {7112}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}