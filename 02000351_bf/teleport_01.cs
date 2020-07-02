namespace Maple2.Trigger._02000351_bf {
    public static class _teleport_01 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {705}, arg2: 1)) {
                    return new StateStart_sound(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {9000005}, arg2: true);
            }
        }

        private class StateStart_sound : TriggerState {
            internal StateStart_sound(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {9000005}, arg2: false);
            }
        }
    }
}