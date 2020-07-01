namespace Maple2.Trigger._02000252_bf {
    public static class _bigdoor_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {161, 162, 163, 164}, arg2: true);
                context.SetInteractObject(arg1: new[] {10000403}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000403}, arg2: 0)) {
                    context.State = new State열기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State열기 : TriggerState {
            internal State열기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {161, 162, 163, 164}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}