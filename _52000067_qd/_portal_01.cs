using System;

namespace Maple2.Trigger._52000067_qd {
    public static class _portal_01 {
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
                context.CreateMonster(arg1: new int[] {803}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {803})) {
                    context.State = new Stateportal_off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateportal_off : TriggerState {
            internal Stateportal_off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52000067_QD__PORTAL_01__0$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52000067_QD__PORTAL_01__1$", arg4: 3, arg5: 2);
                context.SetEffect(arg1: new int[] {7010}, arg2: false);
                context.SetEffect(arg1: new int[] {7110}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}