namespace Maple2.Trigger._02000268_bf_02 {
    public static class _ladder {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000456}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000456}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{301, 302, 303, 304, 305}, visible: true, arg3: 0, arg4: 500, arg5: 0f);
                context.SetTimer(timerId: "10", seconds: 10, autoRemove: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    context.SetMesh(triggerIds: new []{305, 304, 303, 302, 301}, visible: false, arg3: 0, arg4: 500, arg5: 0f);
                    return new State재사용Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용Wait : TriggerState {
            internal State재사용Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "170", seconds: 170, autoRemove: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "170")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
