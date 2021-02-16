namespace Maple2.Trigger._64000001_gd {
    public static class _ringout {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 12, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new State링아웃(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State링아웃 : TriggerState {
            internal State링아웃(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.MoveUser(arg1: 64000001, arg2: 2, arg3: 105);
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}