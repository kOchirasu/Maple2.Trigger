namespace Maple2.Trigger._52000171_qd {
    public static class _52000171 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
                context.MoveUser(arg1: 52000171, arg2: 6);
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChange_striker.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State전경씬01(context);
                }

                if (context.WaitTick(waitTick: 8000)) {
                    return new State전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬01 : TriggerState {
            internal State전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPcEmotionLoop(arg1: "Push_A", arg2: 10000f, arg3: true);
                context.SetNpcEmotionLoop(arg1: 401, arg2: "Down_Idle_A", arg3: 10000f);
                context.CameraSelectPath(arg1: new[] {4000, 4001}, arg2: false);
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전경씬02 : TriggerState {
            internal State전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01 : TriggerState {
            internal StateQuit01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit02(context);
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
                    return new StateQuit02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit02 : TriggerState {
            internal StateQuit02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(arg1: 0);
                context.SetCinematicUI(arg1: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveNpc(arg1: 401, arg2: "MS2PatrolData_basara");
                context.ShowGuideSummary(entityId: 52001702, textId: 52001702, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002382}, arg3: new byte[] {3})) {
                    return new State전직이펙트_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_01 : TriggerState {
            internal State전직이펙트_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State전직이펙트_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State전직이펙트_02 : TriggerState {
            internal State전직이펙트_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit03 : TriggerState {
            internal StateQuit03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002385}, arg3: new byte[] {3})) {
                    return new State프론티아재단으로01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로01 : TriggerState {
            internal State프론티아재단으로01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State프론티아재단으로02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State프론티아재단으로02 : TriggerState {
            internal State프론티아재단으로02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000186, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}