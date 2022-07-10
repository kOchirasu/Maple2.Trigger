namespace Maple2.Trigger._02000261_bf_02 {
    public static class _portal_11 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000365}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000365}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 11, visible: false, enabled: true, minimapVisible: false);
                context.SetTimer(timerId: "2", seconds: 2, clearAtZero: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetPortal(portalId: 11, visible: false, enabled: false, minimapVisible: false);
                    return new State재사용Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용Wait : TriggerState {
            internal State재사용Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3, clearAtZero: false, display: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
