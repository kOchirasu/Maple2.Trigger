namespace Maple2.Trigger._52000014_qd {
    public static class _move_6300 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {6300}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9630})) {
                    return new State침몰01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State침몰01 : TriggerState {
            internal State침몰01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 17);
                context.SetBreakable(arg1: new[] {6300}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}