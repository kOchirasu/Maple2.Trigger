namespace Maple2.Trigger._52000014_qd {
    public static class _cube_2500 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{2500, 2502, 2504}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(triggerIds: new []{12500}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{92500})) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 5);
                context.SetEffect(triggerIds: new []{12500}, visible: true);
                context.SetMesh(triggerIds: new []{2500}, visible: false, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{2502}, visible: false, arg3: 500, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{2504}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{12500}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
