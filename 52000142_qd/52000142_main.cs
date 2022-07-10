using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000142_qd {
    public static class _52000142_main {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106}, arg2: false);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025, 5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039, 5040, 5041, 5042, 5043}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002721}, questStates: new byte[]{3})) {
                    return new State단계별이동_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002721}, questStates: new byte[]{2})) {
                    return new State단계별이동_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002720}, questStates: new byte[]{3})) {
                    return new State단계별이동_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002720}, questStates: new byte[]{2})) {
                    return new State단계별이동_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002720}, questStates: new byte[]{1})) {
                    return new StateQuest1진행_01(context);
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
                context.AddBuff(boxIds: new []{701}, skillId: 70000124, level: 1, arg4: false, arg5: false);
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
                context.PlaySceneMovie(fileName: @"common\JobIntro_Knight.usm", movieId: 1);
            }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.SceneMovie, condition: "IsStop", value: "1")) {
                    return new StateStart_01(context);
                }

                if (context.WaitTick(waitTick: 53000)) {
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
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구보훈련_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_01 : TriggerState {
            internal State구보훈련_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State구보훈련_01_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_01_1 : TriggerState {
            internal State구보훈련_01_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003, 8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구보훈련_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_02 : TriggerState {
            internal State구보훈련_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8004}, returnView: false);
                context.MoveUserPath(patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State구보훈련_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_03 : TriggerState {
            internal State구보훈련_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007}, returnView: false);
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__0$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State구보훈련_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_04_1 : TriggerState {
            internal State구보훈련_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State구보훈련_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State구보훈련_04 : TriggerState {
            internal State구보훈련_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25201421, textId: 25201421);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002720}, questStates: new byte[]{1})) {
                    return new StateQuest1진행_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State단계별이동_01 : TriggerState {
            internal State단계별이동_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.AddBuff(boxIds: new []{701}, skillId: 70000124, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State단계별이동_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State단계별이동_02 : TriggerState {
            internal State단계별이동_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000142, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002721}, questStates: new byte[]{3})) {
                    return new State퀘2완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002721}, questStates: new byte[]{2})) {
                    return new State퀘2완료가능(context);
                }

                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002720}, questStates: new byte[]{3})) {
                    return new State퀘1완료(context);
                }

                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002720}, questStates: new byte[]{2})) {
                    return new State퀘1완료가능(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘2완료 : TriggerState {
            internal State퀘2완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 106});
                context.CreateMonster(spawnIds: new []{108, 109}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 109, sequenceName: "Emotion_lie_facedown_Idle_A", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘2완료가능 : TriggerState {
            internal State퀘2완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 106, 107});
                context.CreateMonster(spawnIds: new []{108, 109}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 109, sequenceName: "Emotion_lie_facedown_Idle_A", duration: 600000f);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State수호사제찾기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘1완료 : TriggerState {
            internal State퀘1완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106});
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 107, sequenceName: "Down_Idle_B", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퀘1완료가능 : TriggerState {
            internal State퀘1완료가능(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106});
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1진행_01 : TriggerState {
            internal StateQuest1진행_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106});
                context.HideGuideSummary(entityId: 25201421);
                context.ShowGuideSummary(entityId: 25201422, textId: 25201422);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025}, visible: true);
                context.AddBuff(boxIds: new []{701}, skillId: 70000124, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002720}, questStates: new byte[]{2})) {
                    return new StateQuest1완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1완료가능_01 : TriggerState {
            internal StateQuest1완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5010, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019, 5020, 5021, 5022, 5023, 5024, 5025}, visible: false);
                context.HideGuideSummary(entityId: 25201422);
                context.ShowGuideSummary(entityId: 25201423, textId: 25201423);
                context.CreateMonster(spawnIds: new []{107}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 107, sequenceName: "Down_Idle_B", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002720}, questStates: new byte[]{3})) {
                    return new StateQuest1완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1완료_01 : TriggerState {
            internal StateQuest1완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201423);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1완료_02 : TriggerState {
            internal StateQuest1완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000142, portalId: 99);
                context.DestroyMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest1완료_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest1완료_03 : TriggerState {
            internal StateQuest1완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State로베와대화1_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_01 : TriggerState {
            internal State로베와대화1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State벌칙_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__1$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화1_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_02 : TriggerState {
            internal State로베와대화1_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__2$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화1_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_03 : TriggerState {
            internal State로베와대화1_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__3$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화1_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_04 : TriggerState {
            internal State로베와대화1_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__4$", duration: 4000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State로베와대화1_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_05 : TriggerState {
            internal State로베와대화1_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__5$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화1_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_06 : TriggerState {
            internal State로베와대화1_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__6$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__7$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__8$", duration: 4000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new State로베와대화1_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_07 : TriggerState {
            internal State로베와대화1_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__9$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State로베와대화1_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State로베와대화1_08 : TriggerState {
            internal State로베와대화1_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__10$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State동료의비웃음_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_01 : TriggerState {
            internal State동료의비웃음_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 102, script: "$52000142_QD__52000142_MAIN__11$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State동료의비웃음_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_02 : TriggerState {
            internal State동료의비웃음_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 103, script: "$52000142_QD__52000142_MAIN__12$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State동료의비웃음_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State동료의비웃음_03 : TriggerState {
            internal State동료의비웃음_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$52000142_QD__52000142_MAIN__13$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State해명에도불구_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_01 : TriggerState {
            internal State해명에도불구_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__14$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State해명에도불구_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_02 : TriggerState {
            internal State해명에도불구_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__15$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State해명에도불구_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State해명에도불구_03 : TriggerState {
            internal State해명에도불구_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__16$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State벌칙_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_01 : TriggerState {
            internal State벌칙_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 999, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벌칙_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_02 : TriggerState {
            internal State벌칙_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 9, script: "$52000142_QD__52000142_MAIN__17$");
                context.DestroyMonster(spawnIds: new []{102, 103, 104, 107});
                context.CreateMonster(spawnIds: new []{109}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 109, sequenceName: "Emotion_lie_facedown_Idle_A", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State벌칙_03(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 2);
            }
        }

        private class State벌칙_03 : TriggerState {
            internal State벌칙_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 999, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_0sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벌칙_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_04 : TriggerState {
            internal State벌칙_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State수호사제찾기_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__18$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State벌칙_04_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_04_1 : TriggerState {
            internal State벌칙_04_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벌칙_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_05 : TriggerState {
            internal State벌칙_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__19$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State벌칙_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_06 : TriggerState {
            internal State벌칙_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003399, script: "$52000142_QD__52000142_MAIN__20$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State벌칙_06_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_06_1 : TriggerState {
            internal State벌칙_06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벌칙_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_07 : TriggerState {
            internal State벌칙_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__21$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State벌칙_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_08 : TriggerState {
            internal State벌칙_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__22$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State벌칙_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_09 : TriggerState {
            internal State벌칙_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__23$", duration: 4000, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__24$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__25$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State벌칙_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벌칙_10 : TriggerState {
            internal State벌칙_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__26$", duration: 3500, align: Align.Right);
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__27$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State수호사제찾기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수호사제찾기_01 : TriggerState {
            internal State수호사제찾기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.ShowGuideSummary(entityId: 25201424, textId: 25201424);
                context.SetEffect(triggerIds: new []{5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039}, visible: true);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703})) {
                    return new State수호사제찾기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State수호사제찾기_02 : TriggerState {
            internal State수호사제찾기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5026, 5027, 5028, 5029, 5030, 5031, 5032, 5033, 5034, 5035, 5036, 5037, 5038, 5039}, visible: false);
                context.HideGuideSummary(entityId: 25201424);
                context.ShowGuideSummary(entityId: 25201425, textId: 25201425);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{703}, questIds: new []{40002721}, questStates: new byte[]{2})) {
                    return new StateQuest2완료가능_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료가능_01 : TriggerState {
            internal StateQuest2완료가능_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201425);
                context.ShowGuideSummary(entityId: 25201426, textId: 25201426);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{703}, questIds: new []{40002721}, questStates: new byte[]{3})) {
                    return new StateQuest2완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료_01 : TriggerState {
            internal StateQuest2완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
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
                context.DestroyMonster(spawnIds: new []{105});
                context.CreateMonster(spawnIds: new []{110}, arg2: false);
                context.MoveUser(mapId: 52000142, portalId: 99);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuest2완료_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest2완료_03 : TriggerState {
            internal StateQuest2완료_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State란스구하기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_01 : TriggerState {
            internal State란스구하기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new State란스구하기스킵_01(context), arg2: "nextState");
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__28$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_02 : TriggerState {
            internal State란스구하기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__29$", duration: 3500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_03 : TriggerState {
            internal State란스구하기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__30$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State란스구하기_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_04 : TriggerState {
            internal State란스구하기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Talk_A", duration: 8000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State란스구하기_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_05 : TriggerState {
            internal State란스구하기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__31$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__32$", duration: 3500, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7500)) {
                    return new State란스구하기_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_06 : TriggerState {
            internal State란스구하기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003399, script: "$52000142_QD__52000142_MAIN__33$", duration: 1000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State란스구하기_06_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_06_1 : TriggerState {
            internal State란스구하기_06_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2006");
                context.DestroyMonster(spawnIds: new []{109});
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Down_Idle_B", duration: 600000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State란스구하기_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_07 : TriggerState {
            internal State란스구하기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State란스구하기_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_08 : TriggerState {
            internal State란스구하기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
                context.MoveUserPath(patrolName: "MS2PatrolData_2002");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000142_QD__52000142_MAIN__34$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State란스구하기_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_09 : TriggerState {
            internal State란스구하기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 108, script: "$52000142_QD__52000142_MAIN__35$", arg4: 3, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State란스구하기_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_10 : TriggerState {
            internal State란스구하기_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__36$", duration: 4000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State란스구하기_10_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_10_1 : TriggerState {
            internal State란스구하기_10_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State란스구하기_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_11 : TriggerState {
            internal State란스구하기_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 110, sequenceName: "Bore_B");
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__37$", duration: 5720, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5720)) {
                    return new State란스구하기_11_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_11_1 : TriggerState {
            internal State란스구하기_11_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State란스구하기_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_12 : TriggerState {
            internal State란스구하기_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__38$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__39$", duration: 2500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State란스구하기_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_13 : TriggerState {
            internal State란스구하기_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_2004");
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__40$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_14 : TriggerState {
            internal State란스구하기_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__41$", duration: 5903, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8698)) {
                    return new State란스구하기_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_15 : TriggerState {
            internal State란스구하기_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData_2005");
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__42$", duration: 5955, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5955)) {
                    return new State란스구하기_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_16 : TriggerState {
            internal State란스구하기_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__43$", duration: 3500, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_17 : TriggerState {
            internal State란스구하기_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__44$", duration: 3500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_18 : TriggerState {
            internal State란스구하기_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000142_QD__52000142_MAIN__45$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_19 : TriggerState {
            internal State란스구하기_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__46$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State란스구하기_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_20 : TriggerState {
            internal State란스구하기_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__47$", duration: 3000, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__48$", duration: 2500, align: Align.Left);
                context.AddCinematicTalk(npcId: 11003403, script: "$52000142_QD__52000142_MAIN__49$", duration: 3500, align: Align.Left);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new State란스구하기_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기_21 : TriggerState {
            internal State란스구하기_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003401, script: "$52000142_QD__52000142_MAIN__50$", duration: 3000, illustId: "Robe_normal", align: Align.Right);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기스킵_01 : TriggerState {
            internal State란스구하기스킵_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{109});
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Down_Idle_B", duration: 600000f);
                context.CameraReset(interpolationTime: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State란스구하기스킵_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State란스구하기스킵_02 : TriggerState {
            internal State란스구하기스킵_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State퇴장_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장_01 : TriggerState {
            internal State퇴장_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 108, patrolName: "MS2PatrolData_2003");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State퇴장_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State퇴장_02 : TriggerState {
            internal State퇴장_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{108});
                context.ShowGuideSummary(entityId: 25201427, textId: 25201427);
                context.SetEffect(triggerIds: new []{5040, 5041, 5042, 5043}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{704})) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25201427);
                context.RemoveBuff(boxId: 704, skillId: 70000124);
                context.SetEffect(triggerIds: new []{5040, 5041, 5042, 5043}, visible: false);
                context.MoveUser(mapId: 52000143, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
