namespace Maple2.Trigger._52000014_qd {
    public static class _move_6000 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{6000}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9600})) {
                    return new State침몰01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침몰01 : TriggerState {
            internal State침몰01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 17);
                context.SetBreakable(triggerIds: new []{6000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
