namespace Maple2.Trigger._51000004_dg {
    public static class _fail {
        public class StateGameset : TriggerState {
            internal StateGameset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8011, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new StateFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFail : TriggerState {
            internal StateFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_PinkBeans_Arcade_Result_01");
                context.WriteLog(arg1: "PinkBeanThreeTwoOne_log", arg2: 9001, arg3: "char_event", arg5: "gameover");
                context.SetTimer(id: "10", arg2: 10, arg4: true);
                context.CameraSelectPath(pathIds: new[] {8011, 8010}, arg2: false);
                context.ArcadeThreeTwoOneEndGame();
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}