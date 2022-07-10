using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000101_qd {
    public static class _52000101 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(portalId: 1000, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322}, visible: false);
                context.MoveUser(mapId: 52000101, portalId: 1010);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{4000})) {
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Wizard.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State엘리니아전경씬01(context);
                }

                if (context.WaitTick(waitTick: 62000)) {
                    return new State엘리니아전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬01 : TriggerState {
            internal State엘리니아전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1100, 1101}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State엘리니아전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬02 : TriggerState {
            internal State엘리니아전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000101_QD__52000101__0$", script: "$52000101_QD__52000101__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 10000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State엘리니아전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리니아전경씬03 : TriggerState {
            internal State엘리니아전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_SlowFade.xml");
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
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322}, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000101_QD__52000101__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201011, textId: 25201011, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{4001})) {
                    return new State케이틀린Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬01 : TriggerState {
            internal State케이틀린Spawn씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린Spawn씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬02 : TriggerState {
            internal State케이틀린Spawn씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_caitCome");
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State케이틀린Spawn씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬03 : TriggerState {
            internal State케이틀린Spawn씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State케이틀린Spawn씬04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬04_b : TriggerState {
            internal State케이틀린Spawn씬04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 200, sequenceName: "Bore_B");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State케이틀린Spawn씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬04 : TriggerState {
            internal State케이틀린Spawn씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, title: "$52000101_QD__52000101__3$", script: "$52000101_QD__52000101__4$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State케이틀린Spawn씬04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬04_1 : TriggerState {
            internal State케이틀린Spawn씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_caitCome");
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린Spawn씬05 : TriggerState {
            internal State케이틀린Spawn씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322}, visible: false);
                context.FaceEmotion(spawnId: 200);
                context.ShowGuideSummary(entityId: 25201012, textId: 25201012, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{4001}, questIds: new []{20002286}, questStates: new byte[]{3})) {
                    return new State케이틀린화남01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{4001}, questIds: new []{20002286}, questStates: new byte[]{2})) {
                    return new State케이틀린화남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남01 : TriggerState {
            internal State케이틀린화남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State케이틀린화남06(context), arg2: "exit");
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000101, portalId: 1011);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State케이틀린화남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남02 : TriggerState {
            internal State케이틀린화남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.AddCinematicTalk(npcId: 0, script: "$52000101_QD__52000101__5$", duration: 4000, align: Align.Right);
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.MoveNpc(spawnId: 200, patrolName: "MS2PatrolData_caitTurn");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_Run");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State케이틀린화남03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남03 : TriggerState {
            internal State케이틀린화남03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003146, script: "$52000101_QD__52000101__6$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000946, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000946.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State케이틀린화남04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남04 : TriggerState {
            internal State케이틀린화남04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 200, emotionName: "UpSet");
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
                context.AddCinematicTalk(npcId: 11003146, script: "$52000101_QD__52000101__7$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000947, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000947.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State케이틀린화남05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남05 : TriggerState {
            internal State케이틀린화남05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1200}, returnView: false);
                context.AddCinematicTalk(npcId: 11003146, script: "$52000101_QD__52000101__8$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000948, enable: true, path: @"BG/Common/Sound/Eff_Caitlyn_IntroQuest_03000948.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State케이틀린화남05_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남05_1 : TriggerState {
            internal State케이틀린화남05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State케이틀린화남06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State케이틀린화남06 : TriggerState {
            internal State케이틀린화남06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveUser(mapId: 52000100, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
