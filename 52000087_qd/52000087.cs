using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000087_qd {
    public static class _52000087 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{22651}, questIds: new []{10003370}, questStates: new byte[]{2})) {
                    return new State보고시작Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_01 : TriggerState {
            internal State보고시작Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000087, portalId: 6001);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State보고시작Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_02 : TriggerState {
            internal State보고시작Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{4002}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3001");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5500)) {
                    return new State보고시작Prepare_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_03 : TriggerState {
            internal State보고시작Prepare_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 5000f);
                context.CameraSelectPath(pathIds: new []{4003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State보고시작Prepare_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작Prepare_04 : TriggerState {
            internal State보고시작Prepare_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State보고시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보고시작_01 : TriggerState {
            internal State보고시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000087_QD__52000087__0$");
                context.MoveUser(mapId: 52000087, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
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
                context.PlaySceneMovie(fileName: "Kritias_EpicCutScene_second_01.swf", movieId: 1);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 35000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.MoveUser(mapId: 52000087, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
