namespace Maple2.Trigger._02000047_bf {
    public static class _03_rarebox_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{304}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new StateSetup04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04 : TriggerState {
            internal StateSetup04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{304}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{104})) {
                    return new StateSetup04끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup04끝 : TriggerState {
            internal StateSetup04끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "404", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "404")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
