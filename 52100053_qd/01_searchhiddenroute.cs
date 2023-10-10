namespace Maple2.Trigger._52100053_qd {
    public static class _01_searchhiddenroute {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: false);
                context.SetUserValue(key: "PortalOn", value: 0);
                context.SetPortal(portalId: 10, visible: false, enabled: false, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateLoadingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelay : TriggerState {
            internal StateLoadingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePickRandomRoute(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePickRandomRoute : TriggerState {
            internal StatePickRandomRoute(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityId: 20039701, textId: 20039701, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 20)) {
                    return new StateBehindFireplace(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateBehindBookcase(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateFindKeyFromFabricbox(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateFindKeyFromCandle(context);
                }

                if (context.RandomCondition(rate: 20)) {
                    return new StateFindKeyFromDocument(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBehindBookcase : TriggerState {
            internal StateBehindBookcase(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateBehindFireplace : TriggerState {
            internal StateBehindFireplace(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 1);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindKeyFromFabricbox : TriggerState {
            internal StateFindKeyFromFabricbox(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 1);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindKeyFromCandle : TriggerState {
            internal StateFindKeyFromCandle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 1);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFindKeyFromDocument : TriggerState {
            internal StateFindKeyFromDocument(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3100, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3200, key: "HiddenRouteOpen", value: 2);
                context.SetUserValue(triggerId: 3300, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3400, key: "FindKey", value: 2);
                context.SetUserValue(triggerId: 3500, key: "FindKey", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PortalOn") == 1) {
                    return new StatePortalOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePortalOn : TriggerState {
            internal StatePortalOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.SetPortal(portalId: 10, visible: true, enabled: true, minimapVisible: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
