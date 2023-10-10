namespace Maple2.Trigger._51000006_dg {
    public static class _fail {
        public class StateGameset : TriggerState {
            internal StateGameset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8011, enabled: false);
            }

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
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_PinkBeans_Arcade_Result_01");
                context.WriteLog(logName: "ThreeTwoOne_log", triggerId: 9001, @event: "char_event", arg5: "BlackbeanThreeTwoOnegameover");
                context.SetTimer(timerId: "10", seconds: 10, display: true);
                context.CameraSelectPath(pathIds: new []{8011, 8010}, returnView: false);
                context.ArcadeThreeTwoOneEndGame();
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
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
