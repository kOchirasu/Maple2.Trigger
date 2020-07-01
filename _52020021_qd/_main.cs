namespace Maple2.Trigger._52020021_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003073}, arg3: new byte[] {1})) {
                    return new Stateidle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}