namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2700 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2700, 2701, 2702, 2703, 2704, 2705, 2706}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12700, 22700}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92700})) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 10);
                context.SetEffect(triggerIds: new []{12700, 22700}, visible: true);
                context.SetRandomMesh(triggerIds: new []{2700, 2701, 2702, 2703, 2704, 2705, 2706}, visible: false, meshCount: 7, arg4: 300, delay: 300);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12700, 22700}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
