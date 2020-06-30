using System;

namespace Maple2.Trigger._82000012_survival {
    public static class _06_deathfromfall {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
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
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StateKillSomeoneFall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKillSomeoneFall : TriggerState {
            internal StateKillSomeoneFall(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9100}, arg2: 70001061, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateKillSomeoneFall(context);
                    return;
                }

                if (!context.UserDetected(arg1: "9100")) {
                    context.State = new StateWaitSomeoneFall(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}