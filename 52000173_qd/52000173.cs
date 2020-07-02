namespace Maple2.Trigger._52000173_qd {
    public static class _52000173 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {2001})) {
                    return new StateWait_01_준비(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_준비 : TriggerState {
            internal StateWait_01_준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_01_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 1);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUser(arg1: 52000173, arg2: 1);
                context.CameraSelectPath(arg1: new[] {401, 402}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State이도공간전경_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이도공간전경_01 : TriggerState {
            internal State이도공간전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State이도공간전경_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이도공간전경_02 : TriggerState {
            internal State이도공간전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000173_QD__52000173__0$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                if (context.WaitTick(waitTick: 2000)) {
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
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002770}, arg3: new byte[] {3})) {
                    return new State이동2_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동2_01 : TriggerState {
            internal State이동2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State이동2_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동2_02 : TriggerState {
            internal State이동2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000174, arg2: 2);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}