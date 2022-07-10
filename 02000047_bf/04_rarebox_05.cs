namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{405}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{205})) {
                    return new StateSetup05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05 : TriggerState {
            internal StateSetup05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{405}, visible: true);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{205})) {
                    return new StateSetup05끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup05끝 : TriggerState {
            internal StateSetup05끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "505", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "505")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
