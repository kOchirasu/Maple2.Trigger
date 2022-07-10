namespace Maple2.Trigger._03000112_bf {
    public static class _mesh {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: true, arg3: 0, arg4: 50, arg5: 3f);
                context.SetInteractObject(interactIds: new []{10000729}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000729}, arg2: 0)) {
                    return new State부서짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부서짐 : TriggerState {
            internal State부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010}, visible: false, arg3: 0, arg4: 50, arg5: 3f);
                context.SetTimer(timerId: "25", seconds: 25);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "25")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
