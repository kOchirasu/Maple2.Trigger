namespace Maple2.Trigger._02000281_bf {
    public static class _move02 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(arg1: new[] {802}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {182})) {
                    return new StateSetup발동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup발동 : TriggerState {
            internal StateSetup발동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "30", arg2: 30, arg3: false);
                context.SetBreakable(arg1: new[] {802}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}