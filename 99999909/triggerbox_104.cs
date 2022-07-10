namespace Maple2.Trigger._99999909 {
    public static class _triggerbox_104 {
        public class State블록 : TriggerState {
            internal State블록(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{104})) {
                    return new State블록Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블록Creation : TriggerState {
            internal State블록Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3038, 3039, 3040, 3041, 3042, 3043, 3044, 3045, 3046}, visible: true, meshCount: 4, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
