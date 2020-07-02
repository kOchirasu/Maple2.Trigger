namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall04 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 706) == 1) {
                    return new State벽면처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7051, 7052, 7053, 7054, 7055, 7056, 7057, 7058, 7059, 7060}, arg2: false, arg4: 0, arg5: 10f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}