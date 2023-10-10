namespace Maple2.Trigger._52000035_qd {
    public static class _epilogue6movie {
        public class StateStart01 : TriggerState {
            internal StateStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "50001677") == 1) {
                    return new StateStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart02 : TriggerState {
            internal StateStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{3})) {
                    return new StateLoadingDelayC0(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{3})) {
                    return new StateReturnMapReady0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady0 : TriggerState {
            internal StateReturnMapReady0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateReturnMapReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady : TriggerState {
            internal StateReturnMapReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE6MOVIE__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReturnMap(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMap : TriggerState {
            internal StateReturnMap(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000154, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayC0 : TriggerState {
            internal StateLoadingDelayC0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
                context.SetOnetimeEffect(id: 11100104, enabled: true, path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{900, 102, 200, 300, 5400, 5401}, arg2: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_EP4_Turka");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_EP4_Madria");
                context.MoveNpc(spawnId: 5400, patrolName: "MS2PatrolData_RoguesEnd_A");
                context.MoveNpc(spawnId: 5401, patrolName: "MS2PatrolData_RoguesEnd_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCamera6000_0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera6000_0 : TriggerState {
            internal StateCamera6000_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100283, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter6_RedChrystal_01.xml");
                context.CameraSelectPath(pathIds: new []{6012, 6001}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCamera6000_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCamera6000_2 : TriggerState {
            internal StateCamera6000_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100284, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter6_BlueFire_Burning_01.xml");
                context.CameraSelectPath(pathIds: new []{6004, 6005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateLoadingDelayC1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayC1 : TriggerState {
            internal StateLoadingDelayC1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEpilogue6Talk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk1 : TriggerState {
            internal StateEpilogue6Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{6113, 6112}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__1$", arg4: 7);
                context.SetSkip(state: new StateEpilogue6Talk2(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue6Talk2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk2 : TriggerState {
            internal StateEpilogue6Talk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk3(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk3 : TriggerState {
            internal StateEpilogue6Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{6200, 6201}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__2$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk4(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk4 : TriggerState {
            internal StateEpilogue6Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk5(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk5 : TriggerState {
            internal StateEpilogue6Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__3$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk6(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk6 : TriggerState {
            internal StateEpilogue6Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk7(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk7 : TriggerState {
            internal StateEpilogue6Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6300, 6301}, returnView: false);
                context.SetOnetimeEffect(id: 1935, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001935.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__4$", arg4: 14);
                context.SetSkip(state: new StateEpilogue6Talk8(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateEpilogue6Talk8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk8 : TriggerState {
            internal StateEpilogue6Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk9(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk9 : TriggerState {
            internal StateEpilogue6Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6400, 6401}, returnView: false);
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_MadToDark");
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__5$", arg4: 6);
                context.SetOnetimeEffect(id: 1984, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_01_00001984.xml");
                context.SetSkip(state: new StateEpilogue6Talk10(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue6Talk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk10 : TriggerState {
            internal StateEpilogue6Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_madriaReturn");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk11(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk11 : TriggerState {
            internal StateEpilogue6Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{1200, 1201}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__6$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk12(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk12 : TriggerState {
            internal StateEpilogue6Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk13(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk13 : TriggerState {
            internal StateEpilogue6Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1500}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__7$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk14 : TriggerState {
            internal StateEpilogue6Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk15(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk15 : TriggerState {
            internal StateEpilogue6Talk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__8$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk16(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk16 : TriggerState {
            internal StateEpilogue6Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk17(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk17 : TriggerState {
            internal StateEpilogue6Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6103, 6114}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__9$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk18(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk18 : TriggerState {
            internal StateEpilogue6Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk19(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk19 : TriggerState {
            internal StateEpilogue6Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{6202}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__10$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk20(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk20 : TriggerState {
            internal StateEpilogue6Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk21(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk21 : TriggerState {
            internal StateEpilogue6Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1400}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__11$", arg4: 7);
                context.SetOnetimeEffect(id: 1985, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_02_00001985.xml");
                context.SetSkip(state: new StateEpilogue6Talk22(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue6Talk22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk22 : TriggerState {
            internal StateEpilogue6Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk23B(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk23B : TriggerState {
            internal StateEpilogue6Talk23B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__12$", arg4: 8);
                context.SetOnetimeEffect(id: 1986, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_03_00001986.xml");
                context.SetSkip(state: new StateEpilogue6Talk22B(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue6Talk22B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk22B : TriggerState {
            internal StateEpilogue6Talk22B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk23(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk23 : TriggerState {
            internal StateEpilogue6Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6104, 6115}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__13$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk24(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk24 : TriggerState {
            internal StateEpilogue6Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk25(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk25 : TriggerState {
            internal StateEpilogue6Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1404}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__14$", arg4: 7);
                context.SetOnetimeEffect(id: 1987, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_04_00001987.xml");
                context.SetSkip(state: new StateEpilogue6Talk26(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue6Talk26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk26 : TriggerState {
            internal StateEpilogue6Talk26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk27(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk27 : TriggerState {
            internal StateEpilogue6Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1500}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__15$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk28(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk28 : TriggerState {
            internal StateEpilogue6Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk29(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk29 : TriggerState {
            internal StateEpilogue6Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6402, 6403}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__16$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk30(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk30 : TriggerState {
            internal StateEpilogue6Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk31(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk31 : TriggerState {
            internal StateEpilogue6Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6302, 6303}, returnView: false);
                context.SetOnetimeEffect(id: 1936, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001936.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__17$", arg4: 9);
                context.SetSkip(state: new StateEpilogue6Talk32(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEpilogue6Talk32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk32 : TriggerState {
            internal StateEpilogue6Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk33(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk33 : TriggerState {
            internal StateEpilogue6Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6006, 6007}, returnView: false);
                context.SetOnetimeEffect(id: 1937, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001937.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__18$", arg4: 10);
                context.SetSkip(state: new StateEpilogue6Talk34(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue6Talk34(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk34 : TriggerState {
            internal StateEpilogue6Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk35(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk35 : TriggerState {
            internal StateEpilogue6Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6105, 6106}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__19$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk36(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk36(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk36 : TriggerState {
            internal StateEpilogue6Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk37(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk37 : TriggerState {
            internal StateEpilogue6Talk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__20$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk38(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk38(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk38 : TriggerState {
            internal StateEpilogue6Talk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk40(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk40 : TriggerState {
            internal StateEpilogue6Talk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6107, 6108}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__21$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk41(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk41(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk41 : TriggerState {
            internal StateEpilogue6Talk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk42(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk42 : TriggerState {
            internal StateEpilogue6Talk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6109, 6110}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__22$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk43(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue6Talk43(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk43 : TriggerState {
            internal StateEpilogue6Talk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk44(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk44 : TriggerState {
            internal StateEpilogue6Talk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6404, 6405}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__23$", arg4: 5);
                context.SetOnetimeEffect(id: 1988, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_05_00001988.xml");
                context.SetSkip(state: new StateEpilogue6Talk45(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk45(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk45 : TriggerState {
            internal StateEpilogue6Talk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk46(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk46 : TriggerState {
            internal StateEpilogue6Talk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100285, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter6_RedChrystal_02.xml");
                context.CameraSelectPath(pathIds: new []{6008, 6009}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__24$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk47(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue6Talk47(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk47 : TriggerState {
            internal StateEpilogue6Talk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk48(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk48 : TriggerState {
            internal StateEpilogue6Talk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6406, 6407}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__25$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk49(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk49(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk49 : TriggerState {
            internal StateEpilogue6Talk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk50B(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk50B : TriggerState {
            internal StateEpilogue6Talk50B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6304, 6305}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__26$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk49C(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk49C(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk49C : TriggerState {
            internal StateEpilogue6Talk49C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk50(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk50 : TriggerState {
            internal StateEpilogue6Talk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6306}, returnView: false);
                context.SetOnetimeEffect(id: 1938, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001938.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__27$", arg4: 10);
                context.SetSkip(state: new StateEpilogue6Talk51(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue6Talk51(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk51 : TriggerState {
            internal StateEpilogue6Talk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk52(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk52 : TriggerState {
            internal StateEpilogue6Talk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{6203, 6206}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__28$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk53B(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk53B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk53B : TriggerState {
            internal StateEpilogue6Talk53B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk54B(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk54B : TriggerState {
            internal StateEpilogue6Talk54B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__29$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk53(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk53(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk53 : TriggerState {
            internal StateEpilogue6Talk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk54(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk54 : TriggerState {
            internal StateEpilogue6Talk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6010, 6011}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__30$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk55(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk55(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk55 : TriggerState {
            internal StateEpilogue6Talk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk56(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk56 : TriggerState {
            internal StateEpilogue6Talk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{53011, 53012}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__31$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk57(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue6Talk57(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk57 : TriggerState {
            internal StateEpilogue6Talk57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk58(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk58 : TriggerState {
            internal StateEpilogue6Talk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6111}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__32$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk59(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk59(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk59 : TriggerState {
            internal StateEpilogue6Talk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk60(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk60 : TriggerState {
            internal StateEpilogue6Talk60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6307, 6308}, returnView: false);
                context.SetOnetimeEffect(id: 1939, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001939.xml");
                context.SetOnetimeEffect(id: 02100286, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter6_RedDiscus_01.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__33$", arg4: 11);
                context.SetSkip(state: new StateEpilogue6Talk61(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateEpilogue6Talk61(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk61 : TriggerState {
            internal StateEpilogue6Talk61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk62(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk62 : TriggerState {
            internal StateEpilogue6Talk62(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1940, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001940.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__34$", arg4: 7);
                context.SetSkip(state: new StateEpilogue6Talk63(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue6Talk63(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk63 : TriggerState {
            internal StateEpilogue6Talk63(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk64(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk64 : TriggerState {
            internal StateEpilogue6Talk64(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6204, 6205}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__35$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk65(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue6Talk65(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk65 : TriggerState {
            internal StateEpilogue6Talk65(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk66(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk66 : TriggerState {
            internal StateEpilogue6Talk66(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6310}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__36$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk67(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk67(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk67 : TriggerState {
            internal StateEpilogue6Talk67(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk68(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk68 : TriggerState {
            internal StateEpilogue6Talk68(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{1200}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__37$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk69(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk69(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk69 : TriggerState {
            internal StateEpilogue6Talk69(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk70(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk70 : TriggerState {
            internal StateEpilogue6Talk70(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1500}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE6MOVIE__38$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk71(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk71(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk71 : TriggerState {
            internal StateEpilogue6Talk71(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk72(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk72 : TriggerState {
            internal StateEpilogue6Talk72(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{6200}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE6MOVIE__39$", arg4: 5);
                context.SetSkip(state: new StateEpilogue6Talk73(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk73(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk73 : TriggerState {
            internal StateEpilogue6Talk73(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk74(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk74 : TriggerState {
            internal StateEpilogue6Talk74(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6400, 6401}, returnView: false);
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_MadToDark");
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE6MOVIE__40$", arg4: 5);
                context.SetOnetimeEffect(id: 1989, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter6_End_06_00001989.xml");
                context.SetSkip(state: new StateEpilogue6Talk75(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk75(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk75 : TriggerState {
            internal StateEpilogue6Talk75(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk76(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk76 : TriggerState {
            internal StateEpilogue6Talk76(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_TurkaToDark");
                context.CameraSelectPath(pathIds: new []{2102, 2103}, returnView: false);
                context.SetOnetimeEffect(id: 1941, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001941.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__41$", arg4: 8);
                context.SetSkip(state: new StateEpilogue6Talk77(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue6Talk77(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk77 : TriggerState {
            internal StateEpilogue6Talk77(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkToTurka");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk78(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk78 : TriggerState {
            internal StateEpilogue6Talk78(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6311, 6312}, returnView: false);
                context.SetOnetimeEffect(id: 1942, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001942.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE6MOVIE__42$", arg4: 8);
                context.SetSkip(state: new StateEpilogue6Talk79(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue6Talk79(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk79 : TriggerState {
            internal StateEpilogue6Talk79(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue6Talk80(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk80 : TriggerState {
            internal StateEpilogue6Talk80(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue6Talk81(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue6Talk81 : TriggerState {
            internal StateEpilogue6Talk81(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000154, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
