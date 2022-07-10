namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_08 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{308}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{108})) {
                    return new StateSetup08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08 : TriggerState {
            internal StateSetup08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{308}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{108})) {
                    return new StateSetup08끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08끝 : TriggerState {
            internal StateSetup08끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "408", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "408")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
