namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_12 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new StateSetup12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12 : TriggerState {
            internal StateSetup12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {112})) {
                    return new StateSetup12끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup12끝 : TriggerState {
            internal StateSetup12끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "412", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "412")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}