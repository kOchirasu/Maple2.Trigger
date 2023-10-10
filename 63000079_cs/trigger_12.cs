namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{312}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{112})) {
                    return new StateSetup12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12 : TriggerState {
            internal StateSetup12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{312}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{112})) {
                    return new StateSetup12끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12끝 : TriggerState {
            internal StateSetup12끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "412", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "412")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
