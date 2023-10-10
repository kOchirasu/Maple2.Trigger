namespace Maple2.Trigger._63000030_cs {
    public static class _flyingcloud01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000, 5001, 5002, 5100, 5200, 5201, 5202, 5203, 5204, 5205, 5300, 5400, 6000, 6001, 6002, 6003, 6004, 6005, 6100, 6101, 6102, 6103, 6104, 6105, 6106}, visible: false);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: true);
                context.SetInteractObject(interactIds: new []{10001010}, state: 0);
                context.SetBreakable(triggerIds: new []{4000}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateEnter01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000455}, questStates: new byte[]{1})) {
                    return new StateQuestOnGiong21(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000454}, questStates: new byte[]{3})) {
                    return new StateQuestOnGiong11(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000454}, questStates: new byte[]{2})) {
                    return new StateQuestOnGiong01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9000}, questIds: new []{90000453}, questStates: new byte[]{3})) {
                    return new StateDelay01(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong21 : TriggerState {
            internal StateQuestOnGiong21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
                context.CreateMonster(spawnIds: new []{104, 204}, arg2: false);
                context.MoveUser(mapId: 63000030, portalId: 11, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestOnGiong22(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong22 : TriggerState {
            internal StateQuestOnGiong22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePatrolWhileTalking03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong11 : TriggerState {
            internal StateQuestOnGiong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
                context.CreateMonster(spawnIds: new []{103, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestOnGiong12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong12 : TriggerState {
            internal StateQuestOnGiong12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong01 : TriggerState {
            internal StateQuestOnGiong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
                context.CreateMonster(spawnIds: new []{103, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateQuestOnGiong02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong02 : TriggerState {
            internal StateQuestOnGiong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 201}, arg2: false);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_101");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_201");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLookAround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enabled: true);
                context.SetSceneSkip(state: new StateLookAround07_CSkip(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000030_CS__FLYINGCLOUD01__0$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_102");
                context.MoveNpc(spawnId: 201, patrolName: "MS2PatrolData_202");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateLookAround05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround05 : TriggerState {
            internal StateLookAround05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6100}, visible: true);
                context.SetConversation(type: 1, spawnId: 201, script: "$63000030_CS__FLYINGCLOUD01__1$", arg4: 2, arg5: 0);
                context.MoveNpc(spawnId: 920, patrolName: "MS2PatrolData_920");
                context.MoveNpc(spawnId: 923, patrolName: "MS2PatrolData_923");
                context.MoveNpc(spawnId: 925, patrolName: "MS2PatrolData_925");
                context.MoveNpc(spawnId: 927, patrolName: "MS2PatrolData_927");
                context.MoveNpc(spawnId: 928, patrolName: "MS2PatrolData_928");
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_931");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround06 : TriggerState {
            internal StateLookAround06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_922");
                context.MoveNpc(spawnId: 924, patrolName: "MS2PatrolData_924");
                context.MoveNpc(spawnId: 926, patrolName: "MS2PatrolData_926");
                context.MoveNpc(spawnId: 929, patrolName: "MS2PatrolData_929");
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_930");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround07_CSkip : TriggerState {
            internal StateLookAround07_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 920, patrolName: "MS2PatrolData_920");
                context.MoveNpc(spawnId: 923, patrolName: "MS2PatrolData_923");
                context.MoveNpc(spawnId: 925, patrolName: "MS2PatrolData_925");
                context.MoveNpc(spawnId: 927, patrolName: "MS2PatrolData_927");
                context.MoveNpc(spawnId: 928, patrolName: "MS2PatrolData_928");
                context.MoveNpc(spawnId: 931, patrolName: "MS2PatrolData_931");
                context.MoveNpc(spawnId: 921, patrolName: "MS2PatrolData_921");
                context.MoveNpc(spawnId: 922, patrolName: "MS2PatrolData_922");
                context.MoveNpc(spawnId: 924, patrolName: "MS2PatrolData_924");
                context.MoveNpc(spawnId: 926, patrolName: "MS2PatrolData_926");
                context.MoveNpc(spawnId: 929, patrolName: "MS2PatrolData_929");
                context.MoveNpc(spawnId: 930, patrolName: "MS2PatrolData_930");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateLookAround07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround07 : TriggerState {
            internal StateLookAround07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(spawnIds: new []{101, 201});
                context.CreateMonster(spawnIds: new []{102, 202}, arg2: false);
                context.CameraSelect(triggerId: 500, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetAgent(triggerIds: new []{8000, 8001, 8002, 8003, 8004, 8005, 8006, 8007, 8008, 8009, 8010, 8011, 8012}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBattleStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10037010, textId: 10037010);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931})) {
                    return new StateBattleEnd01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10037010);
            }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleEnd02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000030, portalId: 10, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{102, 202});
                context.CreateMonster(spawnIds: new []{103, 203}, arg2: false);
                context.CameraSelect(triggerId: 501, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateBattleEnd03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetSceneSkip(state: new StateDialogueSkip10(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateDialogue01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6101}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__FLYINGCLOUD01__2$", arg4: 7);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateDialogueSkip01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip01 : TriggerState {
            internal StateDialogueSkip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue02(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6000}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__3$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDialogueSkip02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip02 : TriggerState {
            internal StateDialogueSkip02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue03(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__4$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDialogueSkip03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip03 : TriggerState {
            internal StateDialogueSkip03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue04(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6102}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__FLYINGCLOUD01__5$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDialogueSkip04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip04 : TriggerState {
            internal StateDialogueSkip04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue05(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue05 : TriggerState {
            internal StateDialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__6$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateDialogueSkip05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip05 : TriggerState {
            internal StateDialogueSkip05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue06(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__7$", arg4: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateDialogueSkip06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip06 : TriggerState {
            internal StateDialogueSkip06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue07(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue07 : TriggerState {
            internal StateDialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6103}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__FLYINGCLOUD01__8$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDialogueSkip07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip07 : TriggerState {
            internal StateDialogueSkip07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue08(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue08 : TriggerState {
            internal StateDialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__9$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateDialogueSkip08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip08 : TriggerState {
            internal StateDialogueSkip08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateDialogue09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogue09 : TriggerState {
            internal StateDialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6104}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__FLYINGCLOUD01__10$", arg4: 8);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateDialogueSkip09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip09 : TriggerState {
            internal StateDialogueSkip09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 203, sequenceName: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override TriggerState? Execute() {
                return new StateDialogue10(context);
            }

            public override void OnExit() { }
        }

        private class StateDialogue10 : TriggerState {
            internal StateDialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6004}, visible: true);
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Talk_A");
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__11$", arg4: 5);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDialogueSkip10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip10 : TriggerState {
            internal StateDialogueSkip10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(spawnId: 103, sequenceName: "Idle_A");
                context.CameraSelect(triggerId: 501, enabled: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFirstQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestStart01 : TriggerState {
            internal StateFirstQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10030160, textId: 10030160);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000454}, questStates: new byte[]{2})) {
                    return new StateFirstQuestEnd01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10030160);
            }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10031010, textId: 10031010);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000454}, questStates: new byte[]{3})) {
                    return new StateSecondQuestStart01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031010);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000455}, questStates: new byte[]{1})) {
                    return new StatePatrolWhileTalking01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031020);
            }
        }

        private class StatePatrolWhileTalking01 : TriggerState {
            internal StatePatrolWhileTalking01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePatrolWhileTalking02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking02 : TriggerState {
            internal StatePatrolWhileTalking02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103, 203});
                context.CreateMonster(spawnIds: new []{104, 204}, arg2: false);
                context.MoveUser(mapId: 63000030, portalId: 11, boxId: 9900);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StatePatrolWhileTalking03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking03 : TriggerState {
            internal StatePatrolWhileTalking03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(state: new StateFightBack01(context), arg2: "nextState");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_103");
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_203");
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePatrolWhileTalking04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking04 : TriggerState {
            internal StatePatrolWhileTalking04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 204, script: "$63000030_CS__FLYINGCLOUD01__12$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 204, script: "$63000030_CS__FLYINGCLOUD01__13$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StatePatrolWhileTalking05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking05 : TriggerState {
            internal StatePatrolWhileTalking05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$63000030_CS__FLYINGCLOUD01__14$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 104, script: "$63000030_CS__FLYINGCLOUD01__15$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 104, script: "$63000030_CS__FLYINGCLOUD01__16$", arg4: 2, arg5: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new StateShadowApp01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp01 : TriggerState {
            internal StateShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5400}, visible: true);
                context.CreateMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949}, arg2: false);
                context.CameraSelect(triggerId: 600, enabled: true);
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_204");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowApp02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp02 : TriggerState {
            internal StateShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_104");
                context.SetEffect(triggerIds: new []{6105}, visible: true);
                context.SetConversation(type: 1, spawnId: 204, script: "$63000030_CS__FLYINGCLOUD01__17$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateShadowApp03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp03 : TriggerState {
            internal StateShadowApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateShadowApp04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp04 : TriggerState {
            internal StateShadowApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 104, script: "$63000030_CS__FLYINGCLOUD01__18$", arg4: 2, arg5: 0);
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateShadowApp05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateShadowApp05 : TriggerState {
            internal StateShadowApp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 601, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateFightBack01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFightBack01 : TriggerState {
            internal StateFightBack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 204, patrolName: "MS2PatrolData_205");
                context.SetEffect(triggerIds: new []{6106}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001557, script: "$63000030_CS__FLYINGCLOUD01__19$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateFightBack02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFightBack02 : TriggerState {
            internal StateFightBack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override TriggerState? Execute() {
                return new StateFightBack03(context);
            }

            public override void OnExit() { }
        }

        private class StateFightBack03 : TriggerState {
            internal StateFightBack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_105");
                context.SetEffect(triggerIds: new []{6005}, visible: true);
                context.SetConversation(type: 2, spawnId: 11001708, script: "$63000030_CS__FLYINGCLOUD01__20$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateFightBack04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFightBack04 : TriggerState {
            internal StateFightBack04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetEffect(triggerIds: new []{5400}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateFightBack05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFightBack05 : TriggerState {
            internal StateFightBack05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000030, portalId: 20, boxId: 9900);
                context.DestroyMonster(spawnIds: new []{940, 941, 942, 943, 944, 945, 946, 947, 948, 949});
                context.CreateMonster(spawnIds: new []{910, 911, 912, 913, 914, 915, 916, 917, 918, 919}, arg2: false);
                context.DestroyMonster(spawnIds: new []{104, 204});
                context.CreateMonster(spawnIds: new []{105, 205}, arg2: false);
                context.CameraSelect(triggerId: 602, enabled: true);
                context.SetUserValue(triggerId: 3, key: "SafetyStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateFightBack06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateFightBack06 : TriggerState {
            internal StateFightBack06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetUserValue(triggerId: 2, key: "PushStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGotoTria01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGotoTria01 : TriggerState {
            internal StateGotoTria01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 602, enabled: false);
                context.SetEffect(triggerIds: new []{5001, 5200, 5201, 5202, 5203, 5204, 5205, 5100}, visible: true);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
                context.ShowGuideSummary(entityId: 10037020, textId: 10037020);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateGotoTria02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10037020);
            }
        }

        private class StateGotoTria02 : TriggerState {
            internal StateGotoTria02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002, 5000}, visible: true);
                context.ShowGuideSummary(entityId: 10037030, textId: 10037030);
                context.SetInteractObject(interactIds: new []{10001010}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001010}, arg2: 0)) {
                    return new StateTakeOffFlyingCloud01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10037030);
                context.SetEffect(triggerIds: new []{5100, 5001, 5200, 5201, 5202, 5203, 5204, 5205}, visible: false);
            }
        }

        private class StateTakeOffFlyingCloud01 : TriggerState {
            internal StateTakeOffFlyingCloud01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetVisibleBreakableObject(triggerIds: new []{4000}, visible: true);
                context.SetBreakable(triggerIds: new []{4000}, enabled: true);
                context.SetInteractObject(interactIds: new []{10001010}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateTakeOffFlyingCloud02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud02 : TriggerState {
            internal StateTakeOffFlyingCloud02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300}, visible: true);
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(mapId: 63000030, portalId: 30, boxId: 9900);
                context.CameraSelect(triggerId: 700, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateTakeOffFlyingCloud03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud03 : TriggerState {
            internal StateTakeOffFlyingCloud03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 701, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateTakeOffFlyingCloud04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud04 : TriggerState {
            internal StateTakeOffFlyingCloud04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 63000036, portalId: 1);
                context.CameraSelect(triggerId: 701, enabled: false);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
