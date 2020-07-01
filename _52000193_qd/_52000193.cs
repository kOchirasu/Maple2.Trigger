using System;

namespace Maple2.Trigger._52000193_qd {
    public static class _52000193 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {2001})) {
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
                context.CreateMonster(arg1: new int[] {202});
                context.VisibleMyPc(isVisible: false);
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_01 : TriggerState {
            internal StateCameraEffect02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003406},
                    arg3: new byte[] {2})) {
                    context.State = new StateCameraEffect02_02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {3})) {
                    context.State = new State이동(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {2})) {
                    context.State = new State변신_02(context);
                    return;
                }

                if (!context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {2})) {
                    context.State = new State변신_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02_02 : TriggerState {
            internal StateCameraEffect02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 9, arg2: "$52000193_QD__52000193__0$");
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
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect03_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_3 : TriggerState {
            internal StateCameraEffect03_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4001, 4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000193_QD__52000193__1$", align: "bottomLeft",
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
                    context.State = new State변신_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State변신_01 : TriggerState {
            internal State변신_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {201});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraEffect03_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State변신_02 : TriggerState {
            internal State변신_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000193, arg2: 5002);
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new int[] {201});
                context.VisibleMyPc(isVisible: true);
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu",
                    visible: false);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {2001}, arg2: 99910402, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCameraEffect03_6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03_6 : TriggerState {
            internal StateCameraEffect03_6(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003407},
                    arg3: new byte[] {3})) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 02000065, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}