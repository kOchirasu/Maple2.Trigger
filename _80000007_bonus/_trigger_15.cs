namespace Maple2.Trigger._80000007_bonus {
    public static class _trigger_15 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {302})) {
                    context.State = new State막힘(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State막힘 : TriggerState {
            internal State막힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {410, 411, 412, 413, 414, 415, 416, 417, 418}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}