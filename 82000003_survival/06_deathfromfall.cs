namespace Maple2.Trigger._82000003_survival {
    public static class _06_deathfromfall {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateWaitSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitSomeoneFall : TriggerState {
            internal StateWaitSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateKillSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateKillSomeoneFall : TriggerState {
            internal StateKillSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9100}, skillId: 70001061, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateKillSomeoneFall(context);
                }

                if (!context.UserDetected(boxIds: new []{9100})) {
                    return new StateWaitSomeoneFall(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
