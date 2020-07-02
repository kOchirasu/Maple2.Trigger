namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {310}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {110})) {
                    return new StateSetup10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10 : TriggerState {
            internal StateSetup10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {310}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {110})) {
                    return new StateSetup10끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup10끝 : TriggerState {
            internal StateSetup10끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "410", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "410")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}