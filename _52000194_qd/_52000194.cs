using System;

namespace Maple2.Trigger._52000194_qd {
    public static class _52000194 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003427},
                    arg3: new byte[] {2})) {
                    context.State = new StateWait_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52000194, arg2: 5001);
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
                context.PlaySceneMovie(fileName: @"common\unconsciousEmpress.usm", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State시공의균열(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new State시공의균열(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열 : TriggerState {
            internal State시공의균열(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State시공의균열_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02 : TriggerState {
            internal State시공의균열_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000194_QD__52000194__0$",
                    desc: "$52000194_QD__52000194__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f,
                    duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State시공의균열_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03 : TriggerState {
            internal State시공의균열_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State시공의균열_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시공의균열_04 : TriggerState {
            internal State시공의균열_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}