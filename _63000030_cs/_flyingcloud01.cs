using System;

namespace Maple2.Trigger._63000030_cs {
    public static class _flyingcloud01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.SetEffect(arg1: new int[] {6003}, arg2: false);
                context.SetEffect(arg1: new int[] {6004}, arg2: false);
                context.SetEffect(arg1: new int[] {6005}, arg2: false);
                context.SetEffect(arg1: new int[] {6100}, arg2: false);
                context.SetEffect(arg1: new int[] {6101}, arg2: false);
                context.SetEffect(arg1: new int[] {6102}, arg2: false);
                context.SetEffect(arg1: new int[] {6103}, arg2: false);
                context.SetEffect(arg1: new int[] {6104}, arg2: false);
                context.SetEffect(arg1: new int[] {6105}, arg2: false);
                context.SetEffect(arg1: new int[] {6106}, arg2: false);
                context.SetAgent(arg1: "8000", arg2: true);
                context.SetAgent(arg1: "8001", arg2: true);
                context.SetAgent(arg1: "8002", arg2: true);
                context.SetAgent(arg1: "8003", arg2: true);
                context.SetAgent(arg1: "8004", arg2: true);
                context.SetAgent(arg1: "8005", arg2: true);
                context.SetAgent(arg1: "8006", arg2: true);
                context.SetAgent(arg1: "8007", arg2: true);
                context.SetAgent(arg1: "8008", arg2: true);
                context.SetAgent(arg1: "8009", arg2: true);
                context.SetAgent(arg1: "8010", arg2: true);
                context.SetAgent(arg1: "8011", arg2: true);
                context.SetAgent(arg1: "8012", arg2: true);
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 0);
                context.SetBreakable(arg1: new int[] {4000}, arg2: false);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: false);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new StateEnter01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter01 : TriggerState {
            internal StateEnter01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000455},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGiong21(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000454},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGiong11(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000454},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGiong01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000453},
                    arg3: new byte[] {3})) {
                    context.State = new StateDelay01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong21 : TriggerState {
            internal StateQuestOnGiong21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.CreateMonster(arg1: new int[] {104, 204}, arg2: false);
                context.MoveUser(arg1: 63000030, arg2: 11, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestOnGiong22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong22 : TriggerState {
            internal StateQuestOnGiong22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrolWhileTalking03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong11 : TriggerState {
            internal StateQuestOnGiong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.CreateMonster(arg1: new int[] {103, 203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestOnGiong12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong12 : TriggerState {
            internal StateQuestOnGiong12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong01 : TriggerState {
            internal StateQuestOnGiong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
                context.CreateMonster(arg1: new int[] {103, 203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestOnGiong02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGiong02 : TriggerState {
            internal StateQuestOnGiong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFirstQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931},
                    arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLookAround02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 201}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLookAround03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "LookAround07_CSkip", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000030_CS__FLYINGCLOUD01__0$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround05 : TriggerState {
            internal StateLookAround05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6100}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$63000030_CS__FLYINGCLOUD01__1$", arg4: 2, arg5: 0);
                context.MoveNpc(arg1: 920, arg2: "MS2PatrolData_920");
                context.MoveNpc(arg1: 923, arg2: "MS2PatrolData_923");
                context.MoveNpc(arg1: 925, arg2: "MS2PatrolData_925");
                context.MoveNpc(arg1: 927, arg2: "MS2PatrolData_927");
                context.MoveNpc(arg1: 928, arg2: "MS2PatrolData_928");
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_931");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround06 : TriggerState {
            internal StateLookAround06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_922");
                context.MoveNpc(arg1: 924, arg2: "MS2PatrolData_924");
                context.MoveNpc(arg1: 926, arg2: "MS2PatrolData_926");
                context.MoveNpc(arg1: 929, arg2: "MS2PatrolData_929");
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_930");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround07_CSkip : TriggerState {
            internal StateLookAround07_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 920, arg2: "MS2PatrolData_920");
                context.MoveNpc(arg1: 923, arg2: "MS2PatrolData_923");
                context.MoveNpc(arg1: 925, arg2: "MS2PatrolData_925");
                context.MoveNpc(arg1: 927, arg2: "MS2PatrolData_927");
                context.MoveNpc(arg1: 928, arg2: "MS2PatrolData_928");
                context.MoveNpc(arg1: 931, arg2: "MS2PatrolData_931");
                context.MoveNpc(arg1: 921, arg2: "MS2PatrolData_921");
                context.MoveNpc(arg1: 922, arg2: "MS2PatrolData_922");
                context.MoveNpc(arg1: 924, arg2: "MS2PatrolData_924");
                context.MoveNpc(arg1: 926, arg2: "MS2PatrolData_926");
                context.MoveNpc(arg1: 929, arg2: "MS2PatrolData_929");
                context.MoveNpc(arg1: 930, arg2: "MS2PatrolData_930");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround07 : TriggerState {
            internal StateLookAround07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new int[] {101, 201});
                context.CreateMonster(arg1: new int[] {102, 202}, arg2: false);
                context.CameraSelect(arg1: 500, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetAgent(arg1: "8000", arg2: false);
                context.SetAgent(arg1: "8001", arg2: false);
                context.SetAgent(arg1: "8002", arg2: false);
                context.SetAgent(arg1: "8003", arg2: false);
                context.SetAgent(arg1: "8004", arg2: false);
                context.SetAgent(arg1: "8005", arg2: false);
                context.SetAgent(arg1: "8006", arg2: false);
                context.SetAgent(arg1: "8007", arg2: false);
                context.SetAgent(arg1: "8008", arg2: false);
                context.SetAgent(arg1: "8009", arg2: false);
                context.SetAgent(arg1: "8010", arg2: false);
                context.SetAgent(arg1: "8011", arg2: false);
                context.SetAgent(arg1: "8012", arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBattleStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleStart01 : TriggerState {
            internal StateBattleStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10037010, textID: 10037010);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {920, 921, 922, 923, 924, 925, 926, 927, 928, 929, 930, 931})) {
                    context.State = new StateBattleEnd01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10037010);
            }
        }

        private class StateBattleEnd01 : TriggerState {
            internal StateBattleEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBattleEnd02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd02 : TriggerState {
            internal StateBattleEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000030, arg2: 10, arg3: 9900);
                context.DestroyMonster(arg1: new int[] {102, 202});
                context.CreateMonster(arg1: new int[] {103, 203}, arg2: false);
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateBattleEnd03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBattleEnd03 : TriggerState {
            internal StateBattleEnd03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetSceneSkip(arg1: "DialogueSkip10", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6101}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__FLYINGCLOUD01__2$", arg4: 7);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateDialogueSkip01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip01 : TriggerState {
            internal StateDialogueSkip01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__3$", arg4: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogueSkip02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip02 : TriggerState {
            internal StateDialogueSkip02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue03 : TriggerState {
            internal StateDialogue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__4$", arg4: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogueSkip03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip03 : TriggerState {
            internal StateDialogueSkip03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6102}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__FLYINGCLOUD01__5$", arg4: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogueSkip04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip04 : TriggerState {
            internal StateDialogueSkip04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue05 : TriggerState {
            internal StateDialogue05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__6$", arg4: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new StateDialogueSkip05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip05 : TriggerState {
            internal StateDialogueSkip05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6003}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__7$", arg4: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogueSkip06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip06 : TriggerState {
            internal StateDialogueSkip06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue07 : TriggerState {
            internal StateDialogue07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6103}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__FLYINGCLOUD01__8$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogueSkip07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip07 : TriggerState {
            internal StateDialogueSkip07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue08 : TriggerState {
            internal StateDialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__9$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogueSkip08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip08 : TriggerState {
            internal StateDialogueSkip08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateDialogue09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue09 : TriggerState {
            internal StateDialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6104}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__FLYINGCLOUD01__10$", arg4: 8);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateDialogueSkip09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip09 : TriggerState {
            internal StateDialogueSkip09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 203, arg2: "Idle_A");
                context.RemoveCinematicTalk();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue10 : TriggerState {
            internal StateDialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6004}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__11$", arg4: 5);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogueSkip10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogueSkip10 : TriggerState {
            internal StateDialogueSkip10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 103, arg2: "Idle_A");
                context.CameraSelect(arg1: 501, arg2: false);
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFirstQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestStart01 : TriggerState {
            internal StateFirstQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10030160, textID: 10030160);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000454},
                    arg3: new byte[] {2})) {
                    context.State = new StateFirstQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10030160);
            }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10031010, textID: 10031010);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000454},
                    arg3: new byte[] {3})) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10031010);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10031020, textID: 10031020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000455},
                    arg3: new byte[] {1})) {
                    context.State = new StatePatrolWhileTalking01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10031020);
            }
        }

        private class StatePatrolWhileTalking01 : TriggerState {
            internal StatePatrolWhileTalking01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrolWhileTalking02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking02 : TriggerState {
            internal StatePatrolWhileTalking02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103, 203});
                context.CreateMonster(arg1: new int[] {104, 204}, arg2: false);
                context.MoveUser(arg1: 63000030, arg2: 11, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrolWhileTalking03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking03 : TriggerState {
            internal StatePatrolWhileTalking03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "FightBack01", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_203");
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrolWhileTalking04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking04 : TriggerState {
            internal StatePatrolWhileTalking04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$63000030_CS__FLYINGCLOUD01__12$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$63000030_CS__FLYINGCLOUD01__13$", arg4: 2, arg5: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StatePatrolWhileTalking05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWhileTalking05 : TriggerState {
            internal StatePatrolWhileTalking05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$63000030_CS__FLYINGCLOUD01__14$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$63000030_CS__FLYINGCLOUD01__15$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$63000030_CS__FLYINGCLOUD01__16$", arg4: 2, arg5: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new StateShadowApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShadowApp01 : TriggerState {
            internal StateShadowApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5400}, arg2: true);
                context.CreateMonster(arg1: new int[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949}, arg2: false);
                context.CameraSelect(arg1: 600, arg2: true);
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateShadowApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShadowApp02 : TriggerState {
            internal StateShadowApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_104");
                context.SetEffect(arg1: new int[] {6105}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 204, arg3: "$63000030_CS__FLYINGCLOUD01__17$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateShadowApp03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShadowApp03 : TriggerState {
            internal StateShadowApp03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateShadowApp04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShadowApp04 : TriggerState {
            internal StateShadowApp04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$63000030_CS__FLYINGCLOUD01__18$", arg4: 2, arg5: 0);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateShadowApp05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateShadowApp05 : TriggerState {
            internal StateShadowApp05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFightBack01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack01 : TriggerState {
            internal StateFightBack01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_205");
                context.SetEffect(arg1: new int[] {6106}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000030_CS__FLYINGCLOUD01__19$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFightBack02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack02 : TriggerState {
            internal StateFightBack02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFightBack03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack03 : TriggerState {
            internal StateFightBack03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_105");
                context.SetEffect(arg1: new int[] {6005}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000030_CS__FLYINGCLOUD01__20$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateFightBack04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack04 : TriggerState {
            internal StateFightBack04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFightBack05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack05 : TriggerState {
            internal StateFightBack05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000030, arg2: 20, arg3: 9900);
                context.DestroyMonster(arg1: new int[] {940, 941, 942, 943, 944, 945, 946, 947, 948, 949});
                context.CreateMonster(arg1: new int[] {910, 911, 912, 913, 914, 915, 916, 917, 918, 919}, arg2: false);
                context.DestroyMonster(arg1: new int[] {104, 204});
                context.CreateMonster(arg1: new int[] {105, 205}, arg2: false);
                context.CameraSelect(arg1: 602, arg2: true);
                context.SetUserValue(triggerID: 3, key: "SafetyStart", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateFightBack06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFightBack06 : TriggerState {
            internal StateFightBack06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetUserValue(triggerID: 2, key: "PushStart", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGotoTria01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGotoTria01 : TriggerState {
            internal StateGotoTria01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetEffect(arg1: new int[] {5204}, arg2: true);
                context.SetEffect(arg1: new int[] {5205}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10037020, textID: 10037020);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new StateGotoTria02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10037020);
            }
        }

        private class StateGotoTria02 : TriggerState {
            internal StateGotoTria02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10037030, textID: 10037030);
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001010}, arg2: 0)) {
                    context.State = new StateTakeOffFlyingCloud01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10037030);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
            }
        }

        private class StateTakeOffFlyingCloud01 : TriggerState {
            internal StateTakeOffFlyingCloud01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.SetVisibleBreakableObject(arg1: new int[] {4000}, arg2: true);
                context.SetBreakable(arg1: new int[] {4000}, arg2: true);
                context.SetInteractObject(arg1: new int[] {10001010}, arg2: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTakeOffFlyingCloud02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud02 : TriggerState {
            internal StateTakeOffFlyingCloud02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
                context.SetMesh(arg1: new int[] {3000, 3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.MoveUser(arg1: 63000030, arg2: 30, arg3: 9900);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTakeOffFlyingCloud03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud03 : TriggerState {
            internal StateTakeOffFlyingCloud03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTakeOffFlyingCloud04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTakeOffFlyingCloud04 : TriggerState {
            internal StateTakeOffFlyingCloud04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000036, arg2: 1);
                context.CameraSelect(arg1: 701, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}