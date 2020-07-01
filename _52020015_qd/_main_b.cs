namespace Maple2.Trigger._52020015_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2002}, arg2: new[] {60200010},
                    arg3: new byte[] {1})) {
                    context.State = new StateIdle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}