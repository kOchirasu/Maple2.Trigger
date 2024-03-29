namespace Maple2.Trigger._81000001_item {
    public static class _trap_03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000128}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000128}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{601, 602, 603, 604}, visible: false, arg3: 0, arg4: 0);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "128", seconds: 5, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "128")) {
                    context.SetMesh(triggerIds: new []{601, 602, 603, 604}, visible: true, arg3: 0, arg4: 0);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "128");
            }
        }
    }
}
