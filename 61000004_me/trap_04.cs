namespace Maple2.Trigger._61000004_me {
    public static class _trap_04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000129}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{701, 702, 703}, visible: false, arg3: 0, arg4: 0);
                    return new State완료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "129", seconds: 5, autoRemove: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "129")) {
                    context.SetMesh(triggerIds: new []{701, 702, 703}, visible: true, arg3: 0, arg4: 0);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "129");
            }
        }
    }
}
