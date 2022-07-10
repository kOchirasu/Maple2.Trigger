namespace Maple2.Trigger._80000007_bonus {
    public static class _trigger_14 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{303})) {
                    return new State막힘(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State막힘 : TriggerState {
            internal State막힘(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{401, 402, 403, 404, 405, 406, 407, 408, 409}, visible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
