namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_15 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{315}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{115})) {
                    return new StateSetup15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup15 : TriggerState {
            internal StateSetup15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{315}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{115})) {
                    return new StateSetup15끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup15끝 : TriggerState {
            internal StateSetup15끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "415", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "415")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
