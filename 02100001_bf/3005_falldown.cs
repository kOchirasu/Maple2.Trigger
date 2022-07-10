namespace Maple2.Trigger._02100001_bf {
    public static class _3005_falldown {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9005})) {
                    return new StateRemoveMesh(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveMesh : TriggerState {
            internal StateRemoveMesh(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3005}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9005})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
