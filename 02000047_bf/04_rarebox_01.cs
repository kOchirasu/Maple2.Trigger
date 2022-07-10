namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{401}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{201})) {
                    return new StateSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup01 : TriggerState {
            internal StateSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{401}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{201})) {
                    return new StateSetup01끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup01끝 : TriggerState {
            internal StateSetup01끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "501", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "501")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
