using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010003_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101});
                context.SetActor(triggerId: 2001, visible: false, initialSequence: "Sit_Down_A");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10002802}, questStates: new byte[]{1})) {
                    return new StateEvent_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10002836}, questStates: new byte[]{1})) {
                    return new StateB_Event_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateB_Event_01 : TriggerState {
            internal StateB_Event_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 2001, visible: true, initialSequence: "Sit_Down_A");
                context.CameraSelect(triggerId: 8001, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{103, 104, 105, 106});
                context.SetTimer(timerId: "4", seconds: 4);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_1004");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_1005");
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_1006");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_02(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_02 : TriggerState {
            internal StateB_Event_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__13$", arg4: 5);
                context.SetSkip(state: new StateB_Event_03_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_03(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_03 : TriggerState {
            internal StateB_Event_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001292, script: "$52010003_QD__MAIN__14$", arg4: 5);
                context.SetSkip(state: new StateB_Event_04_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_04(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_04 : TriggerState {
            internal StateB_Event_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__15$", arg4: 5);
                context.SetSkip(state: new StateB_Event_05_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_05(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_05 : TriggerState {
            internal StateB_Event_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001218, script: "$52010003_QD__MAIN__16$", arg4: 5);
                context.SetSkip(state: new StateB_Event_06_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_06(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_06 : TriggerState {
            internal StateB_Event_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001217, script: "$52010003_QD__MAIN__17$", arg4: 5);
                context.SetSkip(state: new StateB_Event_07_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateB_Event_07(context);
            }

            public override void OnExit() { }
        }

        private class StateB_Event_07 : TriggerState {
            internal StateB_Event_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__18$", arg4: 5);
                context.SetSkip(state: new StateB_Event_08_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new StateB_Event_08_IdLE(context);
                }

                return null;
            }

            public override void OnExit() {
                context.RemoveCinematicTalk();
                context.CameraSelect(triggerId: 8001, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "Hope_Lumieragon");
            }
        }

        private class StateB_Event_08_IdLE : TriggerState {
            internal StateB_Event_08_IdLE(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 8001, enabled: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__0$", arg4: 4);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1002");
                context.SetSkip(state: new StateEvent_02_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_02(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_02 : TriggerState {
            internal StateEvent_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__1$", arg4: 5);
                context.SetSkip(state: new StateEvent_03_IdLE(context));
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_03(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_03 : TriggerState {
            internal StateEvent_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__2$", arg4: 4);
                context.SetSkip(state: new StateEvent_04_IdLE(context));
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_04(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_04 : TriggerState {
            internal StateEvent_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__3$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_05_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_05(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_05 : TriggerState {
            internal StateEvent_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__4$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_06_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_06(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_06 : TriggerState {
            internal StateEvent_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__5$", arg4: 5);
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetSkip(state: new StateEvent_07_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_07(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_07 : TriggerState {
            internal StateEvent_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__6$", arg4: 4);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateEvent_08_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_08(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_08 : TriggerState {
            internal StateEvent_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__7$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_09_IdLE(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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

            public override TriggerState? Execute() {
                return new StateEvent_09(context);
            }

            public override void OnExit() { }
        }

        private class StateEvent_09 : TriggerState {
            internal StateEvent_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__8$", arg4: 3);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateEvent_10(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
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
                context.SetConversation(type: 2, spawnId: 11000075, script: "$52010003_QD__MAIN__9$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StatePlayMovie_01(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
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
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: "DestinyofMika.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StatePlayMovie_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie_02 : TriggerState {
            internal StatePlayMovie_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "45", seconds: 4);
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__10$", arg4: 4);
                context.SetSkip(state: new StateEvent_12(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "45")) {
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
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__11$", arg4: 3);
                context.SetTimer(timerId: "3", seconds: 3);
                context.SetSkip(state: new StateEvent_13(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new StateEvent_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_13 : TriggerState {
            internal StateEvent_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001285, script: "$52010003_QD__MAIN__12$", arg4: 4);
                context.SetTimer(timerId: "4", seconds: 4);
                context.SetSkip(state: new StateEvent_14(context));
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateEvent_14(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelect(triggerId: 8001, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
            }
        }

        private class StateEvent_14 : TriggerState {
            internal StateEvent_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "MikaDestiny");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_1003");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{102})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
