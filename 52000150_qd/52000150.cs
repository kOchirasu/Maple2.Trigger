using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000150_qd {
    public static class _52000150 {
        public class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2605}, visible: false);
                context.SetEffect(triggerIds: new []{2607}, visible: true);
                context.CreateMonster(spawnIds: new []{202, 200, 201}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001642}, questStates: new byte[]{1})) {
                    return new StateQuest완료상태에서접속(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{3})) {
                    return new StateQuest완료상태에서접속(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{2})) {
                    return new StateQuest완료상태에서접속(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{1})) {
                    return new StateSkip_1(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001640}, questStates: new byte[]{3})) {
                    return new StateWait02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001640}, questStates: new byte[]{2})) {
                    return new StateWait02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State차원의숲전경씬01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬01 : TriggerState {
            internal State차원의숲전경씬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000150, portalId: 11);
                context.CameraSelectPath(pathIds: new []{1000, 1001, 1004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new State차원의숲전경씬02_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬02_b : TriggerState {
            internal State차원의숲전경씬02_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State차원의숲전경씬02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬02 : TriggerState {
            internal State차원의숲전경씬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.CameraSelectPath(pathIds: new []{1002, 1003}, returnView: false);
                context.ShowCaption(type: CaptionType.Vertical, title: "$52000150_QD__52000150__8$", script: "$52000150_QD__52000150__9$", align: Align.Bottom | Align.Left, offsetRateX: 0f, offsetRateY: 0f, duration: 5500, scale: 2.5f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State차원의숲전경씬03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬03 : TriggerState {
            internal State차원의숲전경씬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State차원의숲전경씬03_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬03_1 : TriggerState {
            internal State차원의숲전경씬03_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State차원의숲전경씬종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.MoveUser(mapId: 52000150, portalId: 11);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State차원의숲전경씬종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State차원의숲전경씬종료 : TriggerState {
            internal State차원의숲전경씬종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.MoveNpc(spawnId: 202, patrolName: "MS2PatrolData_caitMove01");
                context.AddBalloonTalk(spawnId: 202, msg: "$52000150_QD__52000150__0$", duration: 6000, delayTick: 1000);
                context.ShowGuideSummary(entityId: 25201501, textId: 25201501, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{3})) {
                    return new State아노스흑화01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{2})) {
                    return new StateQuest완료상태에서접속(context);
                }

                if (context.QuestUserDetected(boxIds: new []{10010}, questIds: new []{50001641}, questStates: new byte[]{1})) {
                    return new State결계흑화Cinematic01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic01 : TriggerState {
            internal State결계흑화Cinematic01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_2(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000150, portalId: 10);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State결계흑화Cinematic02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic02 : TriggerState {
            internal State결계흑화Cinematic02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State결계흑화Cinematic03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic03 : TriggerState {
            internal State결계흑화Cinematic03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2608}, visible: true);
                context.CameraSelectPath(pathIds: new []{3001, 3000}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Traped_A,Traped_Idle");
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11003439, script: "$52000150_QD__52000150__1$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    return new State결계흑화Cinematic03_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic03_b : TriggerState {
            internal State결계흑화Cinematic03_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 202, emotionName: "Bore_A");
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Traped_Idle", duration: 999999f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4200)) {
                    return new State결계흑화Cinematic04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic04 : TriggerState {
            internal State결계흑화Cinematic04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 202, sequenceName: "Bore_A");
                context.CameraSelectPath(pathIds: new []{3002, 3003}, returnView: false);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__2$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State결계흑화Cinematic05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic05 : TriggerState {
            internal State결계흑화Cinematic05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Attack_Idle_A", duration: 999999f);
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.CameraSelectPath(pathIds: new []{3004, 3005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__3$", duration: 5000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State결계흑화Cinematic06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic06 : TriggerState {
            internal State결계흑화Cinematic06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.CameraSelectPath(pathIds: new []{3006, 3007}, returnView: false);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: true, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: true, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: true, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: true, arg3: 600, arg4: 200);
                context.CreateMonster(spawnIds: new []{400, 401, 402, 403, 404}, arg2: false, arg3: 21000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State결계흑화Cinematic07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic07 : TriggerState {
            internal State결계흑화Cinematic07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: true, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: true, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: true, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(pathIds: new []{3008, 3009, 3010}, returnView: false);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__4$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State결계흑화Cinematic08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic08 : TriggerState {
            internal State결계흑화Cinematic08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: true, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: true, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: true, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: true, arg3: 600, arg4: 200);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__5$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State결계흑화Cinematic09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic09 : TriggerState {
            internal State결계흑화Cinematic09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: true, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: true, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: true, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(pathIds: new []{3011, 3012}, returnView: false);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__6$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State결계흑화Cinematic10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic10 : TriggerState {
            internal State결계흑화Cinematic10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2606}, visible: true);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: true, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: true, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: true, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: true, arg3: 600, arg4: 200);
                context.CameraSelectPath(pathIds: new []{3013}, returnView: false);
                context.AddCinematicTalk(npcId: 11003442, script: "$52000150_QD__52000150__7$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State결계흑화Cinematic10_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic10_1 : TriggerState {
            internal State결계흑화Cinematic10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State결계흑화Cinematic11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_2 : TriggerState {
            internal StateSkip_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{2605, 2606, 2607, 2608}, visible: false);
                context.SetEffect(triggerIds: new []{2300, 2301, 2302, 2303, 2304}, visible: false, arg3: 0, arg4: 200);
                context.SetEffect(triggerIds: new []{2400, 2401, 2402, 2403, 2404}, visible: false, arg3: 200, arg4: 200);
                context.SetEffect(triggerIds: new []{2500, 2501, 2502, 2503, 2504}, visible: false, arg3: 400, arg4: 200);
                context.SetEffect(triggerIds: new []{2600, 2601, 2602, 2603, 2604}, visible: false, arg3: 600, arg4: 200);
                context.MoveUser(mapId: 52000150, portalId: 10);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetNpcEmotionLoop(spawnId: 201, sequenceName: "Traped_Idle", duration: 999999f);
                context.DestroyMonster(spawnIds: new []{400, 401, 402, 403, 404});
                context.CreateMonster(spawnIds: new []{400, 401, 402, 403, 404}, arg2: false, arg3: 100);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State결계흑화Cinematic11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State결계흑화Cinematic11 : TriggerState {
            internal State결계흑화Cinematic11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CameraReset(interpolationTime: 0.0f);
                context.SetSound(triggerId: 9000, enabled: true);
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{700}, arg2: false);
                context.SetUserValue(triggerId: 10001, key: "52000150", value: 1);
                context.ShowGuideSummary(entityId: 25201502, textId: 25201502, duration: 10000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스흑화Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화Prepare : TriggerState {
            internal State아노스흑화Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 10001, key: "52000150", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "52000150monster") == 1) {
                    return new State아노스흑화Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화Wait : TriggerState {
            internal State아노스흑화Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetEffect(triggerIds: new []{2605, 2606, 2607, 2608}, visible: false);
                context.MoveUser(mapId: 52000150, portalId: 10);
                context.DestroyMonster(spawnIds: new []{200}, arg2: false);
                context.DestroyMonster(spawnIds: new []{201}, arg2: false);
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{200, 201, 700}, arg2: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화전Script01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script01 : TriggerState {
            internal State아노스흑화전Script01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State아노스흑화09(context), arg2: "exit");
                context.CameraSelectPath(pathIds: new []{3005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003440, script: "$52000150_QD__52000150__11$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State아노스흑화전Script02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script02 : TriggerState {
            internal State아노스흑화전Script02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "Caitlyn_serious", script: "$52000150_QD__52000150__12$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화전Script03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script03 : TriggerState {
            internal State아노스흑화전Script03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6000, 6001}, returnView: false);
                context.AddCinematicTalk(npcId: 11003440, script: "$52000150_QD__52000150__13$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화전Script04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script04 : TriggerState {
            internal State아노스흑화전Script04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003442, illustId: "Caitlyn_serious", script: "$52000150_QD__52000150__14$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화전Script05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script05 : TriggerState {
            internal State아노스흑화전Script05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003438, illustId: "Horrhe_normal", script: "$52000150_QD__52000150__15$", duration: 3000, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화전Script06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화전Script06 : TriggerState {
            internal State아노스흑화전Script06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6000}, returnView: false);
                context.AddCinematicTalk(npcId: 11003440, script: "$52000150_QD__52000150__16$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료상태에서접속 : TriggerState {
            internal StateQuest완료상태에서접속(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스흑화09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화01 : TriggerState {
            internal State아노스흑화01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetEffect(triggerIds: new []{2607}, visible: false);
                context.SetCinematicUI(type: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화02 : TriggerState {
            internal State아노스흑화02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new []{6000, 6001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 200, sequenceName: "Event_02_A,Event_02_Idle");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화03 : TriggerState {
            internal State아노스흑화03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6002, 6003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State아노스흑화04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화04 : TriggerState {
            internal State아노스흑화04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6004, 6005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스흑화05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화05 : TriggerState {
            internal State아노스흑화05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{2605}, visible: true);
                context.DestroyMonster(spawnIds: new []{200});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State아노스흑화06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화06 : TriggerState {
            internal State아노스흑화06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{6006, 6007, 6008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State아노스흑화07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화07 : TriggerState {
            internal State아노스흑화07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimeScale(enabled: true, startScale: 0.5f, endScale: 0.3f, duration: 15.0f, interpolator: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 12000)) {
                    return new State아노스흑화08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화08 : TriggerState {
            internal State아노스흑화08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FadeInOut1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State아노스흑화08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화08_1 : TriggerState {
            internal State아노스흑화08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State아노스흑화09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아노스흑화09 : TriggerState {
            internal State아노스흑화09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000151, portalId: 10);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
