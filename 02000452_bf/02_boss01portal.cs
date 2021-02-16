namespace Maple2.Trigger._02000452_bf {
    public static class _02_boss01portal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 30, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9900, arg2: new[] {901})) {
                    return new StateActionPortal01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActionPortal01 : TriggerState {
            internal StateActionPortal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 30, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}