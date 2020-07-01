namespace Maple2.Trigger._99999883 {
    public static class _testtrigger4 {
        public class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2001})) {
                    context.State = new Stateidle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}