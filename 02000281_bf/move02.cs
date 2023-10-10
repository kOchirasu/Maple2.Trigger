namespace Maple2.Trigger._02000281_bf {
    public static class _move02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{802}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{182})) {
                    return new StateSetup발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup발동 : TriggerState {
            internal StateSetup발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "30", seconds: 30, autoRemove: false);
                context.SetBreakable(triggerIds: new []{802}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "30")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
