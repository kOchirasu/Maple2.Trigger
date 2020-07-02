namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_16 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {316}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {116})) {
                    return new StateSetup16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16 : TriggerState {
            internal StateSetup16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {316}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {116})) {
                    return new StateSetup16끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup16끝 : TriggerState {
            internal StateSetup16끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "416", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "416")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}