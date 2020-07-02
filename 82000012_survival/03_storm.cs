namespace Maple2.Trigger._82000012_survival {
    public static class _03_storm {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SurvivalContents");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StormStart") == 1) {
                    return new StateSetStorm(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetStorm : TriggerState {
            internal StateSetStorm(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "StormData", arg3: "1,0");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_0");
            }

            public override TriggerState Execute() {
                return new StateStep01(context);
            }

            public override void OnExit() { }
        }

        private class StateStep01 : TriggerState {
            internal StateStep01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_1_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_1_end");
            }
        }

        private class StateStep02 : TriggerState {
            internal StateStep02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "2");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_2_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_2_end");
            }
        }

        private class StateStep03 : TriggerState {
            internal StateStep03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "3");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_3_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_3_end");
            }
        }

        private class StateStep04 : TriggerState {
            internal StateStep04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "4");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_4_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_4_end");
            }
        }

        private class StateStep05 : TriggerState {
            internal StateStep05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "5");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_5_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_5_end");
            }
        }

        private class StateStep06 : TriggerState {
            internal StateStep06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "6");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_6_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep07(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_6_end");
            }
        }

        private class StateStep07 : TriggerState {
            internal StateStep07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "7");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_7_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateStep08(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_7_end");
            }
        }

        private class StateStep08 : TriggerState {
            internal StateStep08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "EnterStep", arg3: "8");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_8_start");
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SurvivalContents", arg2: "TimeOver")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(arg1: "SurvivalContents", arg2: "ExitStep", arg3: "1");
                context.WriteLog(arg1: "Survival", arg3: "Storm_Step_8_end");
            }
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