namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{307}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{107})) {
                    return new StateSetup07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07 : TriggerState {
            internal StateSetup07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{307}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{107})) {
                    return new StateSetup07끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07끝 : TriggerState {
            internal StateSetup07끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "407", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "407")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
