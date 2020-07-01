namespace Maple2.Trigger._02000163_bf {
    public static class _04_doll_trigger {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {403}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000104}, arg2: 0)) {
                    context.State = new State로봇사라짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State로봇사라짐 : TriggerState {
            internal State로봇사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {403}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000104}, arg2: 1)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}