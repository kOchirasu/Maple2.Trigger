using System.Numerics;

namespace Maple2.Trigger._52000138_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7101, enabled: true);
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4004, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4006, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4007, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4008, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4009, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4010, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 4011, visible: true, initialSequence: "Closed");
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1002, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1003, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1004, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1005, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1006, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1007, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1008, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1009, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1010, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1011, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1012, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1013, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1014, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1015, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1016, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1017, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1018, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1019, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1020, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1021, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1022, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1023, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1024, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1025, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1026, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1027, visible: true, initialSequence: "sf_quest_light_A01_Off");
                context.SetActor(triggerId: 1028, visible: true, initialSequence: "sf_quest_light_A01_Off");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG\weather\Eff_monochrome_03.xml");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/Sound/Eff_ Object_Train_alert.xml");
                context.SetAmbientLight(color: default);
                context.SetAmbientLight(color: new Vector3(1f, 1f, 1f));
                context.AddBuff(boxIds: new []{701}, skillId: 99910230, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{701}, skillId: 99910230, level: 1, arg4: false, arg5: false);
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAct1_wave1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave1 : TriggerState {
            internal StateAct1_wave1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$52000138_QD__MAIN__0$", duration: 3000, boxId: 0);
                context.SetActor(triggerId: 1001, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1002, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1003, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1004, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1009, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1010, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1025, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1026, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1027, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1028, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetConversation(type: 1, spawnId: 101, script: "$52000138_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.SetSound(triggerId: 10000, enabled: true);
                context.SetSound(triggerId: 7002, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct1_wave2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave2 : TriggerState {
            internal StateAct1_wave2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct1_wave2_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave2_move : TriggerState {
            internal StateAct1_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4001, visible: true, initialSequence: "Opened");
                context.SetConversation(type: 1, spawnId: 102, script: "$52000138_QD__MAIN__2$", arg4: 3, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAct1_wave2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave2_1 : TriggerState {
            internal StateAct1_wave2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct1_wave2_move_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave2_move_1 : TriggerState {
            internal StateAct1_wave2_move_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4002, visible: true, initialSequence: "Opened");
                context.SetConversation(type: 1, spawnId: 104, script: "$52000138_QD__MAIN__3$", arg4: 3, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAct1_wave3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave3 : TriggerState {
            internal StateAct1_wave3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103, 105});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAct1_wave3_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct1_wave3_move : TriggerState {
            internal StateAct1_wave3_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 105, script: "$52000138_QD__MAIN__4$", arg4: 3, arg5: 3);
                context.SetActor(triggerId: 4003, visible: true, initialSequence: "Opened");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateReady_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_1 : TriggerState {
            internal StateReady_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{110, 111});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAct2_wave1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave1 : TriggerState {
            internal StateAct2_wave1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1005, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1006, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1007, visible: true, initialSequence: "sf_quest_light_A01_Of");
                context.SetActor(triggerId: 1008, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1011, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1012, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1011, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1012, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1023, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1024, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetConversation(type: 1, spawnId: 110, script: "$52000138_QD__MAIN__5$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 111, script: "$52000138_QD__MAIN__6$", arg4: 3, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct2_wave2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave2 : TriggerState {
            internal StateAct2_wave2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4004, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{106, 107});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct2_wave2_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave2_move : TriggerState {
            internal StateAct2_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 106, script: "$52000138_QD__MAIN__7$", arg4: 3, arg5: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAct2_wave3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave3 : TriggerState {
            internal StateAct2_wave3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4005, visible: true, initialSequence: "Opened");
                context.CreateMonster(spawnIds: new []{108, 109});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAct2_wave3_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave3_move : TriggerState {
            internal StateAct2_wave3_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 4006, visible: true, initialSequence: "Opened");
                context.SetConversation(type: 1, spawnId: 109, script: "$52000138_QD__MAIN__8$", arg4: 3, arg5: 3);
                context.CreateMonster(spawnIds: new []{112});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateAct2_wave3_move_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct2_wave3_move_1 : TriggerState {
            internal StateAct2_wave3_move_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 112, script: "$52000138_QD__MAIN__9$", arg4: 3, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703})) {
                    return new StateReady_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_2 : TriggerState {
            internal StateReady_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{113});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct3_wave1_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct3_wave1_move : TriggerState {
            internal StateAct3_wave1_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 1013, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1014, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1015, visible: true, initialSequence: "sf_quest_light_A01_Of");
                context.SetActor(triggerId: 1016, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1017, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1018, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1019, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1020, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1021, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetActor(triggerId: 1022, visible: true, initialSequence: "sf_quest_light_A01_On");
                context.SetConversation(type: 1, spawnId: 113, script: "$52000138_QD__MAIN__10$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1)) {
                    return new StateAct3_wave2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct3_wave2_1 : TriggerState {
            internal StateAct3_wave2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{114, 115, 120, 121});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateAct3_wave2_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct3_wave2_2 : TriggerState {
            internal StateAct3_wave2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 114, script: "$52000138_QD__MAIN__11$", arg4: 2, arg5: 2);
                context.CreateMonster(spawnIds: new []{116, 117, 118, 119});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateAct3_wave2_move(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAct3_wave2_move : TriggerState {
            internal StateAct3_wave2_move(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 116, script: "$52000138_QD__MAIN__12$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123})) {
                    return new StateEscape(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEscape : TriggerState {
            internal StateEscape(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{122});
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetSceneSkip(state: new StateEndready(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePlot(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePlot : TriggerState {
            internal StatePlot(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 7102, enabled: true);
                context.SetConversation(type: 1, spawnId: 122, script: "$52000138_QD__MAIN__13$", arg4: 3, arg5: 4);
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateScheme1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScheme1 : TriggerState {
            internal StateScheme1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 122, script: "$52000138_QD__MAIN__14$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScheme2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScheme2 : TriggerState {
            internal StateScheme2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 122, script: "$52000138_QD__MAIN__15$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScheme3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScheme3 : TriggerState {
            internal StateScheme3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 122, script: "$52000138_QD__MAIN__16$", arg4: 5, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateScheme4(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }
        }

        private class StateScheme4 : TriggerState {
            internal StateScheme4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 122, sequenceName: "Talk_A", duration: 1500f);
                context.SetConversation(type: 1, spawnId: 122, script: "$52000138_QD__MAIN__17$", arg4: 5, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEndready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEndready : TriggerState {
            internal StateEndready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "windead");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "windead");
                context.MoveUser(mapId: 02000153, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
