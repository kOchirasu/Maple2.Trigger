namespace Maple2.Trigger._52000098_qd {
    public static class _ep10movie {
        public class StateStartCinematic검사 : TriggerState {
            internal StateStartCinematic검사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10000}, arg2: new[] {20002266}, arg3: new byte[] {3})) {
                    return new StateLoadingDelayB0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB0 : TriggerState {
            internal StateLoadingDelayB0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100104, enable: true, path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.CreateMonster(arg1: new[] {2000, 2001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.MoveNpc(arg1: 2001, arg2: "MS2PatrolData_madria");
                context.CameraSelectPath(arg1: new[] {3000, 3001}, arg2: false);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEpilogue10Talk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk1 : TriggerState {
            internal StateEpilogue10Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {3004, 3005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue10Talk3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk3 : TriggerState {
            internal StateEpilogue10Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 3);
                context.CameraSelectPath(arg1: new[] {3002, 3003}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__0$", arg4: 12);
                context.SetSkip(arg1: "Epilogue10Talk4");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateEpilogue10Talk4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk4 : TriggerState {
            internal StateEpilogue10Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk5(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk5 : TriggerState {
            internal StateEpilogue10Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3006, 3007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__1$", arg4: 9);
                context.SetOnetimeEffect(id: 1998, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_01_00001998.xml");
                context.SetSkip(arg1: "Epilogue10Talk6");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEpilogue10Talk6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk6 : TriggerState {
            internal StateEpilogue10Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk7(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk7 : TriggerState {
            internal StateEpilogue10Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__2$", arg4: 9);
                context.SetOnetimeEffect(id: 1999, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_02_00001999.xml");
                context.SetSkip(arg1: "Epilogue10Talk8");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateEpilogue10Talk8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk8 : TriggerState {
            internal StateEpilogue10Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk9(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk9 : TriggerState {
            internal StateEpilogue10Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3008, 3009}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__15$", arg4: 4);
                context.SetSkip(arg1: "Epilogue10Talk10");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEpilogue10Talk10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk10 : TriggerState {
            internal StateEpilogue10Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk11(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk11 : TriggerState {
            internal StateEpilogue10Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3010, 3011}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__3$", arg4: 6);
                context.SetOnetimeEffect(id: 2000, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_03_00002000.xml");
                context.SetSkip(arg1: "Epilogue10Talk12");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue10Talk12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk12 : TriggerState {
            internal StateEpilogue10Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk13(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk13 : TriggerState {
            internal StateEpilogue10Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3012, 3013}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__4$", arg4: 5);
                context.SetSkip(arg1: "Epilogue10Talk14");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue10Talk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk14 : TriggerState {
            internal StateEpilogue10Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk16(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk16 : TriggerState {
            internal StateEpilogue10Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53005, 53006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__5$", arg4: 5);
                context.SetSkip(arg1: "Epilogue10Talk17");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue10Talk17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk17 : TriggerState {
            internal StateEpilogue10Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 02100275, enable: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk18(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk18 : TriggerState {
            internal StateEpilogue10Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3014}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__6$", arg4: 7);
                context.SetSkip(arg1: "Epilogue10Talk19");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue10Talk19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk19 : TriggerState {
            internal StateEpilogue10Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk20(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk20 : TriggerState {
            internal StateEpilogue10Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3015}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__7$", arg4: 5);
                context.SetSkip(arg1: "Epilogue10Talk21");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue10Talk21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk21 : TriggerState {
            internal StateEpilogue10Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk22(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk22 : TriggerState {
            internal StateEpilogue10Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3016, 3017}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__8$", arg4: 6);
                context.SetSkip(arg1: "Epilogue10Talk23");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue10Talk23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk23 : TriggerState {
            internal StateEpilogue10Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk24(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk24 : TriggerState {
            internal StateEpilogue10Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3018}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__9$", arg4: 5);
                context.SetOnetimeEffect(id: 2001, enable: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_04_00002001.xml");
                context.SetSkip(arg1: "Epilogue10Talk25");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue10Talk25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk25 : TriggerState {
            internal StateEpilogue10Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk27(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk27 : TriggerState {
            internal StateEpilogue10Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3019, 3020}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__10$", arg4: 5);
                context.SetSkip(arg1: "Epilogue10Talk28");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue10Talk28(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk28 : TriggerState {
            internal StateEpilogue10Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk29(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk29 : TriggerState {
            internal StateEpilogue10Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3021, 3022}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__11$", arg4: 10);
                context.SetSkip(arg1: "Epilogue10Talk30");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue10Talk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk30 : TriggerState {
            internal StateEpilogue10Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk31(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk31 : TriggerState {
            internal StateEpilogue10Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3023, 3024}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__12$", arg4: 10);
                context.SetSkip(arg1: "Epilogue10Talk32");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue10Talk32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk32 : TriggerState {
            internal StateEpilogue10Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk33(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk33 : TriggerState {
            internal StateEpilogue10Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3025, 3026}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000098_QD__EP10MOVIE__13$", arg4: 7);
                context.SetSkip(arg1: "Epilogue10Talk34");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue10Talk34(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk34 : TriggerState {
            internal StateEpilogue10Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState Execute() {
                return new StateEpilogue10Talk35(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk35 : TriggerState {
            internal StateEpilogue10Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {3027, 3028}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000098_QD__EP10MOVIE__14$", arg4: 12);
                context.SetSkip(arg1: "Epilogue10Talk36");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue10Talk36(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk36 : TriggerState {
            internal StateEpilogue10Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.MoveUser(arg1: 02000175, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}