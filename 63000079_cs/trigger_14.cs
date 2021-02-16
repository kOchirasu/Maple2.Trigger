namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_14 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    return new StateSetup14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14 : TriggerState {
            internal StateSetup14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {114})) {
                    return new StateSetup14끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup14끝 : TriggerState {
            internal StateSetup14끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "414", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "414")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}