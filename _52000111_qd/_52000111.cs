using System;

namespace Maple2.Trigger._52000111_qd {
    public static class _52000111 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State입장(context);

        private class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "10011")) {
                    context.State = new StateSTART(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.SetEffect(arg1: new int[] {8006}, arg2: false);
                context.SetEffect(arg1: new int[] {8007}, arg2: false);
                context.SetEffect(arg1: new int[] {8008}, arg2: false);
                context.SetEffect(arg1: new int[] {8009}, arg2: false);
                context.SetEffect(arg1: new int[] {8010}, arg2: false);
                context.SetEffect(arg1: new int[] {8011}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002315},
                    arg3: new byte[] {2})) {
                    context.State = new State어쌔신탈출02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {2})) {
                    context.State = new StatePC대탈출01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {3})) {
                    context.State = new StatePC대탈출01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002314},
                    arg3: new byte[] {2})) {
                    context.State = new StatePC대탈출01(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002313},
                    arg3: new byte[] {2})) {
                    context.State = new StateWait(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002312},
                    arg3: new byte[] {3})) {
                    context.State = new StatePC대탈출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.SetEffect(arg1: new int[] {5315}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "10011")) {
                    context.State = new State영상준비_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상준비_01 : TriggerState {
            internal State영상준비_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000111, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Assassin.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State커닝시티전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 55000)) {
                    context.State = new State커닝시티전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01 : TriggerState {
            internal State커닝시티전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {1000, 1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State커닝시티전경씬01_B(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01_B : TriggerState {
            internal State커닝시티전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1002, 1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State커닝시티전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬02 : TriggerState {
            internal State커닝시티전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1004, 1005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State커닝시티전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬03 : TriggerState {
            internal State커닝시티전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000111_QD__52000111__0$",
                    desc: "$52000111_QD__52000111__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State커닝시티전경씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬04 : TriggerState {
            internal State커닝시티전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit01_1 : TriggerState {
            internal StateQuit01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
                context.SetEffect(arg1: new int[] {5301}, arg2: true);
                context.SetEffect(arg1: new int[] {5302}, arg2: true);
                context.SetEffect(arg1: new int[] {5303}, arg2: true);
                context.SetEffect(arg1: new int[] {5304}, arg2: true);
                context.SetEffect(arg1: new int[] {5305}, arg2: true);
                context.SetEffect(arg1: new int[] {5306}, arg2: true);
                context.SetEffect(arg1: new int[] {5307}, arg2: true);
                context.SetEffect(arg1: new int[] {5308}, arg2: true);
                context.SetEffect(arg1: new int[] {5309}, arg2: true);
                context.SetEffect(arg1: new int[] {5310}, arg2: true);
                context.SetEffect(arg1: new int[] {5311}, arg2: true);
                context.SetEffect(arg1: new int[] {5312}, arg2: true);
                context.SetEffect(arg1: new int[] {5313}, arg2: true);
                context.SetEffect(arg1: new int[] {5314}, arg2: true);
                context.SetEffect(arg1: new int[] {5315}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000111_QD__52000111__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 25201111, textID: 25201111, duration: 10000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "10012")) {
                    context.State = new State쉐도우클로등장씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬01 : TriggerState {
            internal State쉐도우클로등장씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9000, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State쉐도우클로등장씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬02 : TriggerState {
            internal State쉐도우클로등장씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_pcFront");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000111_QD__52000111__3$", duration: 6000,
                    delayTick: 1000);
                context.SetPcEmotionLoop(arg1: "Assassin_Bore_A", arg2: 25000f);
                context.CameraSelectPath(arg1: new int[] {1006, 1007}, arg2: false);
                context.MoveUser(arg1: 52000111, arg2: 10);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.SetEffect(arg1: new int[] {5315}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State쉐도우클로등장씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬04 : TriggerState {
            internal State쉐도우클로등장씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Assassin_Bore_A");
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000111_QD__52000111__4$", duration: 6000,
                    delayTick: 1000);
                context.CameraSelectPath(arg1: new int[] {1012, 1013}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State쉐도우클로등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬05 : TriggerState {
            internal State쉐도우클로등장씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetEffect(arg1: new int[] {8003}, arg2: true);
                context.SetEffect(arg1: new int[] {8004}, arg2: true);
                context.SetEffect(arg1: new int[] {8005}, arg2: true);
                context.SetEffect(arg1: new int[] {8006}, arg2: true);
                context.SetEffect(arg1: new int[] {8007}, arg2: true);
                context.SetEffect(arg1: new int[] {8008}, arg2: true);
                context.SetEffect(arg1: new int[] {8009}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {1014, 1015}, arg2: false);
                context.SpawnNpcRange(rangeID: new int[] {202, 203, 204, 205, 206, 207, 208, 209, 210, 211},
                    isAutoTargeting: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State쉐도우클로등장씬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬06 : TriggerState {
            internal State쉐도우클로등장씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {8010}, arg2: true);
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {1016, 1017}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State쉐도우클로등장씬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬07 : TriggerState {
            internal State쉐도우클로등장씬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(arg1: 200, arg2: "Sit_Down_A", arg3: 4000f);
                context.CameraSelectPath(arg1: new int[] {1018, 1019}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State쉐도우클로등장씬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬09 : TriggerState {
            internal State쉐도우클로등장씬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Bore_A");
                context.CameraSelectPath(arg1: new int[] {1020, 1021}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State쉐도우클로등장씬11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬11 : TriggerState {
            internal State쉐도우클로등장씬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1022, 1023}, arg2: false);
                context.ShowCaption(type: "NameCaption", title: "$52000111_QD__52000111__5$",
                    desc: "$52000111_QD__52000111__6$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State쉐도우클로등장씬11_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬11_1 : TriggerState {
            internal State쉐도우클로등장씬11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State쉐도우클로등장씬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 2000, arg2: "MS2PatrolData_pcFront");
                context.MoveUser(arg1: 52000111, arg2: 10);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5311}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.SetEffect(arg1: new int[] {5315}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetEffect(arg1: new int[] {8003}, arg2: true);
                context.SetEffect(arg1: new int[] {8004}, arg2: true);
                context.SetEffect(arg1: new int[] {8005}, arg2: true);
                context.SetEffect(arg1: new int[] {8006}, arg2: true);
                context.SetEffect(arg1: new int[] {8007}, arg2: true);
                context.SetEffect(arg1: new int[] {8008}, arg2: true);
                context.SetEffect(arg1: new int[] {8009}, arg2: true);
                context.SpawnNpcRange(rangeID: new int[] {202, 203, 204, 205, 206, 207, 208, 209, 210, 211},
                    isAutoTargeting: false);
                context.DestroyMonster(arg1: new int[] {200});
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State쉐도우클로등장씬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로등장씬12 : TriggerState {
            internal State쉐도우클로등장씬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(arg1: new int[] {8010}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5305}, arg2: false);
                context.SetEffect(arg1: new int[] {5306}, arg2: false);
                context.SetEffect(arg1: new int[] {5307}, arg2: false);
                context.SetEffect(arg1: new int[] {5308}, arg2: false);
                context.SetEffect(arg1: new int[] {5309}, arg2: false);
                context.SetEffect(arg1: new int[] {5310}, arg2: false);
                context.SetEffect(arg1: new int[] {5312}, arg2: false);
                context.SetEffect(arg1: new int[] {5313}, arg2: false);
                context.SetEffect(arg1: new int[] {5314}, arg2: false);
                context.DestroyMonster(arg1: new int[] {200});
                context.CreateMonster(arg1: new int[] {201}, arg2: false);
                context.ShowGuideSummary(entityID: 25201112, textID: 25201112, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002306},
                    arg3: new byte[] {1})) {
                    context.State = new State쉐도우클로와떠남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로와떠남01 : TriggerState {
            internal State쉐도우클로와떠남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.ShowGuideSummary(entityID: 25201113, textID: 25201113, duration: 5000);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StatePC대탈출01 : TriggerState {
            internal StatePC대탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9001, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {300, 301, 302}, arg2: false);
                context.MoveUser(arg1: 52000111, arg2: 11);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new StatePC대탈출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출02 : TriggerState {
            internal StatePC대탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_3", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {1008, 1009}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 8000f);
                context.FaceEmotion(spawnPointID: 0, emotionName: "PC_Pain_86000");
                context.SetNpcEmotionLoop(arg1: 300, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 301, arg2: "Sit_Down_A", arg3: 17500f);
                context.SetNpcEmotionLoop(arg1: 302, arg2: "Sit_Down_A", arg3: 17500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7800)) {
                    context.State = new StatePC대탈출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03 : TriggerState {
            internal StatePC대탈출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_PC_GO");
                context.CameraSelectPath(arg1: new int[] {1010, 1011}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePC대탈출03_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03_1 : TriggerState {
            internal StatePC대탈출03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC대탈출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_GO");
                context.SetPcEmotionLoop(arg1: "Idle_A", arg2: 500f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePC대탈출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출04 : TriggerState {
            internal StatePC대탈출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000111_QD__52000111__7$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 25201114, textID: 25201114, duration: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {10011}, arg2: new int[] {20002314},
                    arg3: new byte[] {3})) {
                    context.State = new State어쌔신탈출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출01 : TriggerState {
            internal State어쌔신탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State어쌔신탈출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출02 : TriggerState {
            internal State어쌔신탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000113, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}