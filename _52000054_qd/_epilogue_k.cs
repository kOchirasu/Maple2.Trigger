using System;

namespace Maple2.Trigger._52000054_qd {
    public static class _epilogue_k {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50001745},
                    arg3: new byte[] {3})) {
                    context.State = new StateCameraEffect0(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {50001745},
                    arg3: new byte[] {2})) {
                    context.State = new StateReturnMapReady0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady0 : TriggerState {
            internal StateReturnMapReady0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetProductionUI(arg1: 9, arg2: "$52000054_QD__EPILOGUE_K__0$");
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
                context.MoveUser(arg1: 02000025, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateCameraEffect0 : TriggerState {
            internal StateCameraEffect0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Quit", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {1000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.CameraSelectPath(arg1: new int[] {100, 101}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateCameraEffect2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect2 : TriggerState {
            internal StateCameraEffect2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCityWarfareTalk1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk1 : TriggerState {
            internal StateCityWarfareTalk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100105, enable: true,
                    path: @"BG/Common/Sound/Eff_AMB_BlackMoon_Abyss_01.xml");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {200}, arg2: 0);
                context.SetOnetimeEffect(id: 1883, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001883.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__1$", arg4: 7);
                context.SetSkip(arg1: "CityWarfareTalk2");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateCityWarfareTalk2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk2 : TriggerState {
            internal StateCityWarfareTalk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk3 : TriggerState {
            internal StateCityWarfareTalk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1884, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001884.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__2$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk4");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk4 : TriggerState {
            internal StateCityWarfareTalk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk5 : TriggerState {
            internal StateCityWarfareTalk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_Turka");
                context.CameraSelectPath(arg1: new int[] {300, 301}, arg2: 0);
                context.SetOnetimeEffect(id: 1943, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001943.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__3$", arg4: 11);
                context.SetSkip(arg1: "CityWarfareTalk6");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new StateCityWarfareTalk6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk6 : TriggerState {
            internal StateCityWarfareTalk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk7 : TriggerState {
            internal StateCityWarfareTalk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {202}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1885, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001885.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__4$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk8");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk8 : TriggerState {
            internal StateCityWarfareTalk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk9 : TriggerState {
            internal StateCityWarfareTalk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1886, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001886.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__5$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk10 : TriggerState {
            internal StateCityWarfareTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk11 : TriggerState {
            internal StateCityWarfareTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {400, 401}, arg2: 0);
                context.SetOnetimeEffect(id: 1944, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001944.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__6$", arg4: 13);
                context.SetSkip(arg1: "CityWarfareTalk12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new StateCityWarfareTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk12 : TriggerState {
            internal StateCityWarfareTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk13 : TriggerState {
            internal StateCityWarfareTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1945, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001945.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__7$", arg4: 8);
                context.SetSkip(arg1: "CityWarfareTalk14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateCityWarfareTalk14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk14 : TriggerState {
            internal StateCityWarfareTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk15 : TriggerState {
            internal StateCityWarfareTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {204, 205}, arg2: 0);
                context.SetOnetimeEffect(id: 1887, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001887.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__8$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk16");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk16 : TriggerState {
            internal StateCityWarfareTalk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk17 : TriggerState {
            internal StateCityWarfareTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {402}, arg2: 0);
                context.SetOnetimeEffect(id: 1946, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001946.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__9$", arg4: 12);
                context.SetSkip(arg1: "CityWarfareTalk18");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateCityWarfareTalk18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk18 : TriggerState {
            internal StateCityWarfareTalk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk19 : TriggerState {
            internal StateCityWarfareTalk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {204}, arg2: 0);
                context.SetOnetimeEffect(id: 1888, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001888.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__10$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk20");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk20 : TriggerState {
            internal StateCityWarfareTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk21 : TriggerState {
            internal StateCityWarfareTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {500, 501}, arg2: 0);
                context.SetOnetimeEffect(id: 1947, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001947.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__11$", arg4: 10);
                context.SetSkip(arg1: "CityWarfareTalk22");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCityWarfareTalk22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk22 : TriggerState {
            internal StateCityWarfareTalk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk23 : TriggerState {
            internal StateCityWarfareTalk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {200}, arg2: 0);
                context.SetOnetimeEffect(id: 1889, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001889.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__12$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk24");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk24 : TriggerState {
            internal StateCityWarfareTalk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk25 : TriggerState {
            internal StateCityWarfareTalk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {403}, arg2: 0);
                context.SetOnetimeEffect(id: 1948, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001948.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__13$", arg4: 8);
                context.SetSkip(arg1: "CityWarfareTalk26");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateCityWarfareTalk26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk26 : TriggerState {
            internal StateCityWarfareTalk26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk27 : TriggerState {
            internal StateCityWarfareTalk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__14$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk28");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk28 : TriggerState {
            internal StateCityWarfareTalk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk29 : TriggerState {
            internal StateCityWarfareTalk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {200}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__29$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk30");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk30 : TriggerState {
            internal StateCityWarfareTalk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk31 : TriggerState {
            internal StateCityWarfareTalk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {404}, arg2: 0);
                context.SetOnetimeEffect(id: 1949, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001949.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__15$", arg4: 11);
                context.SetSkip(arg1: "CityWarfareTalk32");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    context.State = new StateCityWarfareTalk32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk32 : TriggerState {
            internal StateCityWarfareTalk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk33 : TriggerState {
            internal StateCityWarfareTalk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {408, 409}, arg2: 0);
                context.SetOnetimeEffect(id: 1950, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001950.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__16$", arg4: 8);
                context.SetSkip(arg1: "CityWarfareTalk34");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateCityWarfareTalk34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk34 : TriggerState {
            internal StateCityWarfareTalk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk35 : TriggerState {
            internal StateCityWarfareTalk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1890, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001890.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__17$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk36");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk36 : TriggerState {
            internal StateCityWarfareTalk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk37 : TriggerState {
            internal StateCityWarfareTalk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {502, 503}, arg2: 0);
                context.SetOnetimeEffect(id: 1951, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001951.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__18$", arg4: 7);
                context.SetSkip(arg1: "CityWarfareTalk38");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateCityWarfareTalk38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk38 : TriggerState {
            internal StateCityWarfareTalk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk39 : TriggerState {
            internal StateCityWarfareTalk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1952, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001952.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__19$", arg4: 7);
                context.SetSkip(arg1: "CityWarfareTalk40");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateCityWarfareTalk40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk40 : TriggerState {
            internal StateCityWarfareTalk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk41 : TriggerState {
            internal StateCityWarfareTalk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {402}, arg2: 0);
                context.SetOnetimeEffect(id: 1953, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001953.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__20$", arg4: 6);
                context.SetSkip(arg1: "CityWarfareTalk42");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateCityWarfareTalk42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk42 : TriggerState {
            internal StateCityWarfareTalk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk43 : TriggerState {
            internal StateCityWarfareTalk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {504, 505}, arg2: 0);
                context.SetOnetimeEffect(id: 1891, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001891.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__21$", arg4: 7);
                context.SetSkip(arg1: "CityWarfareTalk44");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateCityWarfareTalk44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk44 : TriggerState {
            internal StateCityWarfareTalk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk45 : TriggerState {
            internal StateCityWarfareTalk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {405, 406}, arg2: 0);
                context.SetOnetimeEffect(id: 1954, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001954.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__22$", arg4: 13);
                context.SetSkip(arg1: "CityWarfareTalk46");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new StateCityWarfareTalk46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk46 : TriggerState {
            internal StateCityWarfareTalk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk47 : TriggerState {
            internal StateCityWarfareTalk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {206, 207}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1892, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001892.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__23$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk48");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk48 : TriggerState {
            internal StateCityWarfareTalk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk49 : TriggerState {
            internal StateCityWarfareTalk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {410, 411}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 2000, arg2: "Bore_B");
                context.SetOnetimeEffect(id: 1955, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001955.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__24$", arg4: 10);
                context.SetSkip(arg1: "CityWarfareTalk50");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCityWarfareTalk50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk50 : TriggerState {
            internal StateCityWarfareTalk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk51(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk51 : TriggerState {
            internal StateCityWarfareTalk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1956, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001956.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__25$", arg4: 6);
                context.SetSkip(arg1: "CityWarfareTalk52");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateCityWarfareTalk52(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk52 : TriggerState {
            internal StateCityWarfareTalk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk53(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk53 : TriggerState {
            internal StateCityWarfareTalk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {500, 501}, arg2: 0);
                context.SetOnetimeEffect(id: 1957, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001957.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__26$", arg4: 10);
                context.SetSkip(arg1: "CityWarfareTalk54");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCityWarfareTalk54(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk54 : TriggerState {
            internal StateCityWarfareTalk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk55(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk55 : TriggerState {
            internal StateCityWarfareTalk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {402}, arg2: 0);
                context.SetOnetimeEffect(id: 1958, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001958.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000054_QD__EPILOGUE_K__27$", arg4: 12);
                context.SetSkip(arg1: "CityWarfareTalk56");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateCityWarfareTalk56(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk56 : TriggerState {
            internal StateCityWarfareTalk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk57(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk57 : TriggerState {
            internal StateCityWarfareTalk57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {202, 203}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 1000, arg2: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1893, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001893.xml");
                context.SetConversation(arg1: 2, arg2: 11001958, arg3: "$52000054_QD__EPILOGUE_K__28$", arg4: 5);
                context.SetSkip(arg1: "CityWarfareTalk58");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk58(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk58 : TriggerState {
            internal StateCityWarfareTalk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateCityWarfareTalk59(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk59 : TriggerState {
            internal StateCityWarfareTalk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCityWarfareTalk60(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk60 : TriggerState {
            internal StateCityWarfareTalk60(ITriggerContext context) : base(context) { }

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
                context.MoveUser(arg1: 02000025, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}