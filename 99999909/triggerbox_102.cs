namespace Maple2.Trigger._99999909 {
    public static class _triggerbox_102 {
        public class State블록 : TriggerState {
            internal State블록(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{102})) {
                    return new State블록Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State블록Creation : TriggerState {
            internal State블록Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetRandomMesh(triggerIds: new []{3011, 3012, 3013, 3014, 3015, 3016, 3017, 3018, 3019, 3020, 3021, 3022, 3023, 3024, 3025, 3026, 3027, 3028}, visible: true, meshCount: 6, arg4: 0, delay: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
