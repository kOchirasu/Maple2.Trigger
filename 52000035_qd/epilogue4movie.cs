namespace Maple2.Trigger._52000035_qd {
    public static class _epilogue4movie {
        public class State한라봉에이드검사1 : TriggerState {
            internal State한라봉에이드검사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{2})) {
                    return new StateReturnMapReadyEP6(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{2})) {
                    return new State한라봉에이드검사2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한라봉에이드검사2 : TriggerState {
            internal State한라봉에이드검사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{2})) {
                    return new StateReturnMapReadyEP5(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{2})) {
                    return new State한라봉에이드검사3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State한라봉에이드검사3 : TriggerState {
            internal State한라봉에이드검사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{4000}, questIds: new []{50001613}, questStates: new byte[]{2})) {
                    return new StateReturnMapReadyEP4(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{4000}, questIds: new []{50001613}, questStates: new byte[]{2})) {
                    return new StateStartCheckEP6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6 : TriggerState {
            internal StateReturnMapReadyEP6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateReturnMapReadyEP6_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6_1 : TriggerState {
            internal StateReturnMapReadyEP6_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE4MOVIE__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReturnMapReadyEP6_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP6_2 : TriggerState {
            internal StateReturnMapReadyEP6_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000154, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5 : TriggerState {
            internal StateReturnMapReadyEP5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateReturnMapReadyEP5_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5_1 : TriggerState {
            internal StateReturnMapReadyEP5_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE4MOVIE__1$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReturnMapReadyEP5_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP5_2 : TriggerState {
            internal StateReturnMapReadyEP5_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000065, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4 : TriggerState {
            internal StateReturnMapReadyEP4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateReturnMapReadyEP4_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4_1 : TriggerState {
            internal StateReturnMapReadyEP4_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE4MOVIE__2$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReturnMapReadyEP4_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReadyEP4_2 : TriggerState {
            internal StateReturnMapReadyEP4_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000001, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCheckEP6 : TriggerState {
            internal StateStartCheckEP6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{3})) {
                    return new State3번으로보내는스테이트(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{6000}, questIds: new []{50001677}, questStates: new byte[]{3})) {
                    return new StateStartCheckEP5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCheckEP5 : TriggerState {
            internal StateStartCheckEP5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{3})) {
                    return new State2번으로보내는스테이트(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{5000}, questIds: new []{50001625}, questStates: new byte[]{3})) {
                    return new StateStartCheckEP4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartCheckEP4 : TriggerState {
            internal StateStartCheckEP4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{4000}, questIds: new []{50001613}, questStates: new byte[]{3})) {
                    return new StateLoadingDelayA0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2번으로보내는스테이트 : TriggerState {
            internal State2번으로보내는스테이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "50001625", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State3번으로보내는스테이트 : TriggerState {
            internal State3번으로보내는스테이트(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "50001677", value: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayA0 : TriggerState {
            internal StateLoadingDelayA0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
                context.SetOnetimeEffect(id: 11100104, enabled: true, path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{900, 102, 200, 300}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLoadingDelayA1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayA1 : TriggerState {
            internal StateLoadingDelayA1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_EP4_Turka");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_EP4_Madria");
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_EP4_bella");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffectA0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA0 : TriggerState {
            internal StateCameraEffectA0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkLord");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_EP4_Turka");
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_EP4_Madria");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffectA1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA1 : TriggerState {
            internal StateCameraEffectA1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000035_QD__EPILOGUE4MOVIE__3$", arg3: false);
                context.CameraSelectPath(pathIds: new []{1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffectA2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA2 : TriggerState {
            internal StateCameraEffectA2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateCameraEffect1100(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1100 : TriggerState {
            internal StateCameraEffect1100(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect1101(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect1101 : TriggerState {
            internal StateCameraEffect1101(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 02100276, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter4_ZoomIn_01.xml");
                context.CameraSelectPath(pathIds: new []{1100, 1101, 1104}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraEffect_1103(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1103 : TriggerState {
            internal StateCameraEffect_1103(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect_1104(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1104 : TriggerState {
            internal StateCameraEffect_1104(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 02100277, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter4_DarkWizard_Appear_01.xml");
                context.CameraSelectPath(pathIds: new []{1103, 1102, 1105}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 900, sequenceName: "Bore_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCameraEffect_1105(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1105 : TriggerState {
            internal StateCameraEffect_1105(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffect_1106(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect_1106 : TriggerState {
            internal StateCameraEffect_1106(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffectA3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffectA3 : TriggerState {
            internal StateCameraEffectA3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.CameraSelectPath(pathIds: new []{1200, 1201}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__4$", arg4: 7);
                context.SetSkip(state: new StateEpilogue4Talk1(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue4Talk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk1 : TriggerState {
            internal StateEpilogue4Talk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk2(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk2 : TriggerState {
            internal StateEpilogue4Talk2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1300}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__5$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk3(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk3 : TriggerState {
            internal StateEpilogue4Talk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk4(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk4 : TriggerState {
            internal StateEpilogue4Talk4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__6$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk5(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk5 : TriggerState {
            internal StateEpilogue4Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk6(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk6 : TriggerState {
            internal StateEpilogue4Talk6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1915, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001915.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__7$", arg4: 6);
                context.SetSkip(state: new StateEpilogue4Talk7(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue4Talk7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk7 : TriggerState {
            internal StateEpilogue4Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk8(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk8 : TriggerState {
            internal StateEpilogue4Talk8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2100, 2101}, returnView: false);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_EP4_DarkToTurka");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__8$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk9(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk9(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk9 : TriggerState {
            internal StateEpilogue4Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk10(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk10 : TriggerState {
            internal StateEpilogue4Talk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__9$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk11(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk11 : TriggerState {
            internal StateEpilogue4Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk12(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12 : TriggerState {
            internal StateEpilogue4Talk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__10$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk12B(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk12B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12B : TriggerState {
            internal StateEpilogue4Talk12B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk12C(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk12C : TriggerState {
            internal StateEpilogue4Talk12C(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_TurkaToDark");
                context.CameraSelectPath(pathIds: new []{2102, 2103}, returnView: false);
                context.SetOnetimeEffect(id: 1916, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001916.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__11$", arg4: 13);
                context.SetSkip(state: new StateEpilogue4Talk13(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateEpilogue4Talk13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk13 : TriggerState {
            internal StateEpilogue4Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateDM_AttScene01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene01 : TriggerState {
            internal StateDM_AttScene01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2000, 2001}, returnView: false);
                context.SetOnetimeEffect(id: 02100278, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter4_DarkWizard_Attack_01.xml");
                context.SetNpcEmotionSequence(spawnId: 900, sequenceName: "Attack_01_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDM_AttScene02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene02 : TriggerState {
            internal StateDM_AttScene02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
                context.SetOnetimeEffect(id: 1917, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001917.xml");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_darkReturn");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_TurkaReturn");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDM_AttScene03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene03 : TriggerState {
            internal StateDM_AttScene03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 102, sequenceName: "Damg_A");
                context.SetNpcEmotionSequence(spawnId: 200, sequenceName: "Damg_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateDM_AttScene04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDM_AttScene04 : TriggerState {
            internal StateDM_AttScene04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{2002, 2003}, returnView: false);
                context.SetTimeScale(enabled: true, startScale: 1f, endScale: 0.1f, duration: 2.5f, interpolator: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEpilogue4Talk14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk14 : TriggerState {
            internal StateEpilogue4Talk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1501}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__12$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk15(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk15 : TriggerState {
            internal StateEpilogue4Talk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk16(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk16 : TriggerState {
            internal StateEpilogue4Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1200}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__38$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk17(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEpilogue4Talk17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk17 : TriggerState {
            internal StateEpilogue4Talk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk18(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk18 : TriggerState {
            internal StateEpilogue4Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1300}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__13$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk19(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEpilogue4Talk19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk19 : TriggerState {
            internal StateEpilogue4Talk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk20(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk20 : TriggerState {
            internal StateEpilogue4Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1500}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__14$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk21(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk21 : TriggerState {
            internal StateEpilogue4Talk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk22(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk22 : TriggerState {
            internal StateEpilogue4Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__15$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk23(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk23(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk23 : TriggerState {
            internal StateEpilogue4Talk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk24(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk24 : TriggerState {
            internal StateEpilogue4Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__16$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk25(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk25(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk25 : TriggerState {
            internal StateEpilogue4Talk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk26(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk26 : TriggerState {
            internal StateEpilogue4Talk26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__17$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk27(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk27(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27 : TriggerState {
            internal StateEpilogue4Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk27A(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27A : TriggerState {
            internal StateEpilogue4Talk27A(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1203}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__39$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk27B(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk27B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk27B : TriggerState {
            internal StateEpilogue4Talk27B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk28(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk28 : TriggerState {
            internal StateEpilogue4Talk28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1502, 1504}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__18$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk29(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk29(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk29 : TriggerState {
            internal StateEpilogue4Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk30(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk30 : TriggerState {
            internal StateEpilogue4Talk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1400, 1406}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__19$", arg4: 8);
                context.SetOnetimeEffect(id: 1978, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_01_00001978.xml");
                context.SetSkip(state: new StateEpilogue4Talk31(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue4Talk31(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk31 : TriggerState {
            internal StateEpilogue4Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk32(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk32 : TriggerState {
            internal StateEpilogue4Talk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1401}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__20$", arg4: 6);
                context.SetOnetimeEffect(id: 1979, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_02_00001979.xml");
                context.SetSkip(state: new StateEpilogue4Talk33(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue4Talk33(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk33 : TriggerState {
            internal StateEpilogue4Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk34(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk34 : TriggerState {
            internal StateEpilogue4Talk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1505, 1506}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__21$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk35(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk35(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk35 : TriggerState {
            internal StateEpilogue4Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk36(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk36 : TriggerState {
            internal StateEpilogue4Talk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 02100279, enabled: true, path: @"BG/Common/Sound/Eff_System_Chapter4_ZoomOut_01.xml");
                context.CameraSelectPath(pathIds: new []{1403}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__22$", arg4: 5);
                context.SetOnetimeEffect(id: 1980, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_03_00001980.xml");
                context.SetSkip(state: new StateEpilogue4Talk37(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk37(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk37 : TriggerState {
            internal StateEpilogue4Talk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk38(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk38 : TriggerState {
            internal StateEpilogue4Talk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1500, 1503}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__23$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk39(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk39(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk39 : TriggerState {
            internal StateEpilogue4Talk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk40(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk40 : TriggerState {
            internal StateEpilogue4Talk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1407}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__24$", arg4: 7);
                context.SetOnetimeEffect(id: 1981, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_04_00001981.xml");
                context.SetSkip(state: new StateEpilogue4Talk41(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateEpilogue4Talk41(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk41 : TriggerState {
            internal StateEpilogue4Talk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk42(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk42 : TriggerState {
            internal StateEpilogue4Talk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1401}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__25$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk43(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk43(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk43 : TriggerState {
            internal StateEpilogue4Talk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk44(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk44 : TriggerState {
            internal StateEpilogue4Talk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1402}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000035_QD__EPILOGUE4MOVIE__26$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk45(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk45(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk45 : TriggerState {
            internal StateEpilogue4Talk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk46(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk46 : TriggerState {
            internal StateEpilogue4Talk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1404}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__27$", arg4: 5);
                context.SetOnetimeEffect(id: 1982, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_05_00001982.xml");
                context.SetSkip(state: new StateEpilogue4Talk47(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk47(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk47 : TriggerState {
            internal StateEpilogue4Talk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk48(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk48 : TriggerState {
            internal StateEpilogue4Talk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1200, 1201}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__28$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk49(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk49(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk49 : TriggerState {
            internal StateEpilogue4Talk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk50(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk50 : TriggerState {
            internal StateEpilogue4Talk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__29$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk51(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk51(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk51 : TriggerState {
            internal StateEpilogue4Talk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk52(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk52 : TriggerState {
            internal StateEpilogue4Talk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_MadToDark");
                context.CameraSelectPath(pathIds: new []{1405}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000035_QD__EPILOGUE4MOVIE__30$", arg4: 5);
                context.SetOnetimeEffect(id: 1983, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter4_End_06_00001983.xml");
                context.SetSkip(state: new StateEpilogue4Talk53(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk53(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk53 : TriggerState {
            internal StateEpilogue4Talk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk54(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk54 : TriggerState {
            internal StateEpilogue4Talk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1202}, returnView: false);
                context.MoveNpc(spawnId: 300, patrolName: "MS2PatrolData_madriaReturn");
                context.SetConversation(type: 2, spawnId: 11001957, script: "$52000035_QD__EPILOGUE4MOVIE__31$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk55(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk55(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk55 : TriggerState {
            internal StateEpilogue4Talk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk56(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk56 : TriggerState {
            internal StateEpilogue4Talk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1100, 1101, 1104}, returnView: false);
                context.SetOnetimeEffect(id: 1918, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001918.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__32$", arg4: 12);
                context.SetSkip(state: new StateEpilogue4Talk58(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateEpilogue4Talk58(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk58 : TriggerState {
            internal StateEpilogue4Talk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk59(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk59 : TriggerState {
            internal StateEpilogue4Talk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{400}, arg2: false);
                context.MoveNpc(spawnId: 400, patrolName: "MS2PatrolData_EP4_bella_go");
                context.CameraSelectPath(pathIds: new []{1600, 1601}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE4MOVIE__33$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk60(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateEpilogue4Talk60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk60 : TriggerState {
            internal StateEpilogue4Talk60(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk61(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk61 : TriggerState {
            internal StateEpilogue4Talk61(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1300, 1301}, returnView: false);
                context.SetOnetimeEffect(id: 1919, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000035_Turka_00001919.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000035_QD__EPILOGUE4MOVIE__34$", arg4: 8);
                context.SetSkip(state: new StateEpilogue4Talk62(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue4Talk62(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk62 : TriggerState {
            internal StateEpilogue4Talk62(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk63(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk63 : TriggerState {
            internal StateEpilogue4Talk63(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1602}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE4MOVIE__35$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk64(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk64(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk64 : TriggerState {
            internal StateEpilogue4Talk64(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk65(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk65 : TriggerState {
            internal StateEpilogue4Talk65(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1603, 1604}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE4MOVIE__36$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk66(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk66(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk66 : TriggerState {
            internal StateEpilogue4Talk66(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk67(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk67 : TriggerState {
            internal StateEpilogue4Talk67(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1605, 1606}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001852, script: "$52000035_QD__EPILOGUE4MOVIE__37$", arg4: 5);
                context.SetSkip(state: new StateEpilogue4Talk68(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateEpilogue4Talk68(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk68 : TriggerState {
            internal StateEpilogue4Talk68(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue4Talk69(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk69 : TriggerState {
            internal StateEpilogue4Talk69(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEpilogue4Talk70(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEpilogue4Talk70 : TriggerState {
            internal StateEpilogue4Talk70(ITriggerContext context) : base(context) { }

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
                context.MoveUser(mapId: 02000001, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
