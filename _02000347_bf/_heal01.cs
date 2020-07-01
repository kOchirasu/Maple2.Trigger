namespace Maple2.Trigger._02000347_bf {
    public static class _heal01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000803}, arg2: 0);
                context.SetSkill(arg1: new[] {701}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}