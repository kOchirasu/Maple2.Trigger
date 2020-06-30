using System;

namespace Maple2.Trigger._52000101_qd {
    public static class _52000101 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(arg1: 1000, arg2: false, arg3: false, arg4: false);
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
                context.SetEffect(arg1: new int[] {5316}, arg2: false);
                context.SetEffect(arg1: new int[] {5317}, arg2: false);
                context.SetEffect(arg1: new int[] {5318}, arg2: false);
                context.SetEffect(arg1: new int[] {5319}, arg2: false);
                context.SetEffect(arg1: new int[] {5320}, arg2: false);
                context.SetEffect(arg1: new int[] {5321}, arg2: false);
                context.SetEffect(arg1: new int[] {5322}, arg2: false);
                context.MoveUser(arg1: 52000101, arg2: 1010);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "4000")) {
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Wizard.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State엘리니아전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 62000)) {
                    context.State = new State엘리니아전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬01 : TriggerState {
            internal State엘리니아전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {1100, 1101}, arg2: 0);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State엘리니아전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬02 : TriggerState {
            internal State엘리니아전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000101_QD__52000101__0$",
                    desc: "$52000101_QD__52000101__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 10000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State엘리니아전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬03 : TriggerState {
            internal State엘리니아전경씬03(ITriggerContext context) : base(context) { }

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
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
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
                context.SetEffect(arg1: new int[] {5316}, arg2: true);
                context.SetEffect(arg1: new int[] {5317}, arg2: true);
                context.SetEffect(arg1: new int[] {5318}, arg2: true);
                context.SetEffect(arg1: new int[] {5319}, arg2: true);
                context.SetEffect(arg1: new int[] {5320}, arg2: true);
                context.SetEffect(arg1: new int[] {5321}, arg2: true);
                context.SetEffect(arg1: new int[] {5322}, arg2: true);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000101_QD__52000101__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 25201011, textID: 25201011, durationTime: 10000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "4001")) {
                    context.State = new State케이틀린등장씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬01 : TriggerState {
            internal State케이틀린등장씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {200}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린등장씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬02 : TriggerState {
            internal State케이틀린등장씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_caitCome");
                context.CameraSelectPath(arg1: new int[] {1002, 1003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State케이틀린등장씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬03 : TriggerState {
            internal State케이틀린등장씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1004, 1005}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State케이틀린등장씬04_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬04_b : TriggerState {
            internal State케이틀린등장씬04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 200, arg2: "Bore_B");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State케이틀린등장씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬04 : TriggerState {
            internal State케이틀린등장씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "NameCaption", title: "$52000101_QD__52000101__3$",
                    desc: "$52000101_QD__52000101__4$", align: "center", offsetRateX: -0.15f, offsetRateY: 0.15f,
                    duration: 10000, scale: 2.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State케이틀린등장씬04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬04_1 : TriggerState {
            internal State케이틀린등장씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_caitCome");
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린등장씬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린등장씬05 : TriggerState {
            internal State케이틀린등장씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 1.0f);
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
                context.SetEffect(arg1: new int[] {5316}, arg2: false);
                context.SetEffect(arg1: new int[] {5317}, arg2: false);
                context.SetEffect(arg1: new int[] {5318}, arg2: false);
                context.SetEffect(arg1: new int[] {5319}, arg2: false);
                context.SetEffect(arg1: new int[] {5320}, arg2: false);
                context.SetEffect(arg1: new int[] {5321}, arg2: false);
                context.SetEffect(arg1: new int[] {5322}, arg2: false);
                context.FaceEmotion(spawnPointID: 200);
                context.ShowGuideSummary(entityID: 25201012, textID: 25201012, durationTime: 10000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {4001}, arg2: new int[] {20002286},
                    arg3: new byte[] {3})) {
                    context.State = new State케이틀린화남01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {4001}, arg2: new int[] {20002286},
                    arg3: new byte[] {2})) {
                    context.State = new State케이틀린화남01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남01 : TriggerState {
            internal State케이틀린화남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "케이틀린화남06", arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveUser(arg1: 52000101, arg2: 1011);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State케이틀린화남02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남02 : TriggerState {
            internal State케이틀린화남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcID: 0, msg: "$52000101_QD__52000101__5$", duration: 4000, align: "right");
                context.CameraSelectPath(arg1: new int[] {1006, 1007}, arg2: 0);
                context.MoveNpc(arg1: 200, arg2: "MS2PatrolData_caitTurn");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Run");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State케이틀린화남03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남03 : TriggerState {
            internal State케이틀린화남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcID: 11003146, msg: "$52000101_QD__52000101__6$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000946, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000946.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new State케이틀린화남04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남04 : TriggerState {
            internal State케이틀린화남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnPointID: 200, emotionName: "UpSet");
                context.CameraSelectPath(arg1: new int[] {1008, 1009}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003146, msg: "$52000101_QD__52000101__7$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000947, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000947.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State케이틀린화남05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남05 : TriggerState {
            internal State케이틀린화남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1200}, arg2: 0);
                context.AddCinematicTalk(npcID: 11003146, msg: "$52000101_QD__52000101__8$", duration: 4000,
                    align: "right");
                context.SetOnetimeEffect(id: 3000948, enable: true,
                    path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000948.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State케이틀린화남05_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남05_1 : TriggerState {
            internal State케이틀린화남05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State케이틀린화남06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남06 : TriggerState {
            internal State케이틀린화남06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52000100, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}