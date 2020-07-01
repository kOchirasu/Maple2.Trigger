namespace Maple2.Trigger._99999905 {
    public static class _move {
        public class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 102) == 10) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}