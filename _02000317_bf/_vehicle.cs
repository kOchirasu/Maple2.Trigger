namespace Maple2.Trigger._02000317_bf {
    public static class _vehicle {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001047}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10001047}, arg2: 0)) {
                    context.State = new Statehide(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new[] {10001047}, arg2: 2);
            }
        }

        private class Statehide : TriggerState {
            internal Statehide(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}