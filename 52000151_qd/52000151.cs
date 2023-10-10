using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000151_qd {
    public static class _52000151 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001642}, questStates: new byte[]{1})) {
                    return new State생명의틈으로01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{3})) {
                    return new State생틈퀘수령전Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{2})) {
                    return new State생틈퀘수령전Wait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{1})) {
                    return new State파토스SpawnCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_2 : TriggerState {
            internal StateWait_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10010})) {
                    return new State파토스SpawnCinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생틈퀘수령전Wait : TriggerState {
            internal State생틈퀘수령전Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202, 200, 201}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Event_01_A", duration: 999999f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001642}, questStates: new byte[]{1})) {
                    return new State생명의틈으로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic01 : TriggerState {
            internal State파토스SpawnCinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{202, 200, 201, 203}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Stun_A", duration: 999999f);
                context.FaceEmotion(spawnId: 201, emotionName: "Concerned");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State파토스SpawnCinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic02 : TriggerState {
            internal State파토스SpawnCinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "exit");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State파토스SpawnCinematic02_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic02_B : TriggerState {
            internal State파토스SpawnCinematic02_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
                context.SetEffect(triggerIds: new []{1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1200, 1201, 1202, 1203, 1204, 1205, 1206}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1500, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1600, 1601, 1602, 1603, 1604, 1605, 1606, 1607, 1608}, visible: true, arg3: 0, arg4: 100);
                context.SetEffect(triggerIds: new []{1700, 1701, 1702, 1703, 1704}, visible: true, arg3: 0, arg4: 100);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic03 : TriggerState {
            internal State파토스SpawnCinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", script: "$52000151_QD__52000151__0$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7000, 7001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic04 : TriggerState {
            internal State파토스SpawnCinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "0", script: "$52000151_QD__52000151__1$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7002, 7003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic05 : TriggerState {
            internal State파토스SpawnCinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__2$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7004, 7005}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic06 : TriggerState {
            internal State파토스SpawnCinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__3$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7006, 7007}, returnView: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_patos_come");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic08 : TriggerState {
            internal State파토스SpawnCinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__4$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7008, 7009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic09 : TriggerState {
            internal State파토스SpawnCinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "0", script: "$52000151_QD__52000151__5$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7010, 7011}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic10 : TriggerState {
            internal State파토스SpawnCinematic10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", script: "$52000151_QD__52000151__6$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7000, 7001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic12 : TriggerState {
            internal State파토스SpawnCinematic12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003439, illustId: "0", script: "$52000151_QD__52000151__7$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7012, 7013, 7014, 7015}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic13 : TriggerState {
            internal State파토스SpawnCinematic13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__8$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7016, 7017}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State파토스SpawnCinematic14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic14 : TriggerState {
            internal State파토스SpawnCinematic14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__9$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State파토스SpawnCinematic15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic15 : TriggerState {
            internal State파토스SpawnCinematic15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__10$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7018, 7019}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State파토스SpawnCinematic16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic16 : TriggerState {
            internal State파토스SpawnCinematic16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__11$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State파토스SpawnCinematic17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic17 : TriggerState {
            internal State파토스SpawnCinematic17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__12$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State파토스SpawnCinematic18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic18 : TriggerState {
            internal State파토스SpawnCinematic18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__13$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7020, 7021}, returnView: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_patos_exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State파토스SpawnCinematic19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic19 : TriggerState {
            internal State파토스SpawnCinematic19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__14$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7022, 7023}, returnView: false);
                context.MoveNpc(spawnId: 203, patrolName: "MS2PatrolData_patos_turn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic20 : TriggerState {
            internal State파토스SpawnCinematic20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003441, illustId: "0", script: "$52000151_QD__52000151__15$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{7024, 7025}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic21 : TriggerState {
            internal State파토스SpawnCinematic21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State파토스SpawnCinematic22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic22 : TriggerState {
            internal State파토스SpawnCinematic22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_anosTurn");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State파토스SpawnCinematic23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State파토스SpawnCinematic23 : TriggerState {
            internal State파토스SpawnCinematic23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetAchievement(triggerId: 10010, type: "trigger", code: "ProtectFinish");
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Event_01_A", duration: 999999f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(triggerId: 9000, enabled: true);
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001642}, questStates: new byte[]{1})) {
                    return new State생명의틈으로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Event_01_A", duration: 999999f);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(triggerId: 9000, enabled: true);
                context.DestroyMonster(spawnIds: new []{203});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSkip_1_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1_1 : TriggerState {
            internal StateSkip_1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAchievement(triggerId: 10010, type: "trigger", code: "ProtectFinish");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001642}, questStates: new byte[]{1})) {
                    return new State생명의틈으로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생명의틈으로01 : TriggerState {
            internal State생명의틈으로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000172, portalId: 21002);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
