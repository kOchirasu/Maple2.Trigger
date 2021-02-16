namespace Maple2.Trigger._02020066_bf {
    public static class _15001_pcfocetomove {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PortalOn", value: 0);
                context.SetPortal(portalId: 15700, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 15700, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PortalOn") == 2) {
                    return new StatePortalOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOff : TriggerState {
            internal StatePortalOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 15700, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "PortalOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}