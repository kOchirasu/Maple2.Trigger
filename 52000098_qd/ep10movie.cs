namespace Maple2.Trigger._52000098_qd {
    public static class _ep10movie {
        public class StateStartCinematic검사 : TriggerState {
            internal StateStartCinematic검사(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10000}, questIds: new []{20002266}, questStates: new byte[]{3})) {
                    return new StateLoadingDelayB0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLoadingDelayB0 : TriggerState {
            internal StateLoadingDelayB0(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 11100104, enabled: true, path: @"BG/Common/Sound/Eff_AMB_DarkCorridor_01.xml");
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{2000, 2001}, arg2: false);
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
                context.MoveNpc(spawnId: 2001, patrolName: "MS2PatrolData_madria");
                context.CameraSelectPath(pathIds: new []{3000, 3001}, returnView: false);
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
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{3004, 3005}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{3002, 3003}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__0$", arg4: 12);
                context.SetSkip(state: new StateEpilogue10Talk4(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk5(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk5 : TriggerState {
            internal StateEpilogue10Talk5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3006, 3007}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__1$", arg4: 9);
                context.SetOnetimeEffect(id: 1998, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_01_00001998.xml");
                context.SetSkip(state: new StateEpilogue10Talk6(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk7(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk7 : TriggerState {
            internal StateEpilogue10Talk7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__2$", arg4: 9);
                context.SetOnetimeEffect(id: 1999, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_02_00001999.xml");
                context.SetSkip(state: new StateEpilogue10Talk8(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk9(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk9 : TriggerState {
            internal StateEpilogue10Talk9(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3008, 3009}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__15$", arg4: 4);
                context.SetSkip(state: new StateEpilogue10Talk10(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk11(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk11 : TriggerState {
            internal StateEpilogue10Talk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3010, 3011}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__3$", arg4: 6);
                context.SetOnetimeEffect(id: 2000, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_03_00002000.xml");
                context.SetSkip(state: new StateEpilogue10Talk12(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk13(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk13 : TriggerState {
            internal StateEpilogue10Talk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3012, 3013}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__4$", arg4: 5);
                context.SetSkip(state: new StateEpilogue10Talk14(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk16(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk16 : TriggerState {
            internal StateEpilogue10Talk16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{53005, 53006}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__5$", arg4: 5);
                context.SetSkip(state: new StateEpilogue10Talk17(context));
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 02100275, enabled: false, path: @"BG/Common/Sound/Eff_System_DarkLord_Breathing.xml");
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk18(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk18 : TriggerState {
            internal StateEpilogue10Talk18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3014}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__6$", arg4: 7);
                context.SetSkip(state: new StateEpilogue10Talk19(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk20(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk20 : TriggerState {
            internal StateEpilogue10Talk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3015}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__7$", arg4: 5);
                context.SetSkip(state: new StateEpilogue10Talk21(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk22(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk22 : TriggerState {
            internal StateEpilogue10Talk22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3016, 3017}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__8$", arg4: 6);
                context.SetSkip(state: new StateEpilogue10Talk23(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk24(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk24 : TriggerState {
            internal StateEpilogue10Talk24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3018}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__9$", arg4: 5);
                context.SetOnetimeEffect(id: 2001, enabled: true, path: @"BG/Common/Sound/Eff_Madria_Chapter10_Start_04_00002001.xml");
                context.SetSkip(state: new StateEpilogue10Talk25(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk27(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk27 : TriggerState {
            internal StateEpilogue10Talk27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3019, 3020}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__10$", arg4: 5);
                context.SetSkip(state: new StateEpilogue10Talk28(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk29(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk29 : TriggerState {
            internal StateEpilogue10Talk29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3021, 3022}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__11$", arg4: 10);
                context.SetSkip(state: new StateEpilogue10Talk30(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk31(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk31 : TriggerState {
            internal StateEpilogue10Talk31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3023, 3024}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__12$", arg4: 10);
                context.SetSkip(state: new StateEpilogue10Talk32(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk33(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk33 : TriggerState {
            internal StateEpilogue10Talk33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3025, 3026}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001955, script: "$52000098_QD__EP10MOVIE__13$", arg4: 7);
                context.SetSkip(state: new StateEpilogue10Talk34(context));
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return new StateEpilogue10Talk35(context);
            }

            public override void OnExit() { }
        }

        private class StateEpilogue10Talk35 : TriggerState {
            internal StateEpilogue10Talk35(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{3027, 3028}, returnView: false);
                context.SetConversation(type: 2, spawnId: 11001851, script: "$52000098_QD__EP10MOVIE__14$", arg4: 12);
                context.SetSkip(state: new StateEpilogue10Talk36(context));
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeOut.xml");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 02000175, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
