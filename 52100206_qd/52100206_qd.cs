namespace Maple2.Trigger._52100206_qd {
    public static class _52100206_qd {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(visible: false);
                    context.CreateMonster(spawnIds: new []{2003}, arg2: false);
                    context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4060, 4061, 4062, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCameraEffect01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect01 : TriggerState {
            internal StateCameraEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect02 : TriggerState {
            internal StateCameraEffect02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1006, 1002, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateCameraEffect04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1005, 1003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateCameraEffect05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect05 : TriggerState {
            internal StateCameraEffect05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1004}, returnView: false);
                context.CreateMonster(spawnIds: new []{2002}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect06 : TriggerState {
            internal StateCameraEffect06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateBuff부여(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff부여 : TriggerState {
            internal StateBuff부여(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetVisibleUI(uiNames: new []{"MessengerBrowser", "GroupMessengerBrowser", "HighlightGameMenu"}, visible: false);
                context.VisibleMyPc(visible: true);
                context.DestroyMonster(spawnIds: new []{2002});
                context.AddBuff(boxIds: new []{101}, skillId: 99910280, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{101}, skillId: 99910280, level: 1, arg4: false, arg5: false);
                context.ShowGuideSummary(entityId: 25201503, textId: 25201503, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9010})) {
                    return new State마법다리형성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마법다리형성 : TriggerState {
            internal State마법다리형성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 1006, enabled: true);
                context.SetMesh(triggerIds: new []{4000, 4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026, 4027, 4028, 4029, 4030, 4031, 4032, 4033, 4034, 4035, 4036, 4037, 4038, 4039, 4040, 4041, 4042, 4043, 4044, 4045, 4046, 4047, 4048, 4049, 4050, 4051, 4052, 4053, 4054, 4055, 4056, 4057, 4058, 4059, 4060, 4061, 4062, 4063, 4064, 4065, 4066, 4067, 4068, 4069, 4070, 4071}, visible: true, arg3: 1000, arg4: 160, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9020})) {
                    return new State검마걸어나오는Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는Cinematic01 : TriggerState {
            internal State검마걸어나오는Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마걸어나오는Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는Cinematic02 : TriggerState {
            internal State검마걸어나오는Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelect(triggerId: 1007, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State검마걸어나오는Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는Cinematic03 : TriggerState {
            internal State검마걸어나오는Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 2003, patrolName: "MS2PatrolData_2000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State검마걸어나오는Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는Cinematic04 : TriggerState {
            internal State검마걸어나오는Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State검마걸어나오는Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마걸어나오는Cinematic05 : TriggerState {
            internal State검마걸어나오는Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetLocalCamera(cameraId: 1005, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{101}, questIds: new []{10003390}, questStates: new byte[]{3})) {
                    return new State완료Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료Cinematic01 : TriggerState {
            internal State완료Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State완료Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State완료Cinematic02 : TriggerState {
            internal State완료Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.MoveUser(mapId: 52000087, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
