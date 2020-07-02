namespace Maple2.Trigger._63000001_cs {
    public static class _trigger_07 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {107})) {
                    return new StateSetup07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07 : TriggerState {
            internal StateSetup07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {307}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {107})) {
                    return new StateSetup07끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup07끝 : TriggerState {
            internal StateSetup07끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "407", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "407")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}