namespace Maple2.Trigger._02000047_bf {
    public static class _03_rarebox_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{302}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new StateSetup02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02 : TriggerState {
            internal StateSetup02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{302}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{102})) {
                    return new StateSetup02끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02끝 : TriggerState {
            internal StateSetup02끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "402", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "402")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
