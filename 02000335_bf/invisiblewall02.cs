namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 704) == 1) {
                    return new State벽면처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{7021, 7022, 7023, 7024, 7025, 7026, 7027, 7028, 7029, 7030, 7031, 7032}, visible: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
