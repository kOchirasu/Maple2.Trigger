namespace Maple2.Trigger._02000284_bf {
    public static class _ladder02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000436}, state: 1);
                context.SetMesh(triggerIds: new []{321, 322, 323, 324}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000436}, arg2: 0)) {
                    return new StateLadderCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderCreation : TriggerState {
            internal StateLadderCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000436}, state: 0);
                context.SetMesh(triggerIds: new []{321, 322, 323, 324}, visible: true, arg3: 0, arg4: 500, arg5: 0f);
                context.SetTimer(timerId: "1500", seconds: 1500, autoRemove: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1500")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
