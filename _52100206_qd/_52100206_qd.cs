namespace Maple2.Trigger._52100206_qd {
    public static class _52100206_qd {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(isVisible: false);
                    context.CreateMonster(arg1: new[] {2003}, arg2: false);
                    context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4060, 4061, 4062, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCameraEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
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

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1006}, arg2: false);
            }

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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1006, 1002, 1005}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateCameraEffect04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new[] {1005, 1003}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateCameraEffect05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect05 : TriggerState {
            internal StateCameraEffect05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {2002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCameraEffect06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect06 : TriggerState {
            internal StateCameraEffect06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State버프부여(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프부여 : TriggerState {
            internal State버프부여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiName: "MessengerBrowser,GroupMessengerBrowser,HighlightGameMenu", visible: false);
                context.VisibleMyPc(isVisible: true);
                context.DestroyMonster(arg1: new[] {2002});
                context.AddBuff(arg1: new[] {101}, arg2: 99910280, arg3: 1, arg4: false, arg5: true);
                context.AddBuff(arg1: new[] {101}, arg2: 99910280, arg3: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 25201503, textId: 25201503, duration: 10000);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9010})) {
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
                context.SetMesh(arg1: new[] {4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4060, 4061, 4062, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071}, arg2: true, arg3: 1000, arg4: 160, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9020})) {
                    context.State = new State검마걸어나오는연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는연출01 : TriggerState {
            internal State검마걸어나오는연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State검마걸어나오는연출02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는연출02 : TriggerState {
            internal State검마걸어나오는연출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(arg1: 1007, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State검마걸어나오는연출03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는연출03 : TriggerState {
            internal State검마걸어나오는연출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 2003, arg2: "MS2PatrolData_2000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State검마걸어나오는연출04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는연출04 : TriggerState {
            internal State검마걸어나오는연출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State검마걸어나오는연출05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는연출05 : TriggerState {
            internal State검마걸어나오는연출05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 1005, enable: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {101}, arg2: new[] {10003390}, arg3: new byte[] {3})) {
                    context.State = new State완료연출01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료연출01 : TriggerState {
            internal State완료연출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetOnetimeEffect(id: 4, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUser(arg1: 52000087, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}