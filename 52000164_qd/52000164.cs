using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000164_qd {
    public static class _52000164 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1000, visible: false, enabled: false, minimapVisible: false);
                context.MoveUser(arg1: 52000164, arg2: 1010);
                context.SetCinematicUI(type: 1);
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
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
            }

            public override TriggerState Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, arg2: "IsStop", arg3: "1")) {
                    return new State연구실전경씬01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State연구실전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연구실전경씬01 : TriggerState {
            internal State연구실전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CreateMonster(arg1: new[] {400, 401}, arg2: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State연구실전경씬02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연구실전경씬02_1 : TriggerState {
            internal State연구실전경씬02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State연구실전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연구실전경씬02 : TriggerState {
            internal State연구실전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4000, 4001, 4002}, arg2: false);
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_isha");
                context.MoveUserPath(arg1: "MS2PatrolData_pc");
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000164_QD__52000164__0$", script: "$52000164_QD__52000164__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State연구실전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State연구실전경씬03 : TriggerState {
            internal State연구실전경씬03(ITriggerContext context) : base(context) { }

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
                context.SetCinematicUI(type: 4);
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.ShowGuideSummary(entityId: 52001641, textId: 52001641, duration: 10000);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002348}, arg3: new byte[] {3})) {
                    return new State아이샤이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤이동01 : TriggerState {
            internal State아이샤이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 400, arg2: "MS2PatrolData_isha2");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {20002354}, arg3: new byte[] {3})) {
                    return new State본격연구시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본격연구시작01 : TriggerState {
            internal State본격연구시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State본격연구시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State본격연구시작02 : TriggerState {
            internal State본격연구시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000165, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}