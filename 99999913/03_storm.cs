using Maple2.Trigger.Enum;

namespace Maple2.Trigger._99999913 {
    public static class _03_storm {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SurvivalContents);
            }

            public override TriggerState? Execute() {
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
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "StormData", args: "1,0");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_0");
            }

            public override TriggerState? Execute() {
                return new StateStep01(context);
            }

            public override void OnExit() { }
        }

        private class StateStep01 : TriggerState {
            internal StateStep01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_1_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_1_end");
            }
        }

        private class StateStep02 : TriggerState {
            internal StateStep02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "2");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_2_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_2_end");
            }
        }

        private class StateStep03 : TriggerState {
            internal StateStep03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "3");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_3_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep04(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_3_end");
            }
        }

        private class StateStep04 : TriggerState {
            internal StateStep04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "4");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_4_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep05(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_4_end");
            }
        }

        private class StateStep05 : TriggerState {
            internal StateStep05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "5");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_5_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep06(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_5_end");
            }
        }

        private class StateStep06 : TriggerState {
            internal StateStep06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "6");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_6_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateStep07(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_6_end");
            }
        }

        private class StateStep07 : TriggerState {
            internal StateStep07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "EnterStep", args: "7");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_7_start");
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SurvivalContents, condition: "TimeOver")) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() {
                context.WidgetAction(type: WidgetType.SurvivalContents, name: "ExitStep", args: "1");
                context.WriteLog(logName: "Survival", @event: "Storm_Step_7_end");
            }
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
