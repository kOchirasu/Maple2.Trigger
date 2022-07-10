namespace Maple2.Trigger._61000010_me {
    public static class _bridge01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000041}, state: 1);
                context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000041}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{3101, 3102, 3103, 3104, 3105, 3106, 3107, 3108, 3109, 3110}, visible: false, arg3: 0, arg4: 100, arg5: 1f);
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
