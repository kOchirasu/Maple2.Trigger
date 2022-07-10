namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall06 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    return new State벽면처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
