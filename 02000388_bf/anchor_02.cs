namespace Maple2.Trigger._02000388_bf {
    public static class _anchor_02 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1505, 1506, 1507, 1508, 1509}, visible: true, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001098}, arg2: 0)) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1505, 1506, 1507, 1508, 1509}, visible: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
