namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_09 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {309}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {109})) {
                    return new StateSetup09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup09 : TriggerState {
            internal StateSetup09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {309}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {109})) {
                    return new StateSetup09끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup09끝 : TriggerState {
            internal StateSetup09끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "409", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "409")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}