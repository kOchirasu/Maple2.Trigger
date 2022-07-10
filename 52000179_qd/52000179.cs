using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000179_qd {
    public static class _52000179 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{2001}, jobCode: 0)) {
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
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
                context.MoveUser(mapId: 52000179, portalId: 1);
            }

            public override TriggerState? Execute() {
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
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: "jobChangeStory.swf", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
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
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
            }

            public override TriggerState? Execute() {
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
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000179_QD__52000179__0$", script: "$52000179_QD__52000179__2$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 3000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
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
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002757}, questStates: new byte[]{2})) {
                    return new StateQuestGuide_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002757}, questStates: new byte[]{3})) {
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

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002757}, questStates: new byte[]{3})) {
                    return new State케이틀린걱정(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린걱정 : TriggerState {
            internal State케이틀린걱정(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3001");
                context.AddBalloonTalk(spawnId: 101, msg: "$52000179_QD__52000179__1$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002758}, questStates: new byte[]{3})) {
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
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000180, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
