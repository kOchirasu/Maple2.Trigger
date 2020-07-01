using System;

namespace Maple2.Trigger._63000029_cs {
    public static class _safety03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "SafetyStart", value: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "SafetyStart", value: 1)) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9200})) {
                    context.State = new StatePCTeleport01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000029, arg2: 12, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReset01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReset01 : TriggerState {
            internal StateReset01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9200})) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}