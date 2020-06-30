using System;

namespace Maple2.Trigger._52000035_qd {
    public static class _epilogue4movie {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State한라봉에이드검사1(context);

        private class State한라봉에이드검사1 : TriggerState {
            internal State한라봉에이드검사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {6000}, arg2: new int[] {50001677},
                    arg3: new byte[] {2})) {
                    context.State = new StateReturnMapReadyEP6(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {6000}, arg2: new int[] {50001677},
                    arg3: new byte[] {2})) {
                    context.State = new State한라봉에이드검사2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State한라봉에이드검사2 : TriggerState {
            internal State한라봉에이드검사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {5000}, arg2: new int[] {50001625},
                    arg3: new byte[] {2})) {
                    context.State = new StateReturnMapReadyEP5(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {5000}, arg2: new int[] {50001625},
                    arg3: new byte[] {2})) {
                    context.State = new State한라봉에이드검사3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State한라봉에이드검사3 : TriggerState {
            internal State한라봉에이드검사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {4000}, arg2: new int[] {50001613},
                    arg3: new byte[] {2})) {
                    context.State = new StateReturnMapReadyEP4(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {4000}, arg2: new int[] {50001613},
                    arg3: new byte[] {2})) {
                    context.State = new StateStartCheckEP6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6 : TriggerState {
            internal StateReturnMapReadyEP6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateReturnMapReadyEP6_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6_1 : TriggerState {
            internal StateReturnMapReadyEP6_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 9, arg2: "$52000035_QD__EPILOGUE4MOVIE__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReturnMapReadyEP6_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6_2 : TriggerState {
            internal StateReturnMapReadyEP6_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000154, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5 : TriggerState {
            internal StateReturnMapReadyEP5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateReturnMapReadyEP5_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5_1 : TriggerState {
            internal StateReturnMapReadyEP5_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 9, arg2: "$52000035_QD__EPILOGUE4MOVIE__1$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReturnMapReadyEP5_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5_2 : TriggerState {
            internal StateReturnMapReadyEP5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000065, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4 : TriggerState {
            internal StateReturnMapReadyEP4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateReturnMapReadyEP4_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4_1 : TriggerState {
            internal StateReturnMapReadyEP4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 9, arg2: "$52000035_QD__EPILOGUE4MOVIE__2$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReturnMapReadyEP4_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4_2 : TriggerState {
            internal StateReturnMapReadyEP4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000001, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateStartCheckEP6 : TriggerState {
            internal StateStartCheckEP6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {6000}, arg2: new int[] {50001677},
                    arg3: new byte[] {3})) {
                    context.State = new State3번으로보내는스테이트(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {6000}, arg2: new int[] {50001677},
                    arg3: new byte[] {3})) {
                    context.State = new StateStartCheckEP5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartCheckEP5 : TriggerState {
            internal StateStartCheckEP5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {5000}, arg2: new int[] {50001625},
                    arg3: new byte[] {3})) {
                    context.State = new State2번으로보내는스테이트(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {5000}, arg2: new int[] {50001625},
                    arg3: new byte[] {3})) {
                    context.State = new StateStartCheckEP4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartCheckEP4 : TriggerState {
            internal StateStartCheckEP4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {4000}, arg2: new int[] {50001613},
                    arg3: new byte[] {3})) {
                    context.State = new StateLoadingDelayA0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번으로보내는스테이트 : TriggerState {
            internal State2번으로보내는스테이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 2, key: "50001625", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State3번으로보내는스테이트 : TriggerState {
            internal State3번으로보내는스테이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 3, key: "50001677", value: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateLoadingDelayA0 : TriggerState {
            internal StateLoadingDelayA0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Quit", arg2: "exit");
                context.SetOnetimeEffect(id: 11100104, enable: true,
                    path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new int[] {900}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CreateMonster(arg1: new int[] {300}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLoadingDelayA1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayA1 : TriggerState {
            internal StateLoadingDelayA1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_EP4_Turka");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_EP4_Madria");
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_EP4_bella");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffectA0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA0 : TriggerState {
            internal StateCameraEffectA0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_EP4_Turka");
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_EP4_Madria");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffectA1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA1 : TriggerState {
            internal StateCameraEffectA1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000035_QD__EPILOGUE4MOVIE__3$", arg3: false);
                context.CameraSelectPath(arg1: new int[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009},
                    arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffectA2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA2 : TriggerState {
            internal StateCameraEffectA2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateCameraEffect1100(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1100 : TriggerState {
            internal StateCameraEffect1100(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect1101(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1101 : TriggerState {
            internal StateCameraEffect1101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 02100276, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter4_ZoomIn_01.xml");
                context.CameraSelectPath(arg1: new int[] {1100, 1101, 1104}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateCameraEffect_1103(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1103 : TriggerState {
            internal StateCameraEffect_1103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect_1104(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1104 : TriggerState {
            internal StateCameraEffect_1104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 02100277, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter4_DarkWizard_Appear_01.xml");
                context.CameraSelectPath(arg1: new int[] {1103, 1102, 1105}, arg2: 0);
                context.SetNpcEmotionSequence(arg1: 900, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect_1105(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1105 : TriggerState {
            internal StateCameraEffect_1105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffect_1106(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1106 : TriggerState {
            internal StateCameraEffect_1106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffectA3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA3 : TriggerState {
            internal StateCameraEffectA3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.CameraSelectPath(arg1: new int[] {1200, 1201}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__4$", arg4: 7);
                context.SetSkip(arg1: "Epilogue4Talk1");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue4Talk1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk1 : TriggerState {
            internal StateEpilogue4Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk2 : TriggerState {
            internal StateEpilogue4Talk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1300}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__5$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk3");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk3 : TriggerState {
            internal StateEpilogue4Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk4 : TriggerState {
            internal StateEpilogue4Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__6$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk5");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk5 : TriggerState {
            internal StateEpilogue4Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk6 : TriggerState {
            internal StateEpilogue4Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1915, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001915.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__7$", arg4: 6);
                context.SetSkip(arg1: "Epilogue4Talk7");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateEpilogue4Talk7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk7 : TriggerState {
            internal StateEpilogue4Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk8 : TriggerState {
            internal StateEpilogue4Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2100, 2101}, arg2: 0);
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_EP4_DarkToTurka");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__8$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk9");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk9 : TriggerState {
            internal StateEpilogue4Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk10 : TriggerState {
            internal StateEpilogue4Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__9$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk11");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk11 : TriggerState {
            internal StateEpilogue4Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12 : TriggerState {
            internal StateEpilogue4Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__10$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk12B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk12B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12B : TriggerState {
            internal StateEpilogue4Talk12B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk12C(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12C : TriggerState {
            internal StateEpilogue4Talk12C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_TurkaToDark");
                context.CameraSelectPath(arg1: new int[] {2102, 2103}, arg2: 0);
                context.SetOnetimeEffect(id: 1916, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001916.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__11$", arg4: 13);
                context.SetSkip(arg1: "Epilogue4Talk13");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    context.State = new StateEpilogue4Talk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk13 : TriggerState {
            internal StateEpilogue4Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateDM_AttScene01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene01 : TriggerState {
            internal StateDM_AttScene01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2000, 2001}, arg2: 0);
                context.SetOnetimeEffect(id: 02100278, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter4_DarkWizard_Attack_01.xml");
                context.SetNpcEmotionSequence(arg1: 900, arg2: "Attack_01_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDM_AttScene02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene02 : TriggerState {
            internal StateDM_AttScene02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
                context.SetOnetimeEffect(id: 1917, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001917.xml");
                context.MoveNpc(arg1: 102, arg2: "MS2PatrolData_darkReturn");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_TurkaReturn");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDM_AttScene03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene03 : TriggerState {
            internal StateDM_AttScene03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 102, arg2: "Damg_A");
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Damg_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateDM_AttScene04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene04 : TriggerState {
            internal StateDM_AttScene04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {2002, 2003}, arg2: 0);
                context.SetTimeScale(enable: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateEpilogue4Talk14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk14 : TriggerState {
            internal StateEpilogue4Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1501}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__12$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk15");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk15 : TriggerState {
            internal StateEpilogue4Talk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk16 : TriggerState {
            internal StateEpilogue4Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1200}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__38$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk17");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEpilogue4Talk17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk17 : TriggerState {
            internal StateEpilogue4Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk18 : TriggerState {
            internal StateEpilogue4Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1300}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__13$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk19");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEpilogue4Talk19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk19 : TriggerState {
            internal StateEpilogue4Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk20 : TriggerState {
            internal StateEpilogue4Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1500}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__14$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk21");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk21 : TriggerState {
            internal StateEpilogue4Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk22 : TriggerState {
            internal StateEpilogue4Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {3000, 3001}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__15$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk23");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk23 : TriggerState {
            internal StateEpilogue4Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk24 : TriggerState {
            internal StateEpilogue4Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__16$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk25");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk25 : TriggerState {
            internal StateEpilogue4Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk26 : TriggerState {
            internal StateEpilogue4Talk26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__17$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk27");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27 : TriggerState {
            internal StateEpilogue4Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk27A(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27A : TriggerState {
            internal StateEpilogue4Talk27A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1203}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__39$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk27B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk27B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27B : TriggerState {
            internal StateEpilogue4Talk27B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk28 : TriggerState {
            internal StateEpilogue4Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1502, 1504}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__18$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk29");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk29 : TriggerState {
            internal StateEpilogue4Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk30 : TriggerState {
            internal StateEpilogue4Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1400, 1406}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__19$", arg4: 8);
                context.SetOnetimeEffect(id: 1978, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_01_00001978.xml");
                context.SetSkip(arg1: "Epilogue4Talk31");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEpilogue4Talk31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk31 : TriggerState {
            internal StateEpilogue4Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk32 : TriggerState {
            internal StateEpilogue4Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1401}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__20$", arg4: 6);
                context.SetOnetimeEffect(id: 1979, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_02_00001979.xml");
                context.SetSkip(arg1: "Epilogue4Talk33");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateEpilogue4Talk33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk33 : TriggerState {
            internal StateEpilogue4Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk34(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk34 : TriggerState {
            internal StateEpilogue4Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1505, 1506}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__21$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk35");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk35(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk35 : TriggerState {
            internal StateEpilogue4Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk36(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk36 : TriggerState {
            internal StateEpilogue4Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100279, enable: true,
                    path: @"BG/Common/Sound/Eff_System_Chapter4_ZoomOut_01.xml");
                context.CameraSelectPath(arg1: new int[] {1403}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__22$", arg4: 5);
                context.SetOnetimeEffect(id: 1980, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_03_00001980.xml");
                context.SetSkip(arg1: "Epilogue4Talk37");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk37(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk37 : TriggerState {
            internal StateEpilogue4Talk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk38(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk38 : TriggerState {
            internal StateEpilogue4Talk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1500, 1503}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__23$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk39");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk39(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk39 : TriggerState {
            internal StateEpilogue4Talk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk40(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk40 : TriggerState {
            internal StateEpilogue4Talk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1407}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__24$", arg4: 7);
                context.SetOnetimeEffect(id: 1981, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_04_00001981.xml");
                context.SetSkip(arg1: "Epilogue4Talk41");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateEpilogue4Talk41(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk41 : TriggerState {
            internal StateEpilogue4Talk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk42 : TriggerState {
            internal StateEpilogue4Talk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1401}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__25$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk43");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk43(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk43 : TriggerState {
            internal StateEpilogue4Talk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk44(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk44 : TriggerState {
            internal StateEpilogue4Talk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1402}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001955, arg3: "$52000035_QD__EPILOGUE4MOVIE__26$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk45");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk45(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk45 : TriggerState {
            internal StateEpilogue4Talk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk46(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk46 : TriggerState {
            internal StateEpilogue4Talk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1404}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__27$", arg4: 5);
                context.SetOnetimeEffect(id: 1982, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_05_00001982.xml");
                context.SetSkip(arg1: "Epilogue4Talk47");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk47(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk47 : TriggerState {
            internal StateEpilogue4Talk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk48(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk48 : TriggerState {
            internal StateEpilogue4Talk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1200, 1201}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__28$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk49");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk49(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk49 : TriggerState {
            internal StateEpilogue4Talk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk50(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk50 : TriggerState {
            internal StateEpilogue4Talk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__29$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk51");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk51(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk51 : TriggerState {
            internal StateEpilogue4Talk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk52(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk52 : TriggerState {
            internal StateEpilogue4Talk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_MadToDark");
                context.CameraSelectPath(arg1: new int[] {1405}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001851, arg3: "$52000035_QD__EPILOGUE4MOVIE__30$", arg4: 5);
                context.SetOnetimeEffect(id: 1983, enable: true,
                    path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_06_00001983.xml");
                context.SetSkip(arg1: "Epilogue4Talk53");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk53(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk53 : TriggerState {
            internal StateEpilogue4Talk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk54(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk54 : TriggerState {
            internal StateEpilogue4Talk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1202}, arg2: 0);
                context.MoveNpc(arg1: 300, arg2: "MS2PatrolData_madriaReturn");
                context.SetConversation(arg1: 2, arg2: 11001957, arg3: "$52000035_QD__EPILOGUE4MOVIE__31$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk55");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk55(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk55 : TriggerState {
            internal StateEpilogue4Talk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk56(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk56 : TriggerState {
            internal StateEpilogue4Talk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1100, 1101, 1104}, arg2: 0);
                context.SetOnetimeEffect(id: 1918, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001918.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__32$", arg4: 12);
                context.SetSkip(arg1: "Epilogue4Talk58");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    context.State = new StateEpilogue4Talk58(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk58 : TriggerState {
            internal StateEpilogue4Talk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk59(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk59 : TriggerState {
            internal StateEpilogue4Talk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_EP4_bella_go");
                context.CameraSelectPath(arg1: new int[] {1600, 1601}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE4MOVIE__33$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk60");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateEpilogue4Talk60(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk60 : TriggerState {
            internal StateEpilogue4Talk60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk61(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk61 : TriggerState {
            internal StateEpilogue4Talk61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1300, 1301}, arg2: 0);
                context.SetOnetimeEffect(id: 1919, enable: true,
                    path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001919.xml");
                context.SetConversation(arg1: 2, arg2: 11001956, arg3: "$52000035_QD__EPILOGUE4MOVIE__34$", arg4: 8);
                context.SetSkip(arg1: "Epilogue4Talk62");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEpilogue4Talk62(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk62 : TriggerState {
            internal StateEpilogue4Talk62(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk63(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk63 : TriggerState {
            internal StateEpilogue4Talk63(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1602}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE4MOVIE__35$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk64");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk64(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk64 : TriggerState {
            internal StateEpilogue4Talk64(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk65(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk65 : TriggerState {
            internal StateEpilogue4Talk65(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1603, 1604}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE4MOVIE__36$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk66");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk66(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk66 : TriggerState {
            internal StateEpilogue4Talk66(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk67(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk67 : TriggerState {
            internal StateEpilogue4Talk67(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1605, 1606}, arg2: 0);
                context.SetConversation(arg1: 2, arg2: 11001852, arg3: "$52000035_QD__EPILOGUE4MOVIE__37$", arg4: 5);
                context.SetSkip(arg1: "Epilogue4Talk68");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateEpilogue4Talk68(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk68 : TriggerState {
            internal StateEpilogue4Talk68(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateEpilogue4Talk69(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk69 : TriggerState {
            internal StateEpilogue4Talk69(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEpilogue4Talk70(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk70 : TriggerState {
            internal StateEpilogue4Talk70(ITriggerContext context) : base(context) { }

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
                context.MoveUser(arg1: 02000001, arg2: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}