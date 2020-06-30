using System;

namespace Maple2.Trigger._52100205_qd {
    public static class _52100205 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "2001")) {
                    context.State = new StateCameraEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {201});
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
                context.MoveUser(arg1: 52100205, arg2: 5001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_02 : TriggerState {
            internal StateCameraEffect02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52100205_QD__52100205__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCameraEffect03_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_2 : TriggerState {
            internal StateCameraEffect03_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4002, 4003}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCameraEffect03_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4004}, arg2: 0);
                context.ShowCaption(type: "VerticalCaption", title: "$52100205_QD__52100205__1$", align: "bottomLeft",
                    offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCameraEffect03_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_4 : TriggerState {
            internal StateCameraEffect03_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_5 : TriggerState {
            internal StateCameraEffect03_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {201});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910400, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910400, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_6 : TriggerState {
            internal StateCameraEffect03_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_7 : TriggerState {
            internal StateCameraEffect03_7(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11004612, msg: "$52100205_QD__52100205__2$", align: "left",
                    illustID: "cladia_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCameraEffect03_8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_8 : TriggerState {
            internal StateCameraEffect03_8(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "2002")) {
                    context.State = new State제시카_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_01 : TriggerState {
            internal State제시카_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제시카_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_02 : TriggerState {
            internal State제시카_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4005}, arg2: 0);
                context.CreateMonster(arg1: new int[] {101});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State제시카_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_03 : TriggerState {
            internal State제시카_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State제시카_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_04 : TriggerState {
            internal State제시카_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4006}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    context.State = new State제시카_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_05 : TriggerState {
            internal State제시카_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.AddCinematicTalk(npcID: 11004575, msg: "$52100205_QD__52100205__3$", align: "left",
                    illustID: "Jessica_normal", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State제시카_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_06 : TriggerState {
            internal State제시카_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State제시카_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State제시카_07 : TriggerState {
            internal State제시카_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}