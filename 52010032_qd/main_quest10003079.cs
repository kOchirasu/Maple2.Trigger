namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003079 {
        public class State무르파고스에들어오면 : TriggerState {
            internal State무르파고스에들어오면(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003079}, questStates: new byte[]{1})) {
                    context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{202, 301, 302});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateReady01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady01 : TriggerState {
            internal StateReady01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.FaceEmotion(spawnId: 401, emotionName: "Trigger_angry");
                context.CreateMonster(spawnIds: new []{401, 301, 302}, arg2: true);
                context.MoveNpc(spawnId: 301, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State대화시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작 : TriggerState {
            internal State대화시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Talk_A");
                context.MoveUser(mapId: 52010032, portalId: 6002);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__0$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__1$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__2$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__3$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 13000)) {
                    return new State대화시작01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작01 : TriggerState {
            internal State대화시작01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Talk_A");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__4$", duration: 4000);
                context.AddCinematicTalk(npcId: 0, script: "$52010032_QD__MAIN_QUEST10003079__5$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__6$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State대화시작02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작02 : TriggerState {
            internal State대화시작02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4008}, returnView: false);
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Focus_A"});
                context.AddCinematicTalk(npcId: 0, script: "$52010032_QD__MAIN_QUEST10003079__7$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State대화시작03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대화시작03 : TriggerState {
            internal State대화시작03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Bore_A");
                context.FaceEmotion(spawnId: 203, emotionName: "Trigger_Sad");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__8$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State에바고르삐짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐 : TriggerState {
            internal State에바고르삐짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010032_QD__MAIN_QUEST10003079__9$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010032_QD__MAIN_QUEST10003079__10$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에바고르삐짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐01 : TriggerState {
            internal State에바고르삐짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__11$", duration: 3000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010032_QD__MAIN_QUEST10003079__12$", duration: 2000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__13$", duration: 5000);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__14$", duration: 3500);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 14000)) {
                    return new State에바고르삐짐02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르삐짐02 : TriggerState {
            internal State에바고르삐짐02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4005}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 302, sequenceName: "Attack_01_A");
                context.AddCinematicTalk(npcId: 11003391, script: "$52010032_QD__MAIN_QUEST10003079__15$", duration: 4000);
                context.AddCinematicTalk(npcId: 11003391, script: "$52010032_QD__MAIN_QUEST10003079__16$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State에바고르Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르Exit : TriggerState {
            internal State에바고르Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4006}, returnView: false);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010032_QD__MAIN_QUEST10003079__17$", duration: 3000);
                context.MoveNpc(spawnId: 302, patrolName: "MS2PatrolData_3006");
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Namid");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State에바고르Exit후(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르Exit후 : TriggerState {
            internal State에바고르Exit후(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{4004}, returnView: false);
                context.SetNpcEmotionSequence(spawnId: 401, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__18$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003389, script: "$52010032_QD__MAIN_QUEST10003079__19$", duration: 3500);
                context.AddCinematicTalk(npcId: 11003388, script: "$52010032_QD__MAIN_QUEST10003079__20$", duration: 2000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State에바고르Exit후_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State에바고르Exit후_1 : TriggerState {
            internal State에바고르Exit후_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드에게Quest마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 4);
                context.DestroyMonster(spawnIds: new []{302, 401});
                context.CameraReset(interpolationTime: 0.5f);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Namid");
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State나메드에게Quest마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나메드에게Quest마무리 : TriggerState {
            internal State나메드에게Quest마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.DestroyMonster(spawnIds: new []{302, 401});
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
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
