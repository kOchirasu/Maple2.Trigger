namespace Maple2.Trigger._02000331_bf {
    public static class _safeportal04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {99910})) {
                    return new StatePortalAction(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalAction : TriggerState {
            internal StatePortalAction(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 50, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}