namespace Maple2.Trigger._84000007_wd {
    public static class _09_fireworks {
        public class StateStaging : TriggerState {
            internal StateStaging(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Fireworks") == 1) {
                    context.State = new StateVolley_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Fireworks") == 2) {
                    context.State = new StateVolley_Ready2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVolley_Ready : TriggerState {
            internal StateVolley_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$84000007_WD__09_FIREWORKS__0$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateVolley_Fire(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVolley_Ready2 : TriggerState {
            internal StateVolley_Ready2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$84000007_WD__09_FIREWORKS__1$", arg3: 3000, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateVolley_Fire(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVolley_Fire : TriggerState {
            internal StateVolley_Fire(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) { }
            }

            public override void OnExit() { }
        }
    }
}