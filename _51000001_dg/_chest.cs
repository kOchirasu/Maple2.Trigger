namespace Maple2.Trigger._51000001_dg {
    public static class _chest {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {11000013, 11000014, 11000015, 11000016, 11000017}, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}