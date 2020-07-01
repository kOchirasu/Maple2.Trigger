namespace Maple2.Trigger._52000035_qd {
    public static class _epilogue5movie {
        public class Statestart01 : TriggerState {
            internal Statestart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "50001625") == 1) {
                    context.State = new Statestart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart02 : TriggerState {
            internal Statestart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {5000}, arg2: new[] {50001625},
                    arg3: new byte[] {3})) {
                    context.State = new StateLoadingDelayB0(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new[] {5000}, arg2: new[] {50001625},
                    arg3: new byte[] {3})) {
                    context.State = new StateReturnMapReady0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady0 : TriggerState {
            internal StateReturnMapReady0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateReturnMapReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady : TriggerState {
            internal StateReturnMapReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 9, arg2: "$52000035_QD__EPILOGUE5MOVIE__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReturnMap(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMap : TriggerState {
            internal StateReturnMap(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000065, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB0 : TriggerState {
            internal StateLoadingDelayB0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Quit", arg2: "exit");
                context.SetOnetimeEffect(id: 11100104, enable: true,
                    path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.CreateMonster(arg1: new[] {5400}, arg2: false);
                context.CreateMonster(arg1: new[] {5401}, arg2: false);
                context.CreateMonster(arg1: new[] {5200}, arg2: false);
                context.CreateMonster(arg1: new[] {5300}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateCameraEffect1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1 : TriggerState {
            internal StateCameraEffect1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 02100280, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter5_Armour_Footsteps_Long_01.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(arg1: 5400, arg2: "MS2PatrolData_RoguesEnd_B");
                context.MoveNpc(arg1: 5401, arg2: "MS2PatrolData_RoguesEnd_A");
                context.CameraSelectPath(arg1: new[] {51000, 51001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    context.State = new StateCameraEffect2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect2 : TriggerState {
            internal StateCameraEffect2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEpilogue5Talk1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk1 : TriggerState {
            internal StateEpilogue5Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {52000, 52001}, arg2: false);
                context.SetOnetimeEffect(id: 1920, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001920.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__1$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk2 : TriggerState {
            internal StateEpilogue5Talk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk3 : TriggerState {
            internal StateEpilogue5Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {52002, 52003}, arg2: false);
                context.SetOnetimeEffect(id: 1921, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001921.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__2$", arg4: 12);
                context.SetSkip(arg1: "Epilogue5Talk4");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateEpilogue5Talk4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk4 : TriggerState {
            internal StateEpilogue5Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk5 : TriggerState {
            internal StateEpilogue5Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53007}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkToTurka");
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__3$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk6");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk6 : TriggerState {
            internal StateEpilogue5Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk7 : TriggerState {
            internal StateEpilogue5Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {52004}, arg2: false);
                context.SetOnetimeEffect(id: 1922, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001922.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__4$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk8");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk8 : TriggerState {
            internal StateEpilogue5Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk9 : TriggerState {
            internal StateEpilogue5Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_TurkaToDark");
                context.CameraSelectPath(arg1: new[] {2102, 2103}, arg2: false);
                context.SetOnetimeEffect(id: 1923, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001923.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__5$", arg4: 8);
                context.SetSkip(arg1: "Epilogue5Talk10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEpilogue5Talk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk10 : TriggerState {
            internal StateEpilogue5Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk11 : TriggerState {
            internal StateEpilogue5Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53001, 53002}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_threatTurka");
                context.SetOnetimeEffect(id: 02100281, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter5_Armor_Footsteps_Short_01.xml");
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__6$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk12 : TriggerState {
            internal StateEpilogue5Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk13 : TriggerState {
            internal StateEpilogue5Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53003, 53004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__7$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk14 : TriggerState {
            internal StateEpilogue5Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk16 : TriggerState {
            internal StateEpilogue5Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53005, 53006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__8$", arg4: 5);
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Bore_A");
                context.SetSkip(arg1: "Epilogue5Talk17");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk17 : TriggerState {
            internal StateEpilogue5Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk18 : TriggerState {
            internal StateEpilogue5Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {52005}, arg2: false);
                context.SetOnetimeEffect(id: 1924, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001924.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__9$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk19");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk19 : TriggerState {
            internal StateEpilogue5Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 5200, arg2: "MS2PatrolData_TurkaReturn");
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk20 : TriggerState {
            internal StateEpilogue5Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {53008, 53009}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkToTurka");
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__10$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk21");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk21 : TriggerState {
            internal StateEpilogue5Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk22 : TriggerState {
            internal StateEpilogue5Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {51002, 51003}, arg2: false);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_darkReturn");
                context.SetOnetimeEffect(id: 1925, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001925.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__11$", arg4: 6);
                context.SetSkip(arg1: "Epilogue5Talk23");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateEpilogue5Talk23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk23 : TriggerState {
            internal StateEpilogue5Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk24 : TriggerState {
            internal StateEpilogue5Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1926, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001926.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__12$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk25");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk25 : TriggerState {
            internal StateEpilogue5Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk27 : TriggerState {
            internal StateEpilogue5Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(arg1: new[] {53010}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__32$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk28");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk28 : TriggerState {
            internal StateEpilogue5Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk29 : TriggerState {
            internal StateEpilogue5Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {52006, 52007}, arg2: false);
                context.SetOnetimeEffect(id: 1927, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001927.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__13$", arg4: 10);
                context.SetSkip(arg1: "Epilogue5Talk30");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEpilogue5Talk30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk30 : TriggerState {
            internal StateEpilogue5Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk31 : TriggerState {
            internal StateEpilogue5Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1928, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001928.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__14$", arg4: 10);
                context.SetSkip(arg1: "Epilogue5Talk32");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEpilogue5Talk32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk32 : TriggerState {
            internal StateEpilogue5Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk33 : TriggerState {
            internal StateEpilogue5Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {51004, 51005}, arg2: false);
                context.SetOnetimeEffect(id: 1929, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001929.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__15$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk34");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk34 : TriggerState {
            internal StateEpilogue5Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk35 : TriggerState {
            internal StateEpilogue5Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1930, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001930.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__16$", arg4: 12);
                context.SetSkip(arg1: "Epilogue5Talk36");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateEpilogue5Talk36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk36 : TriggerState {
            internal StateEpilogue5Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk37 : TriggerState {
            internal StateEpilogue5Talk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(arg1: new[] {53011, 53012}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__17$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk38");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk38 : TriggerState {
            internal StateEpilogue5Talk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk39 : TriggerState {
            internal StateEpilogue5Talk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkToTurka");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__18$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk40");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk40 : TriggerState {
            internal StateEpilogue5Talk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk41 : TriggerState {
            internal StateEpilogue5Talk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1300}, arg2: false);
                context.SetOnetimeEffect(id: 1931, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001931.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__19$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk42");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk42 : TriggerState {
            internal StateEpilogue5Talk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk43 : TriggerState {
            internal StateEpilogue5Talk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_darkReturn");
                context.CameraSelectPath(arg1: new[] {1400}, arg2: false);
                context.SetNpcEmotionSequence(arg1: 5300, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__20$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk44");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk44 : TriggerState {
            internal StateEpilogue5Talk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk45 : TriggerState {
            internal StateEpilogue5Talk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1300}, arg2: false);
                context.SetOnetimeEffect(id: 1932, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001932.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__21$", arg4: 7);
                context.SetSkip(arg1: "Epilogue5Talk46");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue5Talk46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk46 : TriggerState {
            internal StateEpilogue5Talk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk47 : TriggerState {
            internal StateEpilogue5Talk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {54000}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__22$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk48");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk48 : TriggerState {
            internal StateEpilogue5Talk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk49 : TriggerState {
            internal StateEpilogue5Talk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {52008}, arg2: false);
                context.SetOnetimeEffect(id: 1933, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001933.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__23$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk50");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk50 : TriggerState {
            internal StateEpilogue5Talk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk51(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk51 : TriggerState {
            internal StateEpilogue5Talk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {51006, 51007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__24$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk52");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk52(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk52 : TriggerState {
            internal StateEpilogue5Talk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk53(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk53 : TriggerState {
            internal StateEpilogue5Talk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1934, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001934.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE5MOVIE__25$", arg4: 8);
                context.SetSkip(arg1: "Epilogue5Talk54");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEpilogue5Talk54(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk54 : TriggerState {
            internal StateEpilogue5Talk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk55(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk55 : TriggerState {
            internal StateEpilogue5Talk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: true,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.CameraSelectPath(arg1: new[] {53013, 53014}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE5MOVIE__26$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk56");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEpilogue5Talk56(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk56 : TriggerState {
            internal StateEpilogue5Talk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100275, enable: false,
                    path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk57(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk57 : TriggerState {
            internal StateEpilogue5Talk57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1400}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__27$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk58");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk58(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk58 : TriggerState {
            internal StateEpilogue5Talk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 5300, arg2: "MS2PatrolData_bellaOUT");
                context.SetOnetimeEffect(id: 02100282, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter5_Bella_Foosteps_01.xml");
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk59(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk59 : TriggerState {
            internal StateEpilogue5Talk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {55001, 55002}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__28$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk60");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk60(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk60 : TriggerState {
            internal StateEpilogue5Talk60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk61(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk61 : TriggerState {
            internal StateEpilogue5Talk61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {55003, 55004}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__29$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk62");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk62(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk62 : TriggerState {
            internal StateEpilogue5Talk62(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetOnetimeEffect(id: 10, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk63(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk63 : TriggerState {
            internal StateEpilogue5Talk63(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 10, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {55005, 55006}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__30$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk64");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateEpilogue5Talk64(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk64 : TriggerState {
            internal StateEpilogue5Talk64(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetOnetimeEffect(id: 02100282, enable: false,
                    path: @"BG/Common/Sound/Eff_System_Chapter5_Bella_Foosteps_01.xml");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk65(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk65 : TriggerState {
            internal StateEpilogue5Talk65(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {55007}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE5MOVIE__31$", arg4: 5);
                context.SetSkip(arg1: "Epilogue5Talk66");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk66(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk66 : TriggerState {
            internal StateEpilogue5Talk66(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue5Talk67(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk67 : TriggerState {
            internal StateEpilogue5Talk67(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue5Talk68(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue5Talk68 : TriggerState {
            internal StateEpilogue5Talk68(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 02000065, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}