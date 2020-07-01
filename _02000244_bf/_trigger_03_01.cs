namespace Maple2.Trigger._02000244_bf {
    public static class _trigger_03_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {705, 706}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}