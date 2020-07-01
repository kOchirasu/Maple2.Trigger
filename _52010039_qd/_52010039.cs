using System;

namespace Maple2.Trigger._52010039_qd {
    public static class _52010039 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new State영상재생_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\SkyFortress_Intro.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new Statestart(context);
                    return;
                }

                if (context.WaitTick(waitTick: 170000)) {
                    context.State = new Statestart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State연출종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료01 : TriggerState {
            internal State연출종료01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State연출종료02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료02 : TriggerState {
            internal State연출종료02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOut.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State연출종료03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State연출종료03 : TriggerState {
            internal State연출종료03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 9010, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State스카이포트리스전경씬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스카이포트리스전경씬03 : TriggerState {
            internal State스카이포트리스전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.ShowCaption(type: "VerticalCaption", title: "$52010039_QD__52010039__8$",
                    desc: "$52010039_QD__52010039__9$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 7000, scale: 2.5f);
                context.CameraSelectPath(arg1: new int[] {1002, 1003}, arg2: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State스카이포트리스전경씬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스카이포트리스전경씬04 : TriggerState {
            internal State스카이포트리스전경씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State스카이포트리스전경씬04_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스카이포트리스전경씬04_1 : TriggerState {
            internal State스카이포트리스전경씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuit01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnPointID: 0, msg: "$52010039_QD__52010039__10$", duration: 6000,
                    delayTick: 1000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}