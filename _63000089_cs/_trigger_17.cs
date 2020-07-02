namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_17 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {317}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {117})) {
                    return new StateSetup17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17 : TriggerState {
            internal StateSetup17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {317}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {117})) {
                    return new StateSetup17끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup17끝 : TriggerState {
            internal StateSetup17끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "417", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "417")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}