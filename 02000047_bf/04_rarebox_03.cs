namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{403}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{203})) {
                    return new StateSetup03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup03 : TriggerState {
            internal StateSetup03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{403}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{203})) {
                    return new StateSetup03끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup03끝 : TriggerState {
            internal StateSetup03끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "503", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "503")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
