namespace Maple2.Trigger._99999909 {
    public static class _triggerbox_101 {
        public class State블록 : TriggerState {
            internal State블록(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    return new State블록Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블록Creation : TriggerState {
            internal State블록Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(arg1: new[] {3002, 3003, 3004, 3005, 3006, 3007, 3008, 3009}, arg2: true, arg3: 4, arg4: 0, arg5: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}