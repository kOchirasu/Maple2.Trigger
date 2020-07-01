using System;

namespace Maple2.Trigger._99999883 {
    public static class _testtrigger4 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSTART(context);

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2001})) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}