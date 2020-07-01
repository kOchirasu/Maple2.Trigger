using System;

namespace Maple2.Trigger._52000156_qd {
    public static class _52000156 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statewait_01(context);

        private class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2001})) {
                    context.State = new Statewait_01_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statewait_01_1 : TriggerState {
            internal Statewait_01_1(ITriggerContext context) : base(context) { }

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
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State커닝시티전경_01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 85000)) {
                    context.State = new State커닝시티전경_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_01 : TriggerState {
            internal State커닝시티전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State커닝시티전경_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_02 : TriggerState {
            internal State커닝시티전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000156_QD__52000156__0$",
                    desc: "$52000156_QD__52000156__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 3000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State암전(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateUI초기화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateUI초기화 : TriggerState {
            internal StateUI초기화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000156, arg2: 6003);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {4003, 4004}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State밝아짐(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUserPath(arg1: "MS2PatrolData_3001");
                context.SetSceneSkip(arg1: "Skip_2", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State조나단만남(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조나단만남 : TriggerState {
            internal State조나단만남(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State조나단만남_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조나단만남_2 : TriggerState {
            internal State조나단만남_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조나단만남_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.MoveUser(arg1: 52000156, arg2: 6003);
                context.DestroyMonster(arg1: new int[] {101}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State조나단만남_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State조나단만남_3 : TriggerState {
            internal State조나단만남_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}