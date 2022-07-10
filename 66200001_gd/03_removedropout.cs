namespace Maple2.Trigger._66200001_gd {
    public static class _03_removedropout {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRemove : TriggerState {
            internal StateRemove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveToPortal(boxId: 9002, userTagId: 1, portalId: 21);
                context.MoveToPortal(boxId: 9002, userTagId: 2, portalId: 22);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateRemove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
