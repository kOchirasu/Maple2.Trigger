using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000145_qd {
    public static class _52000145_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{101}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002711}, questStates: new byte[]{3})) {
                    return new StateQuest2완료_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002711}, questStates: new byte[]{2})) {
                    return new StateQuest2진행_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002711}, questStates: new byte[]{1})) {
                    return new StateQuest2시작_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002710}, questStates: new byte[]{3})) {
                    return new StateQuest1완료가능_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002710}, questStates: new byte[]{2})) {
                    return new StateQuest1진행_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002710}, questStates: new byte[]{1})) {
                    return new StateQuest1수락_02(context);
                }

                if (context.UserDetected(boxIds: new []{701})) {
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
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State영상재생_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State영상재생_01 : TriggerState {
            internal State영상재생_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.SceneMovie);
                context.WidgetAction(type: WidgetType.SceneMovie, name: "Clear");
                context.PlaySceneMovie(fileName: @"common\JobIntro_Ranger.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new State독백_01(context);
                }

                if (context.WaitTick(waitTick: 45000)) {
                    return new State독백_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State독백_01 : TriggerState {
            internal State독백_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000145_QD__52000145_MAIN__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_01 : TriggerState {
            internal StateStart_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUser(mapId: 52000145, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State하스터숙면_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_01 : TriggerState {
            internal State하스터숙면_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__1$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State하스터숙면_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_02 : TriggerState {
            internal State하스터숙면_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__2$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State하스터숙면_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_03 : TriggerState {
            internal State하스터숙면_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State하스터숙면_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_04 : TriggerState {
            internal State하스터숙면_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateQuest1수락_01(context), arg2: "nextState");
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 3000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__3$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State하스터숙면_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_05 : TriggerState {
            internal State하스터숙면_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__4$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State하스터숙면_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State하스터숙면_06 : TriggerState {
            internal State하스터숙면_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0, emotionName: "Think_A");
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateQuest1수락_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1수락_01 : TriggerState {
            internal StateQuest1수락_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuest1수락_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1수락_02 : TriggerState {
            internal StateQuest1수락_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201456, textId: 25201456);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002710}, questStates: new byte[]{1})) {
                    return new StateQuest1진행_00(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201456);
            }
        }

        private class StateQuest1진행_00 : TriggerState {
            internal StateQuest1진행_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1진행_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1진행_01 : TriggerState {
            internal StateQuest1진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201451, textId: 25201451);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002710}, questStates: new byte[]{2})) {
                    return new StateQuest1완료가능_00(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201451);
            }
        }

        private class StateQuest1완료가능_00 : TriggerState {
            internal StateQuest1완료가능_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1완료가능_01 : TriggerState {
            internal StateQuest1완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201452, textId: 25201452);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002710}, questStates: new byte[]{3})) {
                    return new StateQuest1완료_01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201452);
            }
        }

        private class StateQuest1완료_01 : TriggerState {
            internal StateQuest1완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2시작_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2시작_01 : TriggerState {
            internal StateQuest2시작_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201453, textId: 25201453);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002711}, questStates: new byte[]{1})) {
                    return new StateQuest2진행_00(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201453);
            }
        }

        private class StateQuest2진행_00 : TriggerState {
            internal StateQuest2진행_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2진행_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2진행_01 : TriggerState {
            internal StateQuest2진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201454, textId: 25201454);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 703}, questIds: new []{40002711}, questStates: new byte[]{2})) {
                    return new StateQuest2완료가능_00(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 25201454);
            }
        }

        private class StateQuest2완료가능_00 : TriggerState {
            internal StateQuest2완료가능_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료가능_01 : TriggerState {
            internal StateQuest2완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201455, textId: 25201455);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701, 702}, questIds: new []{40002711}, questStates: new byte[]{3})) {
                    return new StateQuest2완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료_01 : TriggerState {
            internal StateQuest2완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201455);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료_02 : TriggerState {
            internal StateQuest2완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.MoveUser(mapId: 52000145, portalId: 99);
                context.CreateMonster(spawnIds: new []{103}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State오스칼Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_01 : TriggerState {
            internal State오스칼Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Troubled_A"});
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State오스칼Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_02 : TriggerState {
            internal State오스칼Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Emotion_Suprise_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스칼Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_03 : TriggerState {
            internal State오스칼Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State마무리(context), arg2: "exit");
                context.FaceEmotion(spawnId: 0, emotionName: "Think_A");
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__7$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오스칼Spawn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_04 : TriggerState {
            internal State오스칼Spawn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__8$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오스칼Spawn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_05 : TriggerState {
            internal State오스칼Spawn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__9$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__10$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State오스칼Spawn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_06 : TriggerState {
            internal State오스칼Spawn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__11$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5485)) {
                    return new State오스칼Spawn_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_07 : TriggerState {
            internal State오스칼Spawn_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스칼Spawn_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_08 : TriggerState {
            internal State오스칼Spawn_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__12$", duration: 3000, align: Align.Left);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 102, sequenceName: "Sit_Down_A", duration: 70000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_08_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_08_1 : TriggerState {
            internal State오스칼Spawn_08_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__13$", duration: 2500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State오스칼Spawn_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_09 : TriggerState {
            internal State오스칼Spawn_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State오스칼Spawn_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_10 : TriggerState {
            internal State오스칼Spawn_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__14$", duration: 4000, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State오스칼Spawn_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_11 : TriggerState {
            internal State오스칼Spawn_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__15$", duration: 3000, illustId: "Oskhal_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_12 : TriggerState {
            internal State오스칼Spawn_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__16$", duration: 3500, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_13 : TriggerState {
            internal State오스칼Spawn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__17$", duration: 2500, illustId: "Oskhal_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__18$", duration: 3500, illustId: "Oskhal_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__19$", duration: 3000, illustId: "Oskhal_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new State오스칼Spawn_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_14 : TriggerState {
            internal State오스칼Spawn_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__20$", duration: 3000, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_15 : TriggerState {
            internal State오스칼Spawn_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__21$", duration: 3500, illustId: "Oskhal_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5172)) {
                    return new State오스칼Spawn_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_16 : TriggerState {
            internal State오스칼Spawn_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__22$", duration: 3000, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_17 : TriggerState {
            internal State오스칼Spawn_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__23$", duration: 2500, illustId: "Oskhal_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__24$", duration: 3500, illustId: "Oskhal_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__25$", duration: 2500, illustId: "Oskhal_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9742)) {
                    return new State오스칼Spawn_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_18 : TriggerState {
            internal State오스칼Spawn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__26$", duration: 3000, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_19 : TriggerState {
            internal State오스칼Spawn_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003380, script: "$52000145_QD__52000145_MAIN__27$", duration: 3000, illustId: "Oskhal_normal", align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3631)) {
                    return new State오스칼Spawn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_20 : TriggerState {
            internal State오스칼Spawn_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003189, script: "$52000145_QD__52000145_MAIN__28$", duration: 3500, illustId: "Hastur_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State오스칼Spawn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오스칼Spawn_21 : TriggerState {
            internal State오스칼Spawn_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.FaceEmotion(spawnId: 0);
                context.AddCinematicTalk(npcId: 0, script: "$52000145_QD__52000145_MAIN__29$", duration: 2500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000146, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
