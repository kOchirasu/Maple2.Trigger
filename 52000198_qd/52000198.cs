using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000198_qd {
    public static class _52000198 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5002, visible: false, enabled: false);
                context.SetPortal(portalId: 2, visible: false, enabled: false);
                context.SetPortal(portalId: 4, visible: false, enabled: false);
                context.SetMesh(triggerIds: new []{8002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003422}, questStates: new byte[]{2})) {
                    return new State도망쳐_12(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003422}, questStates: new byte[]{1})) {
                    return new StateCameraEffect01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003422}, questStates: new byte[]{3})) {
                    return new State도망쳐_26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101});
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000198, portalId: 5001);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State도망쳐_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_01 : TriggerState {
            internal State도망쳐_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__1$", align: Align.Left, illustId: "Ereb_serious", duration: 4500);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__3$", align: Align.Left, illustId: "Ereb_serious", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    return new State도망쳐_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_01_02 : TriggerState {
            internal State도망쳐_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__4$", duration: 4000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State도망쳐_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_02 : TriggerState {
            internal State도망쳐_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$52000198_QD__52000198__5$", duration: 4000);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2002})) {
                    return new State도망쳐_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_03 : TriggerState {
            internal State도망쳐_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true);
                context.CreateMonster(spawnIds: new []{102});
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2003})) {
                    return new State도망쳐_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_04 : TriggerState {
            internal State도망쳐_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$52000198_QD__52000198__6$", duration: 4000);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2004})) {
                    return new State도망쳐_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_05 : TriggerState {
            internal State도망쳐_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 4, visible: true, enabled: true);
                context.CreateMonster(spawnIds: new []{103});
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2005})) {
                    return new State도망쳐_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_06 : TriggerState {
            internal State도망쳐_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 103, msg: "$52000198_QD__52000198__7$", duration: 4000);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3003");
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2006})) {
                    return new State도망쳐_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_07 : TriggerState {
            internal State도망쳐_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_08 : TriggerState {
            internal State도망쳐_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000198, portalId: 5003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State도망쳐_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_09 : TriggerState {
            internal State도망쳐_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10 : TriggerState {
            internal State도망쳐_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__8$", align: Align.Right, illustId: "Ereb_serious", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State도망쳐_10_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10_01 : TriggerState {
            internal State도망쳐_10_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__9$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__10$", align: Align.Right, illustId: "Ereb_serious", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State도망쳐_10_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10_02 : TriggerState {
            internal State도망쳐_10_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4500f);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__11$", duration: 4500);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__12$", align: Align.Right, illustId: "Ereb_closeEye", duration: 1800);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__13$", align: Align.Right, illustId: "Ereb_serious", duration: 4500);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10800)) {
                    return new State도망쳐_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_11 : TriggerState {
            internal State도망쳐_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 103, msg: "$52000198_QD__52000198__14$", duration: 4000);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2007}, questIds: new []{10003422}, questStates: new byte[]{2})) {
                    return new State도망쳐_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_12 : TriggerState {
            internal State도망쳐_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_13 : TriggerState {
            internal State도망쳐_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{104});
                context.MoveUser(mapId: 52000198, portalId: 5004);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State도망쳐_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_14 : TriggerState {
            internal State도망쳐_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_15 : TriggerState {
            internal State도망쳐_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__15$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000198_QD__52000198__16$", align: Align.Left, illustId: "Baron_normal", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State도망쳐_15_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_15_01 : TriggerState {
            internal State도망쳐_15_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 4000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000198_QD__52000198__17$", duration: 4500);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000198_QD__52000198__18$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000198_QD__52000198__19$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    return new State도망쳐_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_16 : TriggerState {
            internal State도망쳐_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_17 : TriggerState {
            internal State도망쳐_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{104});
                context.CreateMonster(spawnIds: new []{105});
                context.MoveUser(mapId: 52000198, portalId: 5003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State도망쳐_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_19 : TriggerState {
            internal State도망쳐_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_20 : TriggerState {
            internal State도망쳐_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__20$", align: Align.Right, illustId: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000198_QD__52000198__21$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__22$", align: Align.Right, illustId: "Ereb_serious", duration: 4500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    return new State도망쳐_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_21 : TriggerState {
            internal State도망쳐_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State도망쳐_22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_22 : TriggerState {
            internal State도망쳐_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Object_React_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도망쳐_23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_23 : TriggerState {
            internal State도망쳐_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetMesh(triggerIds: new []{8001}, visible: false);
                context.SetMesh(triggerIds: new []{8002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도망쳐_24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_24 : TriggerState {
            internal State도망쳐_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcId: 11001302, script: "$52000198_QD__52000198__23$", align: Align.Right, illustId: "Ereb_serious", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State도망쳐_25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(spawnIds: new []{104, 105});
                context.CreateMonster(spawnIds: new []{105});
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(triggerIds: new []{8001}, visible: false);
                context.SetMesh(triggerIds: new []{8002}, visible: true);
                context.MoveUser(mapId: 52000198, portalId: 5003);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State도망쳐_25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_25 : TriggerState {
            internal State도망쳐_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(spawnIds: new []{103});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003422}, questStates: new byte[]{3})) {
                    return new State도망쳐_26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State도망쳐_26 : TriggerState {
            internal State도망쳐_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 5002, visible: true, enabled: true);
                context.DestroyMonster(spawnIds: new []{105});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
