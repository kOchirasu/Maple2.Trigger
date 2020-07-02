namespace Maple2.Trigger._82000006_survival {
    public static class _07_hidepartyui {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "HidePartyUI", value: 0);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    return new StateHidePartyUI(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidePartyUI : TriggerState {
            internal StateHidePartyUI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiName: "PartyDialog", visible: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateHidePartyUI(context);
                }

                if (context.GetUserValue(key: "HidePartyUI") == 1) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}