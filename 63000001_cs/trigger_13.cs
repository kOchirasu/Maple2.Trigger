namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_13 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{313}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{113})) {
                    return new StateSetup13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup13 : TriggerState {
            internal StateSetup13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{313}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{113})) {
                    return new StateSetup13끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup13끝 : TriggerState {
            internal StateSetup13끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "413", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "413")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
