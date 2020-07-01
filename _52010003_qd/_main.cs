namespace Maple2.Trigger._52010003_qd {
    public static class _main {
        public class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.SetActor(arg1: 2001, arg2: false, arg3: "Sit_Down_A");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002802}, arg3: new byte[] {1})) {
                    return new StateEvent_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {10002836}, arg3: new byte[] {1})) {
                    return new StateB_Event_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB_Event_01 : TriggerState {
            internal StateB_Event_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(arg1: 2001, arg2: true, arg3: "Sit_Down_A");
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.DestroyMonster(arg1: new[] {101});
                context.CreateMonster(arg1: new[] {103, 104, 105, 106});
                context.SetTimer(arg1: "4", arg2: 4);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_1004");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_1005");
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_1006");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateB_Event_02_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_02_IdLE : TriggerState {
            internal StateB_Event_02_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_02(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_02 : TriggerState {
            internal StateB_Event_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__13$", arg4: 5);
                context.SetSkip(arg1: "B_Event_03_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_03_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_03_IdLE : TriggerState {
            internal StateB_Event_03_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_03(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_03 : TriggerState {
            internal StateB_Event_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001292, arg3: "$52010003_QD__MAIN__14$", arg4: 5);
                context.SetSkip(arg1: "B_Event_04_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_04_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_04_IdLE : TriggerState {
            internal StateB_Event_04_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_04(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_04 : TriggerState {
            internal StateB_Event_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__15$", arg4: 5);
                context.SetSkip(arg1: "B_Event_05_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_05_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_05_IdLE : TriggerState {
            internal StateB_Event_05_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_05(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_05 : TriggerState {
            internal StateB_Event_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001218, arg3: "$52010003_QD__MAIN__16$", arg4: 5);
                context.SetSkip(arg1: "B_Event_06_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_06_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_06_IdLE : TriggerState {
            internal StateB_Event_06_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_06(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_06 : TriggerState {
            internal StateB_Event_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001217, arg3: "$52010003_QD__MAIN__17$", arg4: 5);
                context.SetSkip(arg1: "B_Event_07_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_07_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateB_Event_07_IdLE : TriggerState {
            internal StateB_Event_07_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateB_Event_07(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_07 : TriggerState {
            internal StateB_Event_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__18$", arg4: 5);
                context.SetSkip(arg1: "B_Event_08_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateB_Event_08_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "Hope_Lumieragon");
            }
        }

        private class StateB_Event_08_IdLE : TriggerState {
            internal StateB_Event_08_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 8001, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {102});
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__0$", arg4: 4);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1002");
                context.SetSkip(arg1: "Event_02_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_02_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_02_IdLE : TriggerState {
            internal StateEvent_02_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_02(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__1$", arg4: 5);
                context.SetSkip(arg1: "Event_03_IdLE");
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEvent_03_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_03_IdLE : TriggerState {
            internal StateEvent_03_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_03(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__2$", arg4: 4);
                context.SetSkip(arg1: "Event_04_IdLE");
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_04_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_04_IdLE : TriggerState {
            internal StateEvent_04_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_04(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__3$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_05_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_05_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_05_IdLE : TriggerState {
            internal StateEvent_05_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_05(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__4$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_06_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_06_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_06_IdLE : TriggerState {
            internal StateEvent_06_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_06(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__5$", arg4: 5);
                context.SetTimer(arg1: "5", arg2: 5);
                context.SetSkip(arg1: "Event_07_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    return new StateEvent_07_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_07_IdLE : TriggerState {
            internal StateEvent_07_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_07(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__6$", arg4: 4);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "Event_08_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_08_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_08_IdLE : TriggerState {
            internal StateEvent_08_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_08(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_08 : TriggerState {
            internal StateEvent_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__7$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_09_IdLE");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_09_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_09_IdLE : TriggerState {
            internal StateEvent_09_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return new StateEvent_09(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_09 : TriggerState {
            internal StateEvent_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__8$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "Event_10");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_10(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_10 : TriggerState {
            internal StateEvent_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000075, arg3: "$52010003_QD__MAIN__9$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_11");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StatePlayMovie_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StatePlayMovie_01 : TriggerState {
            internal StatePlayMovie_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "DestinyofMika.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new StatePlayMovie_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie_02 : TriggerState {
            internal StatePlayMovie_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "45", arg2: 4);
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__10$", arg4: 4);
                context.SetSkip(arg1: "Event_12");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "45")) {
                    return new StateEvent_12(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
            }
        }

        private class StateEvent_12 : TriggerState {
            internal StateEvent_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__11$", arg4: 3);
                context.SetTimer(arg1: "3", arg2: 3);
                context.SetSkip(arg1: "Event_13");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateEvent_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_13 : TriggerState {
            internal StateEvent_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001285, arg3: "$52010003_QD__MAIN__12$", arg4: 4);
                context.SetTimer(arg1: "4", arg2: 4);
                context.SetSkip(arg1: "Event_14");
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    return new StateEvent_14(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(arg1: 8001, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
            }
        }

        private class StateEvent_14 : TriggerState {
            internal StateEvent_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "MikaDestiny");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_1003");
            }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {102})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {102});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}