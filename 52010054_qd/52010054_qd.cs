using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010054_qd {
    public static class _52010054_qd {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.VisibleMyPc(visible: false);
                context.CreateMonster(spawnIds: new []{2000, 2001, 2002, 2003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
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
                context.SetSceneSkip(state: new StateQuit02(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4000, 4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new StateCameraEffect03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect03 : TriggerState {
            internal StateCameraEffect03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect04 : TriggerState {
            internal StateCameraEffect04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 11003793, script: "$52010054_QD__52010054_QD__0$", duration: 7000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCameraEffect05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect05 : TriggerState {
            internal StateCameraEffect05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003793, script: "$52010054_QD__52010054_QD__1$", duration: 5000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{4004, 4005}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 2001, sequenceName: "Attack_01_C,Attack_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffect06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect06 : TriggerState {
            internal StateCameraEffect06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003793, script: "$52010054_QD__52010054_QD__2$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{4006, 4007}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 2002, sequenceName: "Attack_01_B,Attack_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCameraEffect07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect07 : TriggerState {
            internal StateCameraEffect07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003793, script: "$52010054_QD__52010054_QD__3$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{4008, 4009, 4013, 4014}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateCameraEffect08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect08 : TriggerState {
            internal StateCameraEffect08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCameraEffect09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect09 : TriggerState {
            internal StateCameraEffect09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{2001}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2002}, arg2: false);
                context.DestroyMonster(spawnIds: new []{2003}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 0)) {
                    return new StateCameraEffect10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect10 : TriggerState {
            internal StateCameraEffect10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CameraSelectPath(pathIds: new []{4010, 4011}, returnView: false);
                context.SetTimeScale(enabled: true, startScale: 1.0f, endScale: 0.1f, duration: 12.0f, interpolator: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new StateCameraEffect11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect11 : TriggerState {
            internal StateCameraEffect11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCameraEffect12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect12 : TriggerState {
            internal StateCameraEffect12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateCameraEffect13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCameraEffect13 : TriggerState {
            internal StateCameraEffect13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 2000, sequenceName: "Attack_01_B,Attack_01_B");
                context.SetTimeScale(enabled: true, startScale: 0.5f, endScale: 0.1f, duration: 12.0f, interpolator: 1);
                context.CameraSelectPath(pathIds: new []{4012, 4015}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUser(mapId: 02000422, portalId: 5);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
