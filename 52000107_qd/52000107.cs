using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000107_qd {
    public static class _52000107 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322, 5323, 5324, 5325, 5326}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10010})) {
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
                context.MoveUser(mapId: 52000107, portalId: 2);
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_HeavyGunner.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State에델슈타인전경씬01(context);
                }

                if (context.WaitTick(waitTick: 42000)) {
                    return new State에델슈타인전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01 : TriggerState {
            internal State에델슈타인전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8500)) {
                    return new State에델슈타인전경씬01_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬01_B : TriggerState {
            internal State에델슈타인전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에델슈타인전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬02 : TriggerState {
            internal State에델슈타인전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1002, 1003, 1004, 1005}, returnView: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State에델슈타인전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬03 : TriggerState {
            internal State에델슈타인전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000107_QD__52000107__0$", script: "$52000107_QD__52000107__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State에델슈타인전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에델슈타인전경씬04 : TriggerState {
            internal State에델슈타인전경씬04(ITriggerContext context) : base(context) { }

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
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322, 5323, 5324, 5325, 5326}, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000107_QD__52000107__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201071, textId: 25201071, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10011})) {
                    return new State아이샤Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤Spawn씬01 : TriggerState {
            internal State아이샤Spawn씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{2000}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아이샤Spawn씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤Spawn씬02 : TriggerState {
            internal State아이샤Spawn씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_Ayesha_go");
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아이샤Spawn씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤Spawn씬04 : TriggerState {
            internal State아이샤Spawn씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003291, illustId: "Ayesha_normal", script: "$52000107_QD__52000107__3$", duration: 4000, align: Align.Right);
                context.SetOnetimeEffect(id: 3000970, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000970.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아이샤Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤Spawn씬05 : TriggerState {
            internal State아이샤Spawn씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 200, emotionName: "hello_Cait");
                context.ShowCaption(type: CaptionType.Name, title: "$52000107_QD__52000107__4$", script: "$52000107_QD__52000107__5$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State아이샤Spawn씬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아이샤Spawn씬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤Spawn씬06 : TriggerState {
            internal State아이샤Spawn씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(triggerIds: new []{5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315, 5316, 5317, 5318, 5319, 5320, 5321, 5322, 5323, 5324, 5325, 5326}, visible: false);
                context.FaceEmotion(spawnId: 200);
                context.ShowGuideSummary(entityId: 25201071, textId: 25201071, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002296}, questStates: new byte[]{2})) {
                    return new State아이샤와떠남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤와떠남01 : TriggerState {
            internal State아이샤와떠남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 2000, msg: "$52000107_QD__52000107__6$", duration: 6000, delayTick: 1000);
                context.SetOnetimeEffect(id: 3000971, enabled: true, path: @"BG/Common/Sound/Eff_Ayesha_IntroMovie_03000971.xml");
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_Ayesga_out");
                context.ShowGuideSummary(entityId: 25201072, textId: 25201072, duration: 5000);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 10012, spawnIds: new []{2000})) {
                    return new State아이샤와떠남02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이샤와떠남02 : TriggerState {
            internal State아이샤와떠남02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{2000});
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 9003, spawnIds: new []{202})) {
                    // return new State아이샤와떠남03(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
