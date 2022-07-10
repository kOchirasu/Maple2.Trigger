namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_18 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{318}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{118})) {
                    return new StateSetup18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18 : TriggerState {
            internal StateSetup18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{318}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{118})) {
                    return new StateSetup18끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup18끝 : TriggerState {
            internal StateSetup18끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "418", seconds: 2, clearAtZero: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "418")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
