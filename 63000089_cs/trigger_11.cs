namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_11 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{311}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{111})) {
                    return new StateSetup11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup11 : TriggerState {
            internal StateSetup11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{311}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{111})) {
                    return new StateSetup11끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup11끝 : TriggerState {
            internal StateSetup11끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "411", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "411")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
