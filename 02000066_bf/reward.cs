namespace Maple2.Trigger._02000066_bf {
    public static class _reward {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000011, 11000012}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    // return new StateCreation조건(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}