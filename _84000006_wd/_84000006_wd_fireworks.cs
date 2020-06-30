using System;

namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_fireworks {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateStaging(context);

        private class StateStaging : TriggerState {
            internal StateStaging(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Fireworks", value: 1)) {
                    context.State = new StateVolley(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVolley : TriggerState {
            internal StateVolley(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {3000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) { }
            }

            public override void OnExit() { }
        }
    }
}