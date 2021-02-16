namespace Maple2.Trigger._02000452_bf {
    public static class _03_boss03portal {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 40, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 9900, arg2: new[] {903})) {
                    return new StateActionPortal01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateActionPortal01 : TriggerState {
            internal StateActionPortal01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 40, visible: false, enabled: true, minimapVisible: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}