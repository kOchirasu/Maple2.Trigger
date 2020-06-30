using System;

namespace Maple2.Trigger._52000182_qd {
    public static class _52000182 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1000, arg2: false, arg3: false, arg4: false);
                context.MoveUser(arg1: 52000182, arg2: 1010);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new State영상재생(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State병원전경씬01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State병원전경씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State병원전경씬01 : TriggerState {
            internal State병원전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(arg1: new int[] {400}, arg2: false);
                context.CreateMonster(arg1: new int[] {401}, arg2: false);
                context.CreateMonster(arg1: new int[] {402}, arg2: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State병원전경씬02_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State병원전경씬02_1 : TriggerState {
            internal State병원전경씬02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_PC_Walk");
                context.CameraSelectPath(arg1: new int[] {4000, 4001, 4002, 4003}, arg2: 0);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State병원전경씬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State병원전경씬02 : TriggerState {
            internal State병원전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004, 4005, 4006, 4007}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$52000182_QD__52000182__0$",
                    desc: "$52000182_QD__52000182__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State병원전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State병원전경씬03 : TriggerState {
            internal State병원전경씬03(ITriggerContext context) : base(context) { }

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
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52000182_QD__52000182__2$", duration: 6000,
                    delayTick: 1000);
                context.ShowGuideSummary(entityID: 52001821, textID: 52001821, durationTime: 10000);
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002337},
                    arg3: new byte[] {3})) {
                    context.State = new State치유마법전개01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유마법전개01 : TriggerState {
            internal State치유마법전개01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State치유마법전개02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유마법전개02 : TriggerState {
            internal State치유마법전개02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State치유마법전개03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State치유마법전개03 : TriggerState {
            internal State치유마법전개03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9001}, arg2: new int[] {20002340},
                    arg3: new byte[] {3})) {
                    context.State = new State수련장이동01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수련장이동01 : TriggerState {
            internal State수련장이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State수련장이동02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State수련장이동02 : TriggerState {
            internal State수련장이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000183, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}