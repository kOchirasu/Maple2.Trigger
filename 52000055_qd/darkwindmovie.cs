namespace Maple2.Trigger._52000055_qd {
    public static class _darkwindmovie {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 104, 200, 201, 202, 203, 204, 205}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{60100235}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6002, visible: false, enabled: false, minimapVisible: false);
                context.SetOnetimeEffect(id: 11100101, enabled: true, path: @"BG/Common/Sound/Eff_Object_CityWar_ComputerRoom_01.xml");
                context.MoveUser(mapId: 52000055, portalId: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
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

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.CameraSelect(triggerId: 101, enabled: true);
                context.MoveUserPath(patrolName: "MS2PatrolData_PC");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Katvan");
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect4 : TriggerState {
            internal StateCameraEffect4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 102, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCameraEffect5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect5 : TriggerState {
            internal StateCameraEffect5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect6 : TriggerState {
            internal StateCameraEffect6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(triggerId: 103, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect7 : TriggerState {
            internal StateCameraEffect7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 104, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new StateCameraEffect8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect8 : TriggerState {
            internal StateCameraEffect8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{119, 120}, returnView: true);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect9(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect9 : TriggerState {
            internal StateCameraEffect9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100102, enabled: true, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemWarningAlarm_01.xml");
                context.SetOnetimeEffect(id: 02100267, enabled: true, path: @"BG/Common/Sound/Eff_Object_CityWar_ComputerSignal_01.xml");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 100, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_AI_00001876.xml");
                context.SetConversation(type: 2, spawnId: 11001896, script: "$52000055_QD__DARKWINDMOVIE__0$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCityWarfareTalk2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk2 : TriggerState {
            internal StateCityWarfareTalk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 11100102, enabled: false, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemWarningAlarm_01.xml");
                context.CameraSelectPath(pathIds: new []{106, 128}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk3(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk3 : TriggerState {
            internal StateCityWarfareTalk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001878.xml");
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__1$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCityWarfareTalk4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk4 : TriggerState {
            internal StateCityWarfareTalk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelectPath(pathIds: new []{105, 127}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk5(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk5 : TriggerState {
            internal StateCityWarfareTalk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 03500148, enabled: true, path: @"BG/Common/Sound/Eff_Object_CityWar_KeyboardTyping_01.xml");
                context.SetConversation(type: 2, spawnId: 11000259, script: "$52000055_QD__DARKWINDMOVIE__2$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCityWarfareTalk6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk6 : TriggerState {
            internal StateCityWarfareTalk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelectPath(pathIds: new []{107, 129}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk7(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk7 : TriggerState {
            internal StateCityWarfareTalk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000259, script: "$52000055_QD__DARKWINDMOVIE__3$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new StateCityWarfareTalk8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk8 : TriggerState {
            internal StateCityWarfareTalk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelectPath(pathIds: new []{109, 110, 111}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateCameraEffect109(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect109 : TriggerState {
            internal StateCameraEffect109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100103, enabled: true, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemErrorAlarm_01.xml");
                context.SetOnetimeEffect(id: 102, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_AI_00001877.xml");
                context.SetConversation(type: 2, spawnId: 11001896, script: "$52000055_QD__DARKWINDMOVIE__4$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateCityWarfareTalk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk10 : TriggerState {
            internal StateCityWarfareTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 11100103, enabled: false, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemErrorAlarm_01.xml");
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk11(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk11 : TriggerState {
            internal StateCityWarfareTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 105, enabled: true);
                context.SetConversation(type: 2, spawnId: 11000259, script: "$52000055_QD__DARKWINDMOVIE__5$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk12 : TriggerState {
            internal StateCityWarfareTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCameraEffect13(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect13 : TriggerState {
            internal StateCameraEffect13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 112, enabled: true);
                context.CameraSelectPath(pathIds: new []{112, 113}, returnView: true);
                context.SetOnetimeEffect(id: 103, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001879.xml");
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__6$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCityWarfareTalk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk14 : TriggerState {
            internal StateCityWarfareTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk15(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk15 : TriggerState {
            internal StateCityWarfareTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 114, enabled: true);
                context.CameraSelectPath(pathIds: new []{114, 115}, returnView: true);
                context.SetConversation(type: 2, spawnId: 11000259, script: "$52000055_QD__DARKWINDMOVIE__7$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk16 : TriggerState {
            internal StateCityWarfareTalk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk17(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk17 : TriggerState {
            internal StateCityWarfareTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000215, script: "$52000055_QD__DARKWINDMOVIE__8$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new StateCityWarfareTalk18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk18 : TriggerState {
            internal StateCityWarfareTalk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.CameraSelectPath(pathIds: new []{117, 118}, returnView: true);
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk19(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk19 : TriggerState {
            internal StateCityWarfareTalk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 104, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001880.xml");
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__9$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateCityWarfareTalk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk20 : TriggerState {
            internal StateCityWarfareTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 115, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001964.xml");
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__10$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCityWarfareTalk20b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk20b : TriggerState {
            internal StateCityWarfareTalk20b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk21(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk21 : TriggerState {
            internal StateCityWarfareTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 118, enabled: true);
                context.CameraSelectPath(pathIds: new []{121, 122}, returnView: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCityWarfareTalk22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk22 : TriggerState {
            internal StateCityWarfareTalk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk23(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk23 : TriggerState {
            internal StateCityWarfareTalk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 105, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001881.xml");
                context.CameraSelect(triggerId: 122, enabled: true);
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__11$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk24(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk24 : TriggerState {
            internal StateCityWarfareTalk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk25(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk25 : TriggerState {
            internal StateCityWarfareTalk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{125, 126}, returnView: true);
                context.SetConversation(type: 2, spawnId: 11000215, script: "$52000055_QD__DARKWINDMOVIE__12$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk26(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk26 : TriggerState {
            internal StateCityWarfareTalk26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk27(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk27 : TriggerState {
            internal StateCityWarfareTalk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 106, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001882.xml");
                context.CameraSelectPath(pathIds: new []{123, 124}, returnView: true);
                context.SetConversation(type: 2, spawnId: 11001897, script: "$52000055_QD__DARKWINDMOVIE__13$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk28 : TriggerState {
            internal StateCityWarfareTalk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk29(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk29 : TriggerState {
            internal StateCityWarfareTalk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 6002, visible: true, enabled: true, minimapVisible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveUser(mapId: 52000067, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
