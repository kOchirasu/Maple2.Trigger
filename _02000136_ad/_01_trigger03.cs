namespace Maple2.Trigger._02000136_ad {
    public static class _01_trigger03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {804}, arg2: false);
                context.SetInteractObject(arg1: new[] {10000068}, arg2: 1);
                context.SetMesh(arg1: new[] {15}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000068}, arg2: 0)) {
                    return new StateSetupAppear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetupAppear : TriggerState {
            internal StateSetupAppear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {15}, arg2: true);
                context.SetEffect(arg1: new[] {804}, arg2: true);
                context.SetTimer(arg1: "2", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}