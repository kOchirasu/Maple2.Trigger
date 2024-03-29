using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000111_qd {
    public static class _52000111 {
        public class State입장 : TriggerState {
            internal State입장(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10011})) {
                    return new StateSTART(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSTART : TriggerState {
            internal StateSTART(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002315}, questStates: new byte[]{2})) {
                    return new State어쌔신탈출02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{2})) {
                    return new StatePC대탈출01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{3})) {
                    return new StatePC대탈출01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002314}, questStates: new byte[]{2})) {
                    return new StatePC대탈출01(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002313}, questStates: new byte[]{2})) {
                    return new StateWait(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002312}, questStates: new byte[]{3})) {
                    return new StatePC대탈출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, visible: false);
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
                context.MoveUser(mapId: 52000111, portalId: 2);
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Assassin.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State커닝시티전경씬01(context);
                }

                if (context.WaitTick(waitTick: 55000)) {
                    return new State커닝시티전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01 : TriggerState {
            internal State커닝시티전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{1000, 1001}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State커닝시티전경씬01_B(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬01_B : TriggerState {
            internal State커닝시티전경씬01_B(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State커닝시티전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬02 : TriggerState {
            internal State커닝시티전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1004, 1005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State커닝시티전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬03 : TriggerState {
            internal State커닝시티전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000111_QD__52000111__0$", script: "$52000111_QD__52000111__1$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 7000, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State커닝시티전경씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State커닝시티전경씬04 : TriggerState {
            internal State커닝시티전경씬04(ITriggerContext context) : base(context) { }

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
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuit01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit01_1 : TriggerState {
            internal StateQuit01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, visible: true);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000111_QD__52000111__2$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201111, textId: 25201111, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{10012})) {
                    return new State쉐도우클로Spawn씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬01 : TriggerState {
            internal State쉐도우클로Spawn씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9000, enabled: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도우클로Spawn씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬02 : TriggerState {
            internal State쉐도우클로Spawn씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_pcFront");
                context.AddBalloonTalk(spawnId: 0, msg: "$52000111_QD__52000111__3$", duration: 6000, delayTick: 1000);
                context.SetPcEmotionLoop(sequenceName: "Assassin_Bore_A", duration: 25000f);
                context.CameraSelectPath(pathIds: new []{1006, 1007}, returnView: false);
                context.MoveUser(mapId: 52000111, portalId: 10);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로Spawn씬04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬04 : TriggerState {
            internal State쉐도우클로Spawn씬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Assassin_Bore_A"});
                context.AddBalloonTalk(spawnId: 0, msg: "$52000111_QD__52000111__4$", duration: 6000, delayTick: 1000);
                context.CameraSelectPath(pathIds: new []{1012, 1013}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State쉐도우클로Spawn씬05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬05 : TriggerState {
            internal State쉐도우클로Spawn씬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, visible: true);
                context.CameraSelectPath(pathIds: new []{1014, 1015}, returnView: false);
                context.SpawnNpcRange(spawnIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, isAutoTargeting: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State쉐도우클로Spawn씬06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬06 : TriggerState {
            internal State쉐도우클로Spawn씬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8010}, visible: true);
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
                context.CameraSelectPath(pathIds: new []{1016, 1017}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State쉐도우클로Spawn씬07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬07 : TriggerState {
            internal State쉐도우클로Spawn씬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 200, sequenceName: "Sit_Down_A", duration: 4000f);
                context.CameraSelectPath(pathIds: new []{1018, 1019}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State쉐도우클로Spawn씬09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬09 : TriggerState {
            internal State쉐도우클로Spawn씬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 200, sequenceName: "Bore_A");
                context.CameraSelectPath(pathIds: new []{1020, 1021}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State쉐도우클로Spawn씬11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬11 : TriggerState {
            internal State쉐도우클로Spawn씬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{1022, 1023}, returnView: false);
                context.ShowCaption(type: CaptionType.Name, title: "$52000111_QD__52000111__5$", script: "$52000111_QD__52000111__6$", align: Align.Center, offsetRateX: -0.15f, offsetRateY: 0.15f, duration: 10000, scale: 2.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State쉐도우클로Spawn씬11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬11_1 : TriggerState {
            internal State쉐도우클로Spawn씬11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로Spawn씬12(context);
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
                context.MoveNpc(spawnId: 2000, patrolName: "MS2PatrolData_pcFront");
                context.MoveUser(mapId: 52000111, portalId: 10);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5311, 5312, 5313, 5314, 5315}, visible: false);
                context.SetEffect(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009}, visible: true);
                context.SpawnNpcRange(spawnIds: new []{202, 203, 204, 205, 206, 207, 208, 209, 210, 211}, isAutoTargeting: false);
                context.DestroyMonster(spawnIds: new []{200});
                context.CreateMonster(spawnIds: new []{200}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State쉐도우클로Spawn씬12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로Spawn씬12 : TriggerState {
            internal State쉐도우클로Spawn씬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(triggerIds: new []{8010}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 1.0f);
                context.SetEffect(triggerIds: new []{5300, 5301, 5302, 5303, 5304, 5305, 5306, 5307, 5308, 5309, 5310, 5312, 5313, 5314}, visible: false);
                context.DestroyMonster(spawnIds: new []{200});
                context.CreateMonster(spawnIds: new []{201}, arg2: false);
                context.ShowGuideSummary(entityId: 25201112, textId: 25201112, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002306}, questStates: new byte[]{1})) {
                    return new State쉐도우클로와떠남01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State쉐도우클로와떠남01 : TriggerState {
            internal State쉐도우클로와떠남01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.ShowGuideSummary(entityId: 25201113, textId: 25201113, duration: 5000);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출01 : TriggerState {
            internal StatePC대탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(triggerId: 9001, enabled: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(spawnIds: new []{300, 301, 302}, arg2: false);
                context.MoveUser(mapId: 52000111, portalId: 11);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new StatePC대탈출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출02 : TriggerState {
            internal StatePC대탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_3(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{1008, 1009}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Push_A", duration: 8000f);
                context.FaceEmotion(spawnId: 0, emotionName: "PC_Pain_86000");
                context.SetNpcEmotionLoop(spawnId: 300, sequenceName: "Sit_Down_A", duration: 17500f);
                context.SetNpcEmotionLoop(spawnId: 301, sequenceName: "Sit_Down_A", duration: 17500f);
                context.SetNpcEmotionLoop(spawnId: 302, sequenceName: "Sit_Down_A", duration: 17500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7800)) {
                    return new StatePC대탈출03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03 : TriggerState {
            internal StatePC대탈출03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_GO");
                context.CameraSelectPath(pathIds: new []{1010, 1011}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePC대탈출03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출03_1 : TriggerState {
            internal StatePC대탈출03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC대탈출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_3 : TriggerState {
            internal StateSkip_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.MoveUserPath(patrolName: "MS2PatrolData_PC_GO");
                context.SetPcEmotionLoop(sequenceName: "Idle_A", duration: 500f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePC대탈출04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePC대탈출04 : TriggerState {
            internal StatePC대탈출04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.AddBalloonTalk(spawnId: 0, msg: "$52000111_QD__52000111__7$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201114, textId: 25201114, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10011}, questIds: new []{20002314}, questStates: new byte[]{3})) {
                    return new State어쌔신탈출01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출01 : TriggerState {
            internal State어쌔신탈출01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State어쌔신탈출02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State어쌔신탈출02 : TriggerState {
            internal State어쌔신탈출02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000113, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
