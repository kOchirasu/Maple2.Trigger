using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000194_qd {
    public static class _52000194 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003427}, questStates: new byte[]{2})) {
                    return new StateWait_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_02 : TriggerState {
            internal StateWait_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000194, portalId: 5001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생 : TriggerState {
            internal State영상재생(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.PlaySceneMovie(fileName: @"common\unconsciousEmpress.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State시공의균열(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new State시공의균열(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열 : TriggerState {
            internal State시공의균열(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State시공의균열_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_02 : TriggerState {
            internal State시공의균열_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4001, 4002}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000194_QD__52000194__0$", script: "$52000194_QD__52000194__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State시공의균열_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_03 : TriggerState {
            internal State시공의균열_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State시공의균열_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State시공의균열_04 : TriggerState {
            internal State시공의균열_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
