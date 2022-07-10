namespace Maple2.Trigger._52000004_qd {
    public static class _brick_06 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3106}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{116})) {
                    return new StateSetup01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup01 : TriggerState {
            internal StateSetup01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    context.SetMesh(triggerIds: new []{3106}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
