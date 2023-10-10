namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{310}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{110})) {
                    return new StateSetup10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10 : TriggerState {
            internal StateSetup10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{310}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{110})) {
                    return new StateSetup10끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10끝 : TriggerState {
            internal StateSetup10끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "410", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "410")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
