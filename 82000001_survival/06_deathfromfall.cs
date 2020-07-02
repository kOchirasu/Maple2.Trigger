namespace Maple2.Trigger._82000001_survival {
    public static class _06_deathfromfall {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateWaitSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitSomeoneFall : TriggerState {
            internal StateWaitSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    return new StateKillSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKillSomeoneFall : TriggerState {
            internal StateKillSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9100}, arg2: 70001061, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateKillSomeoneFall(context);
                }

                if (!context.UserDetected(arg1: new[] {9100})) {
                    return new StateWaitSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}