namespace Maple2.Trigger._02000367_bf {
    public static class _portal_12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 812, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000994}, arg2: 0)) {
                    return new StatePortalEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalEnable : TriggerState {
            internal StatePortalEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 812, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(arg1: new[] {10000994}, arg2: 1);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}