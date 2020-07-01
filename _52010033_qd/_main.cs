namespace Maple2.Trigger._52010033_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003075, 10003076, 10003077, 10003078, 10003079}, arg3: new byte[] {1})) {
                    context.State = new StateNpcSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105, 106, 107, 108}, arg2: true);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}