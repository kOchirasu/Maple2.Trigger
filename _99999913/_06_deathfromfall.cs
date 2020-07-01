namespace Maple2.Trigger._99999913 {
    public static class _06_deathfromfall {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateWaitSomeoneFall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitSomeoneFall : TriggerState {
            internal StateWaitSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    context.State = new StateKillSomeoneFall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKillSomeoneFall : TriggerState {
            internal StateKillSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9100}, arg2: 70001061, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9100})) {
                    context.State = new StateWaitSomeoneFall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}