namespace Maple2.Trigger._02000331_bf {
    public static class _safeportal05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 52, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{99994})) {
                    return new StatePortalAction(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalAction : TriggerState {
            internal StatePortalAction(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 52, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
