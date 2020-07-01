namespace Maple2.Trigger._99999907 {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000019}, arg2: 1);
                context.SetInteractObject(arg1: new[] {12000020}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000019}, arg2: 0)) {
                    context.State = new State리셋(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {12000020}, arg2: 0)) {
                    context.State = new State리셋(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리셋 : TriggerState {
            internal State리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}