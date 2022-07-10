namespace Maple2.Trigger._02100001_bf {
    public static class _3004_falldown {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3004}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9004})) {
                    return new StateRemoveMesh(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemoveMesh : TriggerState {
            internal StateRemoveMesh(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9004})) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
