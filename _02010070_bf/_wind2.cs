namespace Maple2.Trigger._02010070_bf {
    public static class _wind2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "wind02", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {999994})) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "wind02") == 1) {
                    context.State = new StateChange(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChange : TriggerState {
            internal StateChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {34, 35, 36, 53, 46, 59, 44, 45}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}