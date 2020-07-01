namespace Maple2.Trigger._02000245_bf {
    public static class _trigger_01_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000302}, arg2: 1);
                context.SetMesh(arg1: new[] {701, 702}, arg2: true);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000302}, arg2: 0)) {
                    context.State = new State개봉(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State개봉 : TriggerState {
            internal State개봉(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {701, 702}, arg2: false);
                context.SetTimer(arg1: "1", arg2: 180);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}