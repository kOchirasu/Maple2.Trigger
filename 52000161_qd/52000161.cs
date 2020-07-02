namespace Maple2.Trigger._52000161_qd {
    public static class _52000161 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUser(arg1: 52000161, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경_01 : TriggerState {
            internal State리엔전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경_02 : TriggerState {
            internal State리엔전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
                context.ShowCaption(type: "VerticalCaption", title: "$52000161_QD__52000161__0$", desc: "$52000161_QD__52000161__1$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
                context.MoveUserPath(arg1: "MS2PatrolData_3002");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State정리_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_01 : TriggerState {
            internal State정리_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State정리_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_02 : TriggerState {
            internal State정리_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State정리_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State정리_03 : TriggerState {
            internal State정리_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {101}, arg2: false);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
                context.MoveUser(arg1: 52000161, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002750}, arg3: new byte[] {2})) {
                    return new State전직하러(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직하러 : TriggerState {
            internal State전직하러(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직하러_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직하러_01 : TriggerState {
            internal State전직하러_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000163, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}