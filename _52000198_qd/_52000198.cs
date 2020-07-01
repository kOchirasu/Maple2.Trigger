namespace Maple2.Trigger._52000198_qd {
    public static class _52000198 {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5002, arg2: false, arg3: false);
                context.SetPortal(arg1: 2, arg2: false, arg3: false);
                context.SetPortal(arg1: 4, arg2: false, arg3: false);
                context.SetMesh(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003422}, arg3: new byte[] {2})) {
                    context.State = new State도망쳐_12(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003422}, arg3: new byte[] {1})) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003422}, arg3: new byte[] {3})) {
                    context.State = new State도망쳐_26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101});
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000198, arg2: 5001);
                context.CameraSelectPath(arg1: new[] {4001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4002, 4003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State도망쳐_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_01 : TriggerState {
            internal State도망쳐_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Attack_Idle_A", arg2: 3000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__0$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__1$", align: "left", illustId: "Ereb_serious", duration: 4500);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__3$", align: "left", illustId: "Ereb_serious", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 17000)) {
                    context.State = new State도망쳐_01_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_01_02 : TriggerState {
            internal State도망쳐_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__4$", duration: 4000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State도망쳐_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_02 : TriggerState {
            internal State도망쳐_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000198_QD__52000198__5$", duration: 4000);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2002})) {
                    context.State = new State도망쳐_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_03 : TriggerState {
            internal State도망쳐_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true);
                context.CreateMonster(arg1: new[] {102});
                context.DestroyMonster(arg1: new[] {101});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2003})) {
                    context.State = new State도망쳐_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_04 : TriggerState {
            internal State도망쳐_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 102, msg: "$52000198_QD__52000198__6$", duration: 4000);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_3002");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2004})) {
                    context.State = new State도망쳐_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_05 : TriggerState {
            internal State도망쳐_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 4, arg2: true, arg3: true);
                context.CreateMonster(arg1: new[] {103});
                context.DestroyMonster(arg1: new[] {102});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2005})) {
                    context.State = new State도망쳐_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_06 : TriggerState {
            internal State도망쳐_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 103, msg: "$52000198_QD__52000198__7$", duration: 4000);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2006})) {
                    context.State = new State도망쳐_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_07 : TriggerState {
            internal State도망쳐_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_08 : TriggerState {
            internal State도망쳐_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000198, arg2: 5003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State도망쳐_09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_09 : TriggerState {
            internal State도망쳐_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10 : TriggerState {
            internal State도망쳐_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__8$", align: "right", illustId: "Ereb_serious", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    context.State = new State도망쳐_10_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10_01 : TriggerState {
            internal State도망쳐_10_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__9$", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__10$", align: "right", illustId: "Ereb_serious", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new State도망쳐_10_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_10_02 : TriggerState {
            internal State도망쳐_10_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4500f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__11$", duration: 4500);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__12$", align: "right", illustId: "Ereb_closeEye", duration: 1800);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__13$", align: "right", illustId: "Ereb_serious", duration: 4500);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10800)) {
                    context.State = new State도망쳐_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_11 : TriggerState {
            internal State도망쳐_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 103, msg: "$52000198_QD__52000198__14$", duration: 4000);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2007}, arg2: new[] {10003422}, arg3: new byte[] {2})) {
                    context.State = new State도망쳐_12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_12 : TriggerState {
            internal State도망쳐_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_13 : TriggerState {
            internal State도망쳐_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104});
                context.MoveUser(arg1: 52000198, arg2: 5004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State도망쳐_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_14 : TriggerState {
            internal State도망쳐_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_15 : TriggerState {
            internal State도망쳐_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__15$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000198_QD__52000198__16$", align: "left", illustId: "Baron_normal", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    context.State = new State도망쳐_15_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_15_01 : TriggerState {
            internal State도망쳐_15_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Talk_A", arg2: 4000f);
                context.AddCinematicTalk(npcId: 0, msg: "$52000198_QD__52000198__17$", duration: 4500);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000198_QD__52000198__18$", align: "left", illustId: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000198_QD__52000198__19$", align: "left", illustId: "Baron_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    context.State = new State도망쳐_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_16 : TriggerState {
            internal State도망쳐_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_17 : TriggerState {
            internal State도망쳐_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {104});
                context.CreateMonster(arg1: new[] {105});
                context.MoveUser(arg1: 52000198, arg2: 5003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State도망쳐_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_19 : TriggerState {
            internal State도망쳐_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_20 : TriggerState {
            internal State도망쳐_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__20$", align: "right", illustId: "Ereb_surprise", duration: 4000);
                context.AddCinematicTalk(npcId: 11004787, msg: "$52000198_QD__52000198__21$", align: "left", illustId: "Baron_normal", duration: 4000);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__22$", align: "right", illustId: "Ereb_serious", duration: 4500);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12500)) {
                    context.State = new State도망쳐_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_21 : TriggerState {
            internal State도망쳐_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_3004");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State도망쳐_22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_22 : TriggerState {
            internal State도망쳐_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Object_React_A", arg2: 3000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도망쳐_23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_23 : TriggerState {
            internal State도망쳐_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4004}, arg2: false);
                context.SetMesh(arg1: new[] {8001}, arg2: false);
                context.SetMesh(arg1: new[] {8002}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도망쳐_24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_24 : TriggerState {
            internal State도망쳐_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddCinematicTalk(npcId: 11001302, msg: "$52000198_QD__52000198__23$", align: "right", illustId: "Ereb_serious", duration: 3000);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State도망쳐_25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {104, 105});
                context.CreateMonster(arg1: new[] {105});
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetMesh(arg1: new[] {8001}, arg2: false);
                context.SetMesh(arg1: new[] {8002}, arg2: true);
                context.MoveUser(arg1: 52000198, arg2: 5003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State도망쳐_25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_25 : TriggerState {
            internal State도망쳐_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.DestroyMonster(arg1: new[] {103});
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003422}, arg3: new byte[] {3})) {
                    context.State = new State도망쳐_26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State도망쳐_26 : TriggerState {
            internal State도망쳐_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 5002, arg2: true, arg3: true);
                context.DestroyMonster(arg1: new[] {105});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}