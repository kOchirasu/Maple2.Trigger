using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000158_qd {
    public static class _52000158 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002736}, questStates: new byte[]{3})) {
                    return new State돌아왔다Prepare_01(context);
                }

                if (context.UserDetected(boxIds: new []{2001}, jobCode: 0)) {
                    return new StateWait_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_1 : TriggerState {
            internal StateWait_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000158, portalId: 6001);
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
                    return new State커닝시티전경_01(context);
                }

                if (context.WaitTick(waitTick: 85000)) {
                    return new State커닝시티전경_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_01 : TriggerState {
            internal State커닝시티전경_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State커닝시티전경_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경_02 : TriggerState {
            internal State커닝시티전경_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000158_QD__52000158__0$", script: "$52000158_QD__52000158__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신_01 : TriggerState {
            internal State어쌔신_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State암전(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State암전 : TriggerState {
            internal State암전(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateUIReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateUIReset : TriggerState {
            internal StateUIReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State밝아짐(context);
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
                    return new State밝아짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밝아짐 : TriggerState {
            internal State밝아짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002733}, questStates: new byte[]{3})) {
                    return new State이동_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002732}, questStates: new byte[]{2})) {
                    return new StateQuestGuide(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestGuide : TriggerState {
            internal StateQuestGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201581, textId: 25201581, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002734}, questStates: new byte[]{2})) {
                    return new State이동_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동_01 : TriggerState {
            internal State이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
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
                context.MoveUser(mapId: 52000159, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State돌아왔다Prepare_01 : TriggerState {
            internal State돌아왔다Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State돌아왔다_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌아왔다_01 : TriggerState {
            internal State돌아왔다_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State돌아왔다_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State돌아왔다_02 : TriggerState {
            internal State돌아왔다_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000158, portalId: 6001);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{40002741}, questStates: new byte[]{2})) {
                    return new State이동2_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동2_01 : TriggerState {
            internal State이동2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
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
                context.MoveUser(mapId: 52000160, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
