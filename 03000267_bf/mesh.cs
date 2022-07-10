namespace Maple2.Trigger._03000267_bf {
    public static class _mesh {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019}, visible: true, arg3: 0, arg4: 200, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10000724}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000724}, arg2: 0)) {
                    return new State부서짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부서짐 : TriggerState {
            internal State부서짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009, 3010, 3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019}, visible: false, arg3: 0, arg4: 200, arg5: 2f);
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
