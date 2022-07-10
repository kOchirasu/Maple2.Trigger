namespace Maple2.Trigger._52000035_qd {
    public static class _epilogue5movie {
        public class StateStart01 : TriggerState {
            internal StateStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "50001625") == 1) {
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
                if (context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{3})) {
                    return new StateLoadingDelayB0(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{3})) {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE5MOVIE__0$");
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
                context.MoveUser(mapId: 02000065, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB0 : TriggerState {
            internal StateLoadingDelayB0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
                context.SetOnetimeEffect(id: 11100104, enable: true, path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{102, 5400, 5401, 5200, 5300}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCameraEffect1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1 : TriggerState {
            internal StateCameraEffect1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 02100280, enable: true, path: @"BG/Common/Sound/Eff_System_Chapter5_Armour_Footsteps_Long_01.xml");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(spawnId: 5400, patrolName: "MS2PatrolData_RoguesEnd_B");
                context.MoveNpc(spawnId: 5401, patrolName: "MS2PatrolData_RoguesEnd_A");
                context.CameraSelectPath(pathIds: new []{51000, 51001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateCameraEffect2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect2 : TriggerState {
            internal StateCameraEffect2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEpilogue5Talk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk1 : TriggerState {
            internal StateEpilogue5Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{52000, 52001}, returnView: false);
                context.SetOnetimeEffect(id: 1920, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001920.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__1$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk2(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk2 : TriggerState {
            internal StateEpilogue5Talk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk3(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk3 : TriggerState {
            internal StateEpilogue5Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{52002, 52003}, returnView: false);
                context.SetOnetimeEffect(id: 1921, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001921.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__2$", arg4: 12);
                context.SetSkip(state: new StateEpilogue5Talk4(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateEpilogue5Talk4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk4 : TriggerState {
            internal StateEpilogue5Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk5(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk5 : TriggerState {
            internal StateEpilogue5Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53007}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkToTurka");
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__3$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk6(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk6 : TriggerState {
            internal StateEpilogue5Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk7(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk7 : TriggerState {
            internal StateEpilogue5Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{52004}, returnView: false);
                context.SetOnetimeEffect(id: 1922, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001922.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__4$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk8(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk8 : TriggerState {
            internal StateEpilogue5Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk9(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk9 : TriggerState {
            internal StateEpilogue5Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_TurkaToDark");
                context.CameraSelectPath(pathIds: new []{2102, 2103}, returnView: false);
                context.SetOnetimeEffect(id: 1923, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001923.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__5$", arg4: 8);
                context.SetSkip(state: new StateEpilogue5Talk10(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue5Talk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk10 : TriggerState {
            internal StateEpilogue5Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk11(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk11 : TriggerState {
            internal StateEpilogue5Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53001, 53002}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_threatTurka");
                context.SetOnetimeEffect(id: 02100281, enable: true, path: @"BG/Common/Sound/Eff_System_Chapter5_Armor_Footsteps_Short_01.xml");
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__6$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk12(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk12 : TriggerState {
            internal StateEpilogue5Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk13(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk13 : TriggerState {
            internal StateEpilogue5Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53003, 53004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__7$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk14 : TriggerState {
            internal StateEpilogue5Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk16(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk16 : TriggerState {
            internal StateEpilogue5Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53005, 53006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__8$", arg4: 5);
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Bore_A");
                context.SetSkip(state: new StateEpilogue5Talk17(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk17 : TriggerState {
            internal StateEpilogue5Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk18(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk18 : TriggerState {
            internal StateEpilogue5Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{52005}, returnView: false);
                context.SetOnetimeEffect(id: 1924, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001924.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__9$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk19(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk19 : TriggerState {
            internal StateEpilogue5Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 5200, patrolName: "MS2PatrolData_TurkaReturn");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk20(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk20 : TriggerState {
            internal StateEpilogue5Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53008, 53009}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkToTurka");
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__10$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk21(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk21 : TriggerState {
            internal StateEpilogue5Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk22(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk22 : TriggerState {
            internal StateEpilogue5Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{51002, 51003}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_darkReturn");
                context.SetOnetimeEffect(id: 1925, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001925.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__11$", arg4: 6);
                context.SetSkip(state: new StateEpilogue5Talk23(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue5Talk23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk23 : TriggerState {
            internal StateEpilogue5Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk24(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk24 : TriggerState {
            internal StateEpilogue5Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1926, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001926.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__12$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk25(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk25 : TriggerState {
            internal StateEpilogue5Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk27(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk27 : TriggerState {
            internal StateEpilogue5Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{53010}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__32$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk28(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk28 : TriggerState {
            internal StateEpilogue5Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk29(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk29 : TriggerState {
            internal StateEpilogue5Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{52006, 52007}, returnView: false);
                context.SetOnetimeEffect(id: 1927, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001927.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__13$", arg4: 10);
                context.SetSkip(state: new StateEpilogue5Talk30(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue5Talk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk30 : TriggerState {
            internal StateEpilogue5Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk31(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk31 : TriggerState {
            internal StateEpilogue5Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1928, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001928.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__14$", arg4: 10);
                context.SetSkip(state: new StateEpilogue5Talk32(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue5Talk32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk32 : TriggerState {
            internal StateEpilogue5Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk33(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk33 : TriggerState {
            internal StateEpilogue5Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{51004, 51005}, returnView: false);
                context.SetOnetimeEffect(id: 1929, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001929.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__15$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk34(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk34(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk34 : TriggerState {
            internal StateEpilogue5Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk35(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk35 : TriggerState {
            internal StateEpilogue5Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1930, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001930.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__16$", arg4: 12);
                context.SetSkip(state: new StateEpilogue5Talk36(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateEpilogue5Talk36(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk36 : TriggerState {
            internal StateEpilogue5Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk37(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk37 : TriggerState {
            internal StateEpilogue5Talk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{53011, 53012}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__17$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk38(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk38(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk38 : TriggerState {
            internal StateEpilogue5Talk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk39(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk39 : TriggerState {
            internal StateEpilogue5Talk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkToTurka");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__18$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk40(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk40 : TriggerState {
            internal StateEpilogue5Talk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk41(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk41 : TriggerState {
            internal StateEpilogue5Talk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1300}, returnView: false);
                context.SetOnetimeEffect(id: 1931, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001931.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__19$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk42(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk42(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk42 : TriggerState {
            internal StateEpilogue5Talk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk43(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk43 : TriggerState {
            internal StateEpilogue5Talk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_darkReturn");
                context.CameraSelectPath(pathIds: new []{1400}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 5300, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__20$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk44(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk44(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk44 : TriggerState {
            internal StateEpilogue5Talk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk45(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk45 : TriggerState {
            internal StateEpilogue5Talk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1300}, returnView: false);
                context.SetOnetimeEffect(id: 1932, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001932.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__21$", arg4: 7);
                context.SetSkip(state: new StateEpilogue5Talk46(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue5Talk46(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk46 : TriggerState {
            internal StateEpilogue5Talk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk47(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk47 : TriggerState {
            internal StateEpilogue5Talk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{54000}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__22$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk48(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk48(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk48 : TriggerState {
            internal StateEpilogue5Talk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk49(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk49 : TriggerState {
            internal StateEpilogue5Talk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{52008}, returnView: false);
                context.SetOnetimeEffect(id: 1933, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001933.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__23$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk50(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk50 : TriggerState {
            internal StateEpilogue5Talk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk51(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk51 : TriggerState {
            internal StateEpilogue5Talk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{51006, 51007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__24$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk52(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk52(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk52 : TriggerState {
            internal StateEpilogue5Talk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk53(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk53 : TriggerState {
            internal StateEpilogue5Talk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1934, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001934.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE5MOVIE__25$", arg4: 8);
                context.SetSkip(state: new StateEpilogue5Talk54(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue5Talk54(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk54 : TriggerState {
            internal StateEpilogue5Talk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk55(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk55 : TriggerState {
            internal StateEpilogue5Talk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(pathIds: new []{53013, 53014}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE5MOVIE__26$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk56(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue5Talk56(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk56 : TriggerState {
            internal StateEpilogue5Talk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk57(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk57 : TriggerState {
            internal StateEpilogue5Talk57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1400}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__27$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk58(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk58(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk58 : TriggerState {
            internal StateEpilogue5Talk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(spawnId: 5300, patrolName: "MS2PatrolData_bellaOUT");
                context.SetOnetimeEffect(id: 02100282, enable: true, path: @"BG/Common/Sound/Eff_System_Chapter5_Bella_Foosteps_01.xml");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk59(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk59 : TriggerState {
            internal StateEpilogue5Talk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{55001, 55002}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__28$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk60(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk60 : TriggerState {
            internal StateEpilogue5Talk60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk61(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk61 : TriggerState {
            internal StateEpilogue5Talk61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{55003, 55004}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__29$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk62(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk62(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk62 : TriggerState {
            internal StateEpilogue5Talk62(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 10, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk63(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk63 : TriggerState {
            internal StateEpilogue5Talk63(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{55005, 55006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__30$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk64(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEpilogue5Talk64(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk64 : TriggerState {
            internal StateEpilogue5Talk64(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetOnetimeEffect(id: 02100282, enable: false, path: @"BG/Common/Sound/Eff_System_Chapter5_Bella_Foosteps_01.xml");
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk65(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk65 : TriggerState {
            internal StateEpilogue5Talk65(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{55007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE5MOVIE__31$", arg4: 5);
                context.SetSkip(state: new StateEpilogue5Talk66(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk66(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk66 : TriggerState {
            internal StateEpilogue5Talk66(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue5Talk67(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk67 : TriggerState {
            internal StateEpilogue5Talk67(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue5Talk68(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk68 : TriggerState {
            internal StateEpilogue5Talk68(ITriggerContext context) : base(context) { }

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
                context.MoveUser(mapId: 02000065, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
