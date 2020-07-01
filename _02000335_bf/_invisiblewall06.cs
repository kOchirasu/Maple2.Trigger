namespace Maple2.Trigger._02000335_bf {
    public static class _invisiblewall06 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 708) == 1) {
                    context.State = new State벽면처리(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State벽면처리 : TriggerState {
            internal State벽면처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}