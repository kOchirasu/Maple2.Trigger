namespace Maple2.Trigger._52000163_qd {
    public static class _52000163 {
        public class Statewait_01 : TriggerState {
            internal Statewait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {2001}, arg2: 0)) {
                    context.State = new State전직컷씬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직컷씬01 : TriggerState {
            internal State전직컷씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_berserker.swf", movieId: 1);
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new State리엔원경_01_03(context);
                    return;
                }

                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State리엔원경_01_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리엔원경_01_03 : TriggerState {
            internal State리엔원경_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new[] {4003, 4004}, arg2: false);
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State리엔원경_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State리엔원경_02 : TriggerState {
            internal State리엔원경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000163_QD__52000163__0$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State정리2_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리2_01 : TriggerState {
            internal State정리2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State정리2_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리2_02 : TriggerState {
            internal State정리2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State정리2_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State정리2_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State정리2_03 : TriggerState {
            internal State정리2_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveUser(arg1: 52000163, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State전직준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직준비 : TriggerState {
            internal State전직준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002750}, arg3: new byte[] {3})) {
                    context.State = new State전직이펙트_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State전직이펙트_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State떠나기전준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State떠나기전준비 : TriggerState {
            internal State떠나기전준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002753}, arg3: new byte[] {3})) {
                    context.State = new State프론티아재단으로_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_01 : TriggerState {
            internal State프론티아재단으로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State프론티아재단으로_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로_02 : TriggerState {
            internal State프론티아재단으로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}