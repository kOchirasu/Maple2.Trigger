namespace Maple2.Trigger._84000006_wd {
    public static class _84000006_wd_fireworks {
        public class StateStaging : TriggerState {
            internal StateStaging(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Fireworks") == 1) {
                    return new StateVolley(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateVolley : TriggerState {
            internal StateVolley(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{3000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
