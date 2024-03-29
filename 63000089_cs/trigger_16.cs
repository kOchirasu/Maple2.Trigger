namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_16 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{316}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{116})) {
                    return new StateSetup16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16 : TriggerState {
            internal StateSetup16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{316}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{116})) {
                    return new StateSetup16끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16끝 : TriggerState {
            internal StateSetup16끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "416", seconds: 2, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "416")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
