namespace Maple2.Trigger._52000076_qd {
    public static class _wall_09 {
        public class State벽재생 : TriggerState {
            internal State벽재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39001, 39002, 39003, 39004, 39005, 39006, 39007, 39008, 39009, 39010, 39011, 39012, 39013, 39014, 39015, 39016, 39017, 39018, 39019}, visible: true, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{109})) {
                    return new State벽삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽삭제 : TriggerState {
            internal State벽삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{39001, 39002, 39003, 39004, 39005, 39006, 39007, 39008, 39009, 39010, 39011, 39012, 39013, 39014, 39015, 39016, 39017, 39018, 39019}, visible: false, arg3: 0, arg4: 10, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{109})) {
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
