namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {402}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {202})) {
                    return new StateSetup02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02 : TriggerState {
            internal StateSetup02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {402}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {202})) {
                    return new StateSetup02끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup02끝 : TriggerState {
            internal StateSetup02끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "502", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "502")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}