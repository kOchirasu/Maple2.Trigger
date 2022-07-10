namespace Maple2.Trigger._51000003_dg {
    public static class _fail {
        public class StateGameset : TriggerState {
            internal StateGameset(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Fail") == 1) {
                    return new StateFail_condition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail_condition : TriggerState {
            internal StateFail_condition(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 799) == 1) {
                    return new StateFail(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateFail(context);
                }

                if (!context.UserDetected(boxIds: new []{701})) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_Ending_Popup_01");
                context.SetTimer(timerId: "10", seconds: 10, display: true);
                context.CameraSelectPath(pathIds: new []{8800}, returnView: false);
                context.ArcadeBoomBoomOceanEndGame();
                context.SetUserValue(triggerId: 991104, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991105, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991106, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991107, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991108, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991111, key: "Round_01", value: 0);
                context.SetUserValue(triggerId: 991120, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991121, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991122, key: "Reset", value: 1);
                context.SetUserValue(triggerId: 991123, key: "Reset", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 0, portalId: 0, boxId: 705);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
