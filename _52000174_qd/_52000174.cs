using System;

namespace Maple2.Trigger._52000174_qd {
    public static class _52000174 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002768},
                    arg3: new byte[] {2})) {
                    context.State = new State이도공간으로_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002776},
                    arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002770},
                    arg3: new byte[] {3})) {
                    context.State = new State전직컷씬01(context);
                    return;
                }

                if (context.UserDetected(arg1: "2001")) {
                    context.State = new Statewait_01_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_02 : TriggerState {
            internal Statewait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new Statewait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_02 : TriggerState {
            internal Statewait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieID: 1);
                context.MoveUser(arg1: 52000174, arg2: 1);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State숙소도착_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State숙소도착_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State숙소도착_01 : TriggerState {
            internal State숙소도착_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State숙소도착_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State숙소도착_02 : TriggerState {
            internal State숙소도착_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000174_QD__52000174__0$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
                context.MoveUserPath(arg1: "MS2PatrolData_3003");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State숙소도착_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State숙소도착_03 : TriggerState {
            internal State숙소도착_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State숙소도착_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State숙소도착_04 : TriggerState {
            internal State숙소도착_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State숙소도착_05(context);
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
                context.SetOnetimeEffect(id: 5, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State숙소도착_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State숙소도착_05 : TriggerState {
            internal State숙소도착_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.ShowGuideSummary(entityID: 25201741, textID: 25201741, duration: 3000);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002768},
                    arg3: new byte[] {2})) {
                    context.State = new State이도공간으로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이도공간으로_01 : TriggerState {
            internal State이도공간으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State이도공간으로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이도공간으로_02 : TriggerState {
            internal State이도공간으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000173, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State전직컷씬01 : TriggerState {
            internal State전직컷씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_soul.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State깨어났다_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State깨어났다_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_01 : TriggerState {
            internal State깨어났다_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_02 : TriggerState {
            internal State깨어났다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.CreateMonster(arg1: new int[] {104}, arg2: false);
                context.MoveUser(arg1: 52000174, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_03 : TriggerState {
            internal State깨어났다_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_04 : TriggerState {
            internal State깨어났다_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003, 4004}, arg2: false);
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 6000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State깨어났다_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_05 : TriggerState {
            internal State깨어났다_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_06 : TriggerState {
            internal State깨어났다_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State깨어났다_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State깨어났다_07 : TriggerState {
            internal State깨어났다_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002771},
                    arg3: new byte[] {3})) {
                    context.State = new State전직이펙트_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전직이펙트_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State비젼생성_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State비젼생성_01 : TriggerState {
            internal State비젼생성_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {105}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002775},
                    arg3: new byte[] {3})) {
                    context.State = new State떠나기전_04_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떠나기전_04_01 : TriggerState {
            internal State떠나기전_04_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_3002");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_3001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State떠나기전_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떠나기전_05 : TriggerState {
            internal State떠나기전_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
                context.DestroyMonster(arg1: new int[] {104});
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {40002776},
                    arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State프론티아재단으로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}