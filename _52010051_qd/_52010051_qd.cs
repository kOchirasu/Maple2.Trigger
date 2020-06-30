using System;

namespace Maple2.Trigger._52010051_qd {
    public static class _52010051_qd {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckUser()) {
                    context.VisibleMyPc(isVisible: false);
                    context.CreateMonster(arg1: new int[] {2003}, arg2: false);
                    context.SetMesh(
                        arg1: new int[] {
                            4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014,
                            4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029,
                            4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044,
                            4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059,
                            4060, 4061, 4062, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071
                        }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
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
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCameraEffect02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.CameraSelectPath(arg1: new int[] {1002, 1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateCameraEffect4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect4 : TriggerState {
            internal StateCameraEffect4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {1004}, arg2: false);
                context.CreateMonster(arg1: new int[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect4_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect4_b : TriggerState {
            internal StateCameraEffect4_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "101")) {
                    context.State = new State버프부여(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프부여 : TriggerState {
            internal State버프부여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser", visible: false);
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new int[] {2002});
                context.AddBuff(arg1: new int[] {101}, arg2: 99910280, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new int[] {101}, arg2: 99910280, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityID: 25201503, textID: 25201503, duration: 10000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9010")) {
                    context.State = new State마법다리형성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마법다리형성 : TriggerState {
            internal State마법다리형성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 1006, enable: true);
                context.SetMesh(
                    arg1: new int[] {
                        4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015,
                        4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031,
                        4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047,
                        4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4060, 4061, 4062, 4063,
                        4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071
                    }, arg2: true, arg3: 1000, arg4: 160, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9020")) {
                    context.State = new State검마발록연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마발록연출01 : TriggerState {
            internal State검마발록연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검마발록연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마발록연출02 : TriggerState {
            internal State검마발록연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {1000, 1001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State검마발록연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마발록연출03 : TriggerState {
            internal State검마발록연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {2000}, arg2: false);
                context.CreateMonster(arg1: new int[] {2001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new State검마발록연출03_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마발록연출03_b : TriggerState {
            internal State검마발록연출03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State검마발록연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마발록연출04 : TriggerState {
            internal State검마발록연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 1005, enable: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {101}, arg2: new int[] {91000046},
                    arg3: new byte[] {3})) {
                    context.State = new State완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료연출01 : TriggerState {
            internal State완료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State완료연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료연출02 : TriggerState {
            internal State완료연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUser(arg1: 52010052, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}