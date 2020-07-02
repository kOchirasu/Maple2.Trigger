namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall05 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    return new State벽면처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7061, 7062, 7063, 7064, 7065, 7066, 7067, 7068, 7069, 7070}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}