namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_06 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{406}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{206})) {
                    return new StateSetup06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup06 : TriggerState {
            internal StateSetup06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{406}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{206})) {
                    return new StateSetup06끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup06끝 : TriggerState {
            internal StateSetup06끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "506", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "506")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
