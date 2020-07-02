namespace Maple2.Trigger._52000055_qd {
    public static class _darkwindmovie {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 104, 200, 201, 202, 203, 204, 205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9000}, arg2: new[] {60100235}, arg3: new byte[] {1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 6002, arg2: false, arg3: false, arg4: false);
                context.SetOnetimeEffect(id: 11100101, enable: true, path: @"BG/Common/Sound/Eff_Object_CityWar_ComputerRoom_01.xml");
                context.MoveUser(arg1: 52000055, arg2: 1);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 101, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_PC");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_Katvan");
                context.SetSceneSkip(arg1: "Quit", arg2: "exit");
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 102, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 103, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.CameraSelect(arg1: 104, arg2: true);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {119, 120}, arg2: true);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 11100102, enable: true, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemWarningAlarm_01.xml");
                context.SetOnetimeEffect(id: 02100267, enable: true, path: @"BG/Common/Sound/Eff_Object_CityWar_ComputerSignal_01.xml");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 100, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_AI_00001876.xml");
                context.SetConversation(arg1: 2, arg2: 11001896, arg3: "$52000055_QD__DARKWINDMOVIE__0$", arg4: 7);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 11100102, enable: false, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemWarningAlarm_01.xml");
                context.CameraSelectPath(arg1: new[] {106, 128}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateCityWarfareTalk3(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk3 : TriggerState {
            internal StateCityWarfareTalk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001878.xml");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__1$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {105, 127}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateCityWarfareTalk5(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk5 : TriggerState {
            internal StateCityWarfareTalk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 03500148, enable: true, path: @"BG/Common/Sound/Eff_Object_CityWar_KeyboardTyping_01.xml");
                context.SetConversation(arg1: 2, arg2: 11000259, arg3: "$52000055_QD__DARKWINDMOVIE__2$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {107, 129}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateCityWarfareTalk7(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk7 : TriggerState {
            internal StateCityWarfareTalk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000259, arg3: "$52000055_QD__DARKWINDMOVIE__3$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {109, 110, 111}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateCameraEffect109(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect109 : TriggerState {
            internal StateCameraEffect109(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100103, enable: true, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemErrorAlarm_01.xml");
                context.SetOnetimeEffect(id: 102, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_AI_00001877.xml");
                context.SetConversation(arg1: 2, arg2: 11001896, arg3: "$52000055_QD__DARKWINDMOVIE__4$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 11100103, enable: false, path: @"BG/Common/Sound/Eff_Object_CityWar_SystemErrorAlarm_01.xml");
            }

            public override TriggerState Execute() {
                return new StateCityWarfareTalk11(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk11 : TriggerState {
            internal StateCityWarfareTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 105, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000259, arg3: "$52000055_QD__DARKWINDMOVIE__5$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCameraEffect13(context);
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect13 : TriggerState {
            internal StateCameraEffect13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 112, arg2: true);
                context.CameraSelectPath(arg1: new[] {112, 113}, arg2: true);
                context.SetOnetimeEffect(id: 103, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001879.xml");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__6$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk15(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk15 : TriggerState {
            internal StateCityWarfareTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 114, arg2: true);
                context.CameraSelectPath(arg1: new[] {114, 115}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000259, arg3: "$52000055_QD__DARKWINDMOVIE__7$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk17(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk17 : TriggerState {
            internal StateCityWarfareTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000215, arg3: "$52000055_QD__DARKWINDMOVIE__8$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.CameraSelectPath(arg1: new[] {117, 118}, arg2: true);
            }

            public override TriggerState Execute() {
                return new StateCityWarfareTalk19(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk19 : TriggerState {
            internal StateCityWarfareTalk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 104, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001880.xml");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__9$", arg4: 5);
            }

            public override TriggerState Execute() {
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
                context.SetOnetimeEffect(id: 115, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001964.xml");
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__10$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk21(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk21 : TriggerState {
            internal StateCityWarfareTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 118, arg2: true);
                context.CameraSelectPath(arg1: new[] {121, 122}, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk23(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk23 : TriggerState {
            internal StateCityWarfareTalk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 105, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001881.xml");
                context.CameraSelect(arg1: 122, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__11$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk25(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk25 : TriggerState {
            internal StateCityWarfareTalk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {125, 126}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000215, arg3: "$52000055_QD__DARKWINDMOVIE__12$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk27(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk27 : TriggerState {
            internal StateCityWarfareTalk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 106, enable: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001882.xml");
                context.CameraSelectPath(arg1: new[] {123, 124}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001897, arg3: "$52000055_QD__DARKWINDMOVIE__13$", arg4: 5);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                return new StateCityWarfareTalk29(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk29 : TriggerState {
            internal StateCityWarfareTalk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
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
                context.SetPortal(arg1: 6002, arg2: true, arg3: true, arg4: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveUser(arg1: 52000067, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}