namespace Maple2.Trigger._61000005_me {
    public static class _wait {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "90", seconds: 90, clearAtZero: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{196})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000005_ME__WAIT__0$", duration: 5000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 196) == 20) {
                    return new StateStart(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait(context);
                }

                if (context.TimeExpired(timerId: "90")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$61000005_ME__WAIT__1$", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
