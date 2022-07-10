namespace Maple2.Trigger._02010028_bf {
    public static class _portal03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
                context.SetInteractObject(interactIds: new []{10000903}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000903}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: false);
                context.SetTimer(timerId: "2", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
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
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
