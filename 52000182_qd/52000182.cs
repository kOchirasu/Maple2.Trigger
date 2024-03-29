using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000182_qd {
    public static class _52000182 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1000, visible: false, enabled: false, minimapVisible: false);
                context.MoveUser(mapId: 52000182, portalId: 1010);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State병원전경씬01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State병원전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State병원전경씬01 : TriggerState {
            internal State병원전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CreateMonster(spawnIds: new []{400, 401, 402}, arg2: false);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State병원전경씬02_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State병원전경씬02_1 : TriggerState {
            internal State병원전경씬02_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Walk");
                context.CameraSelectPath(pathIds: new []{4000, 4001, 4002, 4003}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State병원전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State병원전경씬02 : TriggerState {
            internal State병원전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004, 4005, 4006, 4007}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000182_QD__52000182__0$", script: "$52000182_QD__52000182__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State병원전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State병원전경씬03 : TriggerState {
            internal State병원전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
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
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
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
                context.AddBalloonTalk(spawnId: 0, msg: "$52000182_QD__52000182__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 52001821, textId: 52001821, duration: 10000);
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002337}, questStates: new byte[]{3})) {
                    return new State치유마법전개01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유마법전개01 : TriggerState {
            internal State치유마법전개01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State치유마법전개02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유마법전개02 : TriggerState {
            internal State치유마법전개02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State치유마법전개03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유마법전개03 : TriggerState {
            internal State치유마법전개03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{20002340}, questStates: new byte[]{3})) {
                    return new State수련장이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장이동01 : TriggerState {
            internal State수련장이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 30, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastWhiteOutFast.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State수련장이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장이동02 : TriggerState {
            internal State수련장이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000183, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
