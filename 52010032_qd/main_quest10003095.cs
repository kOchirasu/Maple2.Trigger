namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003095 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003095}, questStates: new byte[]{1})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.MoveUser(mapId: 52010032, portalId: 7001);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 100000000f);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Dead");
                context.DestroyMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State치유의식_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_01 : TriggerState {
            internal State치유의식_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__0$", duration: 4000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__1$", duration: 2000, delayTick: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State치유의식_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_02 : TriggerState {
            internal State치유의식_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_3002");
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Bore_A");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__2$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4500)) {
                    return new State치유의식_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_03 : TriggerState {
            internal State치유의식_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_B");
                context.SetEffect(triggerIds: new []{5001}, visible: true);
                context.SetPcEmotionLoop(sequenceName: "Emotion_Dance_Event01", duration: 7000f);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__3$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State치유의식_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_04 : TriggerState {
            internal State치유의식_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State치유의식_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_04_1 : TriggerState {
            internal State치유의식_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5001}, visible: false);
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Down_Idle_A", duration: 100000000f);
                context.AddCinematicTalk(npcId: 11003406, script: "$52010032_QD__MAIN_QUEST10003095__5$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__6$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003406, script: "$52010032_QD__MAIN_QUEST10003095__7$", duration: 3000);
                context.AddBalloonTalk(spawnId: 0, msg: "$52010032_QD__MAIN_QUEST10003095__8$", duration: 2000, delayTick: 6000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State치유의식_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_05 : TriggerState {
            internal State치유의식_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State치유의식_05_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State치유의식_05_1 : TriggerState {
            internal State치유의식_05_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraSelectPath(pathIds: new []{4003, 4001}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_B");
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
                context.SetNpcEmotionLoop(spawnId: 101, sequenceName: "Dead_Idle_A", duration: 100000000f);
                context.FaceEmotion(spawnId: 101, emotionName: "Trigger_Dead");
                context.SetPcEmotionSequence(sequenceNames: new []{"Talk_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52010032_QD__MAIN_QUEST10003095__9$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__10$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__11$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State의식종료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료_01 : TriggerState {
            internal State의식종료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 201, sequenceName: "Bore_A");
                context.MoveUserPath(patrolName: "MS2PatrolData_3007");
                context.AddCinematicTalk(npcId: 0, script: "$52010032_QD__MAIN_QUEST10003095__12$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003095__13$", duration: 3000);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State의식종료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State의식종료_02 : TriggerState {
            internal State의식종료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Namid2");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Namid2");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetEffect(triggerIds: new []{5001, 5002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.DestroyMonster(spawnIds: new []{201});
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
