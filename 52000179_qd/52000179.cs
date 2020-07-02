namespace Maple2.Trigger._52000179_qd {
    public static class _52000179 {
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
                context.CreateMonster(arg1: new[] {101, 102, 103}, arg2: false);
                context.MoveUser(arg1: 52000179, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    return new State숲전경_01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State숲전경_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숲전경_01 : TriggerState {
            internal State숲전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(arg1: "Skip_1", arg2: "nextState");
                context.CameraSelectPath(arg1: new[] {4001, 4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State숲전경_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State숲전경_02 : TriggerState {
            internal State숲전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: "VerticalCaption", title: "$52000179_QD__52000179__0$", desc: "$52000179_QD__52000179__2$", align: "bottomLeft", offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
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
                if (context.WaitTick(waitTick: 1000)) {
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
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002757}, arg3: new byte[] {2})) {
                    return new StateQuestGuide_01(context);
                }

                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002757}, arg3: new byte[] {3})) {
                    return new State케이틀린걱정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestGuide_01 : TriggerState {
            internal StateQuestGuide_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201791, textId: 25201791, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002757}, arg3: new byte[] {3})) {
                    return new State케이틀린걱정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린걱정 : TriggerState {
            internal State케이틀린걱정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_3001");
                context.AddBalloonTalk(spawnPointId: 101, msg: "$52000179_QD__52000179__1$", duration: 3000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {40002758}, arg3: new byte[] {3})) {
                    return new State이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동_01 : TriggerState {
            internal State이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(arg1: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동_02 : TriggerState {
            internal State이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000180, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}