namespace Maple2.Trigger._02020140_bf {
    public static class _setportal {
        public class State전투체크 : TriggerState {
            internal State전투체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateWait99(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait99 : TriggerState {
            internal StateWait99(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 118, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 128, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 138, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 218, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 228, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 238, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 318, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 328, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 338, visible: false, enabled: false, minimapVisible: false);
                context.SetPortal(portalId: 428, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StatePortalCreation(context);
                }

                if (context.GetUserValue(key: "SetLight") == 1) {
                    return new StatePortalCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalCreation : TriggerState {
            internal StatePortalCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 118, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 128, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 138, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 218, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 228, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 238, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 318, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 328, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 338, visible: true, enabled: true, minimapVisible: true);
                context.SetPortal(portalId: 428, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
