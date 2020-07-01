namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall05 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 707) == 1) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {7061, 7062, 7063, 7064, 7065, 7066, 7067, 7068, 7069, 7070},
                    arg2: false, arg4: 0, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}