namespace Maple2.Trigger._02000351_bf {
    public static class _teleport_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{705}, jobCode: 1)) {
                    return new StateStart_sound(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{9000005}, visible: true);
            }
        }

        private class StateStart_sound : TriggerState {
            internal StateStart_sound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{9000005}, visible: false);
            }
        }
    }
}
