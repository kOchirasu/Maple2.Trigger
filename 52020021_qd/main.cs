namespace Maple2.Trigger._52020021_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003073}, questStates: new byte[]{1})) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
