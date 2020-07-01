namespace Maple2.Trigger._52010056_qd {
    public static class _eventsection_b_monster {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301}, arg2: true);
                context.CreateMonster(arg1: new[] {302}, arg2: true);
                context.CreateMonster(arg1: new[] {303}, arg2: true);
                context.CreateMonster(arg1: new[] {304}, arg2: true);
                context.CreateMonster(arg1: new[] {305}, arg2: true);
                context.CreateMonster(arg1: new[] {306}, arg2: true);
                context.CreateMonster(arg1: new[] {307}, arg2: true);
                context.CreateMonster(arg1: new[] {308}, arg2: true);
                context.CreateMonster(arg1: new[] {309}, arg2: true);
                context.CreateMonster(arg1: new[] {310}, arg2: true);
                context.CreateMonster(arg1: new[] {311}, arg2: true);
                context.CreateMonster(arg1: new[] {312}, arg2: true);
                context.CreateMonster(arg1: new[] {313}, arg2: true);
                context.CreateMonster(arg1: new[] {314}, arg2: true);
                context.CreateMonster(arg1: new[] {315}, arg2: true);
                context.CreateMonster(arg1: new[] {316}, arg2: true);
                context.CreateMonster(arg1: new[] {317}, arg2: true);
                context.CreateMonster(arg1: new[] {318}, arg2: true);
                context.CreateMonster(arg1: new[] {319}, arg2: true);
                context.CreateMonster(arg1: new[] {320}, arg2: true);
                context.CreateMonster(arg1: new[] {321}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}