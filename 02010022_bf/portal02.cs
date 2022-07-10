namespace Maple2.Trigger._02010022_bf {
    public static class _portal02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 60, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000901}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000901}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 60, visible: false, enabled: true, minimapVisible: false);
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetPortal(portalId: 60, visible: false, enabled: false, minimapVisible: false);
                    return new State재사용Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용Wait : TriggerState {
            internal State재사용Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
