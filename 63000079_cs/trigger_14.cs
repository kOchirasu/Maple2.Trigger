namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_14 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{314}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{114})) {
                    return new StateSetup14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14 : TriggerState {
            internal StateSetup14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{314}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{114})) {
                    return new StateSetup14끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14끝 : TriggerState {
            internal StateSetup14끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "414", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "414")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
