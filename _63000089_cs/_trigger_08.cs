namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_08 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {308}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {108})) {
                    return new StateSetup08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08 : TriggerState {
            internal StateSetup08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {308}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {108})) {
                    return new StateSetup08끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup08끝 : TriggerState {
            internal StateSetup08끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "408", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "408")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}