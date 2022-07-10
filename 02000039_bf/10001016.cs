namespace Maple2.Trigger._02000039_bf {
    public static class _10001016 {
        public class StateInteractObjectWait : TriggerState {
            internal StateInteractObjectWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10001016}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001016}, arg2: 0)) {
                    return new State열림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State열림 : TriggerState {
            internal State열림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000}, visible: false, arg3: 0, arg4: 0, arg5: 3f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateInteractObjectWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
