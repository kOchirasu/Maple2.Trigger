namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_17 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{317}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{117})) {
                    return new StateSetup17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17 : TriggerState {
            internal StateSetup17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{317}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{117})) {
                    return new StateSetup17끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17끝 : TriggerState {
            internal StateSetup17끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "417", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "417")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
