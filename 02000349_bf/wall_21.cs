namespace Maple2.Trigger._02000349_bf {
    public static class _wall_21 {
        public class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{32101, 32102, 32103, 32104, 32105, 32106, 32107, 32108, 32109, 32110, 32111, 32112, 32113, 32114, 32115, 32116, 32117}, visible: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{121})) {
                    return new State벽삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{32101, 32102, 32103, 32104, 32105, 32106, 32107, 32108, 32109, 32110, 32111, 32112, 32113, 32114, 32115, 32116, 32117}, visible: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{121})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new State벽재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
