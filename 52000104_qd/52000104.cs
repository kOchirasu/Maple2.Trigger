using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000104_qd {
    public static class _52000104 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.CreateMonster(spawnIds: new []{205}, arg2: false);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10011})) {
                    return new State영상Prepare_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상Prepare_01 : TriggerState {
            internal State영상Prepare_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000104, portalId: 1);
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Berserker.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State리엔전경씬01(context);
                }

                if (context.WaitTick(waitTick: 75000)) {
                    return new State리엔전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬01 : TriggerState {
            internal State리엔전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔전경씬01_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬01_B : TriggerState {
            internal State리엔전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬02 : TriggerState {
            internal State리엔전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리엔전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬03 : TriggerState {
            internal State리엔전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000104_QD__52000104__0$", script: "$52000104_QD__52000104__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State리엔전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리엔전경씬04 : TriggerState {
            internal State리엔전경씬04(ITriggerContext context) : base(context) { }

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
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000104_QD__52000104__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201041, textId: 25201041, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10012})) {
                    return new State리린과대화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화01 : TriggerState {
            internal State리린과대화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.MoveUser(mapId: 52000104, portalId: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화02 : TriggerState {
            internal State리린과대화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Ririn_Go");
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State리린과대화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화03 : TriggerState {
            internal State리린과대화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.FaceEmotion(spawnId: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: CaptionType.Name, title: "$52000104_QD__52000104__3$", script: "$52000104_QD__52000104__4$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State리린과대화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화04 : TriggerState {
            internal State리린과대화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State리린과대화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리린과대화05 : TriggerState {
            internal State리린과대화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317}, visible: false);
                context.FaceEmotion(spawnId: 200);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002316}, questStates: new byte[]{1})) {
                    return new State꽃가꾸기Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002317}, questStates: new byte[]{1})) {
                    return new State꽃섬멸Quest01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002317}, questStates: new byte[]{3})) {
                    return new State할아버지Spawn씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{1})) {
                    return new State할아버지Spawn씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{2})) {
                    return new State할아버지Spawn씬01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{3})) {
                    return new State할아버지Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃가꾸기Quest01 : TriggerState {
            internal State꽃가꾸기Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201042, textId: 25201042, duration: 10000);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Ririn_Go2");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002317}, questStates: new byte[]{1})) {
                    return new State꽃섬멸Quest01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest01 : TriggerState {
            internal State꽃섬멸Quest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Ririn_Go2");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State꽃섬멸Quest02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest02 : TriggerState {
            internal State꽃섬멸Quest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State꽃섬멸Quest03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽃섬멸Quest03 : TriggerState {
            internal State꽃섬멸Quest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.CreateMonster(spawnIds: new []{200, 201, 202, 203, 204}, arg2: false);
                context.SetSound(triggerId: 9000, enabled: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000104_QD__52000104__5$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201043, textId: 25201043, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002317}, questStates: new byte[]{3})) {
                    return new State할아버지Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬01 : TriggerState {
            internal State할아버지Spawn씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9000, enabled: false);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State할아버지Spawn씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬02 : TriggerState {
            internal State할아버지Spawn씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_ten_go");
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Spawn씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬03 : TriggerState {
            internal State할아버지Spawn씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003175, illustId: "Ten_normal", script: "$52000104_QD__52000104__6$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State할아버지Spawn씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬04 : TriggerState {
            internal State할아버지Spawn씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Name, title: "$52000104_QD__52000104__7$", script: "$52000104_QD__52000104__8$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State할아버지Spawn씬04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬04_1 : TriggerState {
            internal State할아버지Spawn씬04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.CameraReset(interpolationTime: 1.0f);
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_ten_go");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State할아버지Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State할아버지Spawn씬05 : TriggerState {
            internal State할아버지Spawn씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 1.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_ririn_move");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{1})) {
                    return new State대검바라보기01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{2})) {
                    return new State대검바라보기01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{3})) {
                    return new State수련장으로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대검바라보기01 : TriggerState {
            internal State대검바라보기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Ririn_Go3");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_ten_go2");
                context.ShowGuideSummary(entityId: 25201044, textId: 25201044, duration: 10000);
                context.SetEffect(triggerIds: new []{5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002319}, questStates: new byte[]{3})) {
                    return new State수련장으로이동01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장으로이동01 : TriggerState {
            internal State수련장으로이동01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5411, 5412, 5413, 5414, 5415, 5416}, visible: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_Ririn_Go");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_ten_exit");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000104_QD__52000104__9$", duration: 6000, delayTick: 1000);
                context.AddBalloonTalk(spawnId: 101, msg: "$52000104_QD__52000104__10$", duration: 6000, delayTick: 2500);
                context.ShowGuideSummary(entityId: 25201045, textId: 25201045, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 10013, spawnIds: new []{102})) {
                    return new State수련장으로이동02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수련장으로이동02 : TriggerState {
            internal State수련장으로이동02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
