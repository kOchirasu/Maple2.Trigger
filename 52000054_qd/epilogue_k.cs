namespace Maple2.Trigger._52000054_qd {
    public static class _epilogue_k {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50001745}, questStates: new byte[]{3})) {
                    return new StateCameraEffect0(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{50001745}, questStates: new byte[]{2})) {
                    return new StateReturnMapReady0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReturnMapReady0 : TriggerState {
            internal StateReturnMapReady0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetCinematicUI(type: 9, script: "$52000054_QD__EPILOGUE_K__0$");
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
                context.MoveUser(mapId: 02000025, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect0 : TriggerState {
            internal StateCameraEffect0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuit(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CreateMonster(spawnIds: new []{1000}, arg2: false);
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{100, 101}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCameraEffect2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect2 : TriggerState {
            internal StateCameraEffect2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCityWarfareTalk1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk1 : TriggerState {
            internal StateCityWarfareTalk1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100105, enabled: true, path: @"BG/Common/Sound/Eff_AMB_BlackMoon_Abyss_01.xml");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{200}, returnView: false);
                context.SetOnetimeEffect(id: 1883, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001883.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__1$", arg4: 7);
                context.SetSkip(state: new StateCityWarfareTalk2(context));
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk3(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk3 : TriggerState {
            internal StateCityWarfareTalk3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1884, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001884.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__2$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk4(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk5(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk5 : TriggerState {
            internal StateCityWarfareTalk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_Turka");
                context.CameraSelectPath(pathIds: new []{300, 301}, returnView: false);
                context.SetOnetimeEffect(id: 1943, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001943.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__3$", arg4: 11);
                context.SetSkip(state: new StateCityWarfareTalk6(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk7(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk7 : TriggerState {
            internal StateCityWarfareTalk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{202}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1885, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001885.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__4$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk8(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk9(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk9 : TriggerState {
            internal StateCityWarfareTalk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1886, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001886.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__5$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk10(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk11(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk11 : TriggerState {
            internal StateCityWarfareTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{400, 401}, returnView: false);
                context.SetOnetimeEffect(id: 1944, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001944.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__6$", arg4: 13);
                context.SetSkip(state: new StateCityWarfareTalk12(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk13(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk13 : TriggerState {
            internal StateCityWarfareTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1945, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001945.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__7$", arg4: 8);
                context.SetSkip(state: new StateCityWarfareTalk14(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk15(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk15 : TriggerState {
            internal StateCityWarfareTalk15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{204, 205}, returnView: false);
                context.SetOnetimeEffect(id: 1887, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001887.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__8$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk16(context));
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk17(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk17 : TriggerState {
            internal StateCityWarfareTalk17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{402}, returnView: false);
                context.SetOnetimeEffect(id: 1946, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001946.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__9$", arg4: 12);
                context.SetSkip(state: new StateCityWarfareTalk18(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk19(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk19 : TriggerState {
            internal StateCityWarfareTalk19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{204}, returnView: false);
                context.SetOnetimeEffect(id: 1888, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001888.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__10$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk20(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk20 : TriggerState {
            internal StateCityWarfareTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk21(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk21 : TriggerState {
            internal StateCityWarfareTalk21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{500, 501}, returnView: false);
                context.SetOnetimeEffect(id: 1947, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001947.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__11$", arg4: 10);
                context.SetSkip(state: new StateCityWarfareTalk22(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk23(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk23 : TriggerState {
            internal StateCityWarfareTalk23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{200}, returnView: false);
                context.SetOnetimeEffect(id: 1889, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001889.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__12$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk24(context));
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk25(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk25 : TriggerState {
            internal StateCityWarfareTalk25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{403}, returnView: false);
                context.SetOnetimeEffect(id: 1948, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001948.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__13$", arg4: 8);
                context.SetSkip(state: new StateCityWarfareTalk26(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk27(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk27 : TriggerState {
            internal StateCityWarfareTalk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__14$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk28(context));
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
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk29(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk29 : TriggerState {
            internal StateCityWarfareTalk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{200}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__29$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk30(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk30(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk30 : TriggerState {
            internal StateCityWarfareTalk30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk31(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk31 : TriggerState {
            internal StateCityWarfareTalk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{404}, returnView: false);
                context.SetOnetimeEffect(id: 1949, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001949.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__15$", arg4: 11);
                context.SetSkip(state: new StateCityWarfareTalk32(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateCityWarfareTalk32(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk32 : TriggerState {
            internal StateCityWarfareTalk32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk33(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk33 : TriggerState {
            internal StateCityWarfareTalk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{408, 409}, returnView: false);
                context.SetOnetimeEffect(id: 1950, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001950.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__16$", arg4: 8);
                context.SetSkip(state: new StateCityWarfareTalk34(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateCityWarfareTalk34(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk34 : TriggerState {
            internal StateCityWarfareTalk34(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk35(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk35 : TriggerState {
            internal StateCityWarfareTalk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1890, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001890.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__17$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk36(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk36(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk36 : TriggerState {
            internal StateCityWarfareTalk36(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk37(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk37 : TriggerState {
            internal StateCityWarfareTalk37(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{502, 503}, returnView: false);
                context.SetOnetimeEffect(id: 1951, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001951.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__18$", arg4: 7);
                context.SetSkip(state: new StateCityWarfareTalk38(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCityWarfareTalk38(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk38 : TriggerState {
            internal StateCityWarfareTalk38(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk39(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk39 : TriggerState {
            internal StateCityWarfareTalk39(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1952, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001952.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__19$", arg4: 7);
                context.SetSkip(state: new StateCityWarfareTalk40(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCityWarfareTalk40(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk40 : TriggerState {
            internal StateCityWarfareTalk40(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk41(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk41 : TriggerState {
            internal StateCityWarfareTalk41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{402}, returnView: false);
                context.SetOnetimeEffect(id: 1953, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001953.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__20$", arg4: 6);
                context.SetSkip(state: new StateCityWarfareTalk42(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCityWarfareTalk42(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk42 : TriggerState {
            internal StateCityWarfareTalk42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk43(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk43 : TriggerState {
            internal StateCityWarfareTalk43(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{504, 505}, returnView: false);
                context.SetOnetimeEffect(id: 1891, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001891.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__21$", arg4: 7);
                context.SetSkip(state: new StateCityWarfareTalk44(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCityWarfareTalk44(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk44 : TriggerState {
            internal StateCityWarfareTalk44(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk45(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk45 : TriggerState {
            internal StateCityWarfareTalk45(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{405, 406}, returnView: false);
                context.SetOnetimeEffect(id: 1954, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001954.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__22$", arg4: 13);
                context.SetSkip(state: new StateCityWarfareTalk46(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new StateCityWarfareTalk46(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk46 : TriggerState {
            internal StateCityWarfareTalk46(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk47(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk47 : TriggerState {
            internal StateCityWarfareTalk47(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{206, 207}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1892, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001892.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__23$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk48(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk48(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk48 : TriggerState {
            internal StateCityWarfareTalk48(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk49(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk49 : TriggerState {
            internal StateCityWarfareTalk49(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{410, 411}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 2000, sequenceName: "Bore_B");
                context.SetOnetimeEffect(id: 1955, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001955.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__24$", arg4: 10);
                context.SetSkip(state: new StateCityWarfareTalk50(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCityWarfareTalk50(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk50 : TriggerState {
            internal StateCityWarfareTalk50(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk51(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk51 : TriggerState {
            internal StateCityWarfareTalk51(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1956, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001956.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__25$", arg4: 6);
                context.SetSkip(state: new StateCityWarfareTalk52(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCityWarfareTalk52(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk52 : TriggerState {
            internal StateCityWarfareTalk52(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk53(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk53 : TriggerState {
            internal StateCityWarfareTalk53(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{500, 501}, returnView: false);
                context.SetOnetimeEffect(id: 1957, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001957.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__26$", arg4: 10);
                context.SetSkip(state: new StateCityWarfareTalk54(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCityWarfareTalk54(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk54 : TriggerState {
            internal StateCityWarfareTalk54(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk55(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk55 : TriggerState {
            internal StateCityWarfareTalk55(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{402}, returnView: false);
                context.SetOnetimeEffect(id: 1958, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000054_Turka_00001958.xml");
                context.SetConversation(type: 2, spawnId: 11001956, script: "$52000054_QD__EPILOGUE_K__27$", arg4: 12);
                context.SetSkip(state: new StateCityWarfareTalk56(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCityWarfareTalk56(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk56 : TriggerState {
            internal StateCityWarfareTalk56(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk57(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk57 : TriggerState {
            internal StateCityWarfareTalk57(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{202, 203}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 1000, sequenceName: "Sit_Down_HeadUP");
                context.SetOnetimeEffect(id: 1893, enabled: true, path: @"BG/Common/Sound/Eff_Sound_52000055_Katvan_00001893.xml");
                context.SetConversation(type: 2, spawnId: 11001958, script: "$52000054_QD__EPILOGUE_K__28$", arg4: 5);
                context.SetSkip(state: new StateCityWarfareTalk58(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk58(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk58 : TriggerState {
            internal StateCityWarfareTalk58(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateCityWarfareTalk59(context);
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk59 : TriggerState {
            internal StateCityWarfareTalk59(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCityWarfareTalk60(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCityWarfareTalk60 : TriggerState {
            internal StateCityWarfareTalk60(ITriggerContext context) : base(context) { }

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
                context.MoveUser(mapId: 02000025, portalId: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
