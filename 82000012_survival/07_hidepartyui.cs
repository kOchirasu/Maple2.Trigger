namespace Maple2.Trigger._82000012_survival {
    public static class _07_hidepartyui {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "HidePartyUI", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateHidePartyUI(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateHidePartyUI : TriggerState {
            internal StateHidePartyUI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiNames: new []{"PartyDialog"}, visible: false);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
