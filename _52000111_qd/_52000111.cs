namespace Maple2.Trigger._52000111_qd {
    public static class _52000111 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10011})) {
                    return new StateSTART(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002315}, arg3: new byte[] {2})) {
                    return new State어쌔신탈출02(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002313}, arg3: new byte[] {2})) {
                    return new StatePC대탈출01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002313}, arg3: new byte[] {3})) {
                    return new StatePC대탈출01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002314}, arg3: new byte[] {2})) {
                    return new StatePC대탈출01(context);
                }

                if (!context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002313}, arg3: new byte[] {2})) {
                    return new StateWait(context);
                }

                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002312}, arg3: new byte[] {3})) {
                    return new StatePC대탈출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10011})) {
                    return new State영상준비_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000111, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Assassin.usm", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State커닝시티전경씬01(context);
                }

                if (context.WaitTick(waitTick: 55000)) {
                    return new State커닝시티전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01 : TriggerState {
            internal State커닝시티전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {1000, 1001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State커닝시티전경씬01_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01_B : TriggerState {
            internal State커닝시티전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1002, 1003}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State커닝시티전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬02 : TriggerState {
            internal State커닝시티전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1004, 1005}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State커닝시티전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬03 : TriggerState {
            internal State커닝시티전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000111_QD__52000111__0$", desc: "$52000111_QD__52000111__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State커닝시티전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬04 : TriggerState {
            internal State커닝시티전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01_1 : TriggerState {
            internal StateQuit01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, arg2: true);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000111_QD__52000111__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201111, textId: 25201111, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {10012})) {
                    return new State쉐도우클로Appear씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬01 : TriggerState {
            internal State쉐도우클로Appear씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9000, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도우클로Appear씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬02 : TriggerState {
            internal State쉐도우클로Appear씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_pcFront");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000111_QD__52000111__3$", duration: 6000, delayTick: 1000);
                context.SetPcEmotionLoop(arg1: "Assassin_Bore_A", arg2: 25000f);
                context.CameraSelectPath(arg1: new[] {1006, 1007}, arg2: false);
                context.MoveUser(arg1: 52000111, arg2: 10);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로Appear씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬04 : TriggerState {
            internal State쉐도우클로Appear씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Assassin_Bore_A");
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000111_QD__52000111__4$", duration: 6000, delayTick: 1000);
                context.CameraSelectPath(arg1: new[] {1012, 1013}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로Appear씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬05 : TriggerState {
            internal State쉐도우클로Appear씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, arg2: true);
                context.CameraSelectPath(arg1: new[] {1014, 1015}, arg2: false);
                context.SpawnNpcRange(rangeId: new[] {202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, isAutoTargeting: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State쉐도우클로Appear씬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬06 : TriggerState {
            internal State쉐도우클로Appear씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8010}, arg2: true);
                context.CreateMonster(arg1: new[] {200}, arg2: false);
                context.CameraSelectPath(arg1: new[] {1016, 1017}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도우클로Appear씬07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬07 : TriggerState {
            internal State쉐도우클로Appear씬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Sit_Down_A", arg3: 4000f);
                context.CameraSelectPath(arg1: new[] {1018, 1019}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State쉐도우클로Appear씬09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬09 : TriggerState {
            internal State쉐도우클로Appear씬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Bore_A");
                context.CameraSelectPath(arg1: new[] {1020, 1021}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도우클로Appear씬11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬11 : TriggerState {
            internal State쉐도우클로Appear씬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1022, 1023}, arg2: false);
                context.ShowCaption(type: "NameCaption", title: "$52000111_QD__52000111__5$", desc: "$52000111_QD__52000111__6$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State쉐도우클로Appear씬11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬11_1 : TriggerState {
            internal State쉐도우클로Appear씬11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로Appear씬12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_pcFront");
                context.MoveUser(arg1: 52000111, arg2: 10);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, arg2: false);
                context.SetEffect(arg1: new[] {8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, arg2: true);
                context.SpawnNpcRange(rangeId: new[] {202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, isAutoTargeting: false);
                context.DestroyMonster(arg1: new[] {200});
                context.CreateMonster(arg1: new[] {200}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로Appear씬12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Appear씬12 : TriggerState {
            internal State쉐도우클로Appear씬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new[] {8010}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(arg1: new[] {5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5312, 5313, 5314}, arg2: false);
                context.DestroyMonster(arg1: new[] {200});
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.ShowGuideSummary(entityId: 25201112, textId: 25201112, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002306}, arg3: new byte[] {1})) {
                    return new State쉐도우클로와떠남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로와떠남01 : TriggerState {
            internal State쉐도우클로와떠남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.ShowGuideSummary(entityId: 25201113, textId: 25201113, duration: 5000);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출01 : TriggerState {
            internal StatePC대탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9001, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {300, 301, 302}, arg2: false);
                context.MoveUser(arg1: 52000111, arg2: 11);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePC대탈출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출02 : TriggerState {
            internal StatePC대탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1008, 1009}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 8000f);
                context.FaceEmotion(spawnPointId: 0, emotionName: "PC_Pain_86000");
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 302, arg2: "Sit_Down_A", arg3: 17500f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7800)) {
                    return new StatePC대탈출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03 : TriggerState {
            internal StatePC대탈출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_GO");
                context.CameraSelectPath(arg1: new[] {1010, 1011}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC대탈출03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03_1 : TriggerState {
            internal StatePC대탈출03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC대탈출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_GO");
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 500f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC대탈출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출04 : TriggerState {
            internal StatePC대탈출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointId: 0, msg: "$52000111_QD__52000111__7$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201114, textId: 25201114, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {10011}, arg2: new[] {20002314}, arg3: new byte[] {3})) {
                    return new State어쌔신탈출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출01 : TriggerState {
            internal State어쌔신탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신탈출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출02 : TriggerState {
            internal State어쌔신탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000113, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}