namespace Maple2.Trigger._63000025_cs {
    public static class _training01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new[] {5000, 5001, 5002, 5100, 5101, 5102, 5103, 5104, 5105, 5200, 5203, 5301, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410, 5500, 5501, 5502, 5503, 5504, 6000, 6001, 6002, 6003, 6004, 6005, 6006, 6100, 6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112}, arg2: false);
                context.SetInteractObject(arg1: new[] {10001003}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
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
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000448}, arg3: new byte[] {1})) {
                    context.State = new StateTimeToLeave02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000447}, arg3: new byte[] {3})) {
                    context.State = new StateReadyToMove02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000447}, arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing41(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000447}, arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing41(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000446}, arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing41(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000446}, arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing41(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000446}, arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing41(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing31(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing21(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing11(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000444}, arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000444}, arg3: new byte[] {2})) {
                    context.State = new StateEnter02(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing41 : TriggerState {
            internal StateQuestOnGoing41(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000025, arg2: 10, arg3: 9900);
                context.CreateMonster(arg1: new[] {104, 204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuestOnGoing42(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing42 : TriggerState {
            internal StateQuestOnGoing42(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSkillUseGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing31 : TriggerState {
            internal StateQuestOnGoing31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000025, arg2: 10, arg3: 9900);
                context.CreateMonster(arg1: new[] {104, 204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuestOnGoing32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing32 : TriggerState {
            internal StateQuestOnGoing32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSkillUseGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing21 : TriggerState {
            internal StateQuestOnGoing21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000025, arg2: 10, arg3: 9900);
                context.CreateMonster(arg1: new[] {104, 204}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuestOnGoing22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing22 : TriggerState {
            internal StateQuestOnGoing22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateSecondQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing11 : TriggerState {
            internal StateQuestOnGoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000025, arg2: 30, arg3: 9900);
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuestOnGoing12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing12 : TriggerState {
            internal StateQuestOnGoing12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJumpPointGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000025, arg2: 30, arg3: 9900);
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateQuestOnGoing02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing02 : TriggerState {
            internal StateQuestOnGoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 4);
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

        private class StateEnter02 : TriggerState {
            internal StateEnter02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "Dialogue10", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateEnter03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter03 : TriggerState {
            internal StateEnter03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CreateMonster(arg1: new[] {101}, arg2: false);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnter04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter04 : TriggerState {
            internal StateEnter04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnter05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter05 : TriggerState {
            internal StateEnter05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEnter06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnter06 : TriggerState {
            internal StateEnter06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateDialogue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue01 : TriggerState {
            internal StateDialogue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6100}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__0$", arg4: 5);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateDialogue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue02 : TriggerState {
            internal StateDialogue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
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
                context.SetEffect(arg1: new[] {6101}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__1$", arg4: 7);
                context.SetSkip(arg1: "Dialogue04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateDialogue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue04 : TriggerState {
            internal StateDialogue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
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
                context.SetEffect(arg1: new[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__2$", arg4: 6);
                context.SetSkip(arg1: "Dialogue06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    context.State = new StateDialogue06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue06 : TriggerState {
            internal StateDialogue06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
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
                context.SetEffect(arg1: new[] {6102}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__3$", arg4: 6);
                context.SetSkip(arg1: "Dialogue08");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateDialogue08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue08 : TriggerState {
            internal StateDialogue08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateDialogue09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue09 : TriggerState {
            internal StateDialogue09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__4$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDialogue10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDialogue10 : TriggerState {
            internal StateDialogue10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 502, arg2: false);
                context.DestroyMonster(arg1: new[] {101, 201});
                context.CreateMonster(arg1: new[] {102, 202}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFirstQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031010, textId: 10031010);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000444}, arg3: new byte[] {3})) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.HideGuideSummary(entityId: 10031010);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {1})) {
                    context.State = new StateJumpPointGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJumpPointGuide01 : TriggerState {
            internal StateJumpPointGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10031020);
                context.ShowGuideSummary(entityId: 10031030, textId: 10031030);
                context.SetEffect(arg1: new[] {5000, 5001, 5100, 5101, 5102, 5103, 5104, 5105, 5200, 5203, 5301}, arg2: true);
                context.DestroyMonster(arg1: new[] {102, 202});
                context.CreateMonster(arg1: new[] {103, 203}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJumpPointGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJumpPointGuide02 : TriggerState {
            internal StateJumpPointGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6103}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000025_CS__TRAINING01__5$", arg4: 3, arg5: 0);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_202");
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9200})) {
                    context.State = new StateJumpPointGuide03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJumpPointGuide03 : TriggerState {
            internal StateJumpPointGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10031030);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031031, textId: 10031031);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new StateJumpPointGuide04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJumpPointGuide04 : TriggerState {
            internal StateJumpPointGuide04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10001003}, arg2: 1);
                context.HideGuideSummary(entityId: 10031031);
                context.ShowGuideSummary(entityId: 10031032, textId: 10031032);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.SetEffect(arg1: new[] {5301, 5100, 5101, 5102, 5103, 5104, 5105, 5200}, arg2: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {2})) {
                    context.State = new StateSecondQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {103, 203});
                context.CreateMonster(arg1: new[] {104, 204}, arg2: false);
                context.HideGuideSummary(entityId: 10031032);
            }
        }

        private class StateSecondQuestEnd01 : TriggerState {
            internal StateSecondQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5001, 5203}, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031050, textId: 10031050);
                context.SetEffect(arg1: new[] {5500, 5501, 5502, 5503, 5504}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9300})) {
                    context.State = new StateSecondQuestEnd02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031050);
                context.SetEffect(arg1: new[] {5500, 5501, 5502, 5503, 5504, 5001, 5203}, arg2: false);
            }
        }

        private class StateSecondQuestEnd02 : TriggerState {
            internal StateSecondQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031010, textId: 10031010);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000445}, arg3: new byte[] {3})) {
                    context.State = new StateSkillUseGuide01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10031010);
            }
        }

        private class StateSkillUseGuide01 : TriggerState {
            internal StateSkillUseGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSkillUseGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSkillUseGuide02 : TriggerState {
            internal StateSkillUseGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000447}, arg3: new byte[] {3})) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateReadyToMove01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove01 : TriggerState {
            internal StateReadyToMove01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateReadyToMove02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToMove02 : TriggerState {
            internal StateReadyToMove02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.DestroyMonster(arg1: new[] {104, 204});
                context.CreateMonster(arg1: new[] {105, 205}, arg2: false);
                context.MoveUser(arg1: 63000025, arg2: 10, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatePatrolWalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWalk01 : TriggerState {
            internal StatePatrolWalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 105, arg2: "MS2PatrolData_103");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_203");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrolWalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWalk02 : TriggerState {
            internal StatePatrolWalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateFeelStrange01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange01 : TriggerState {
            internal StateFeelStrange01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6104}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__6$", arg4: 5);
                context.SetSceneSkip(arg1: "FeelStrange18", arg2: "nextState");
                context.SetSkip(arg1: "FeelStrange02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateFeelStrange02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange02 : TriggerState {
            internal StateFeelStrange02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange03 : TriggerState {
            internal StateFeelStrange03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6105}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__7$", arg4: 3);
                context.SetSkip(arg1: "FeelStrange04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateFeelStrange04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange04 : TriggerState {
            internal StateFeelStrange04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange05 : TriggerState {
            internal StateFeelStrange05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__8$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFeelStrange06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange06 : TriggerState {
            internal StateFeelStrange06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange07 : TriggerState {
            internal StateFeelStrange07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6106}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__9$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange08");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFeelStrange08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange08 : TriggerState {
            internal StateFeelStrange08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange09 : TriggerState {
            internal StateFeelStrange09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6003}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__10$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange10");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFeelStrange10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange10 : TriggerState {
            internal StateFeelStrange10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange11 : TriggerState {
            internal StateFeelStrange11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6107}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__11$", arg4: 6);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateFeelStrange12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange12 : TriggerState {
            internal StateFeelStrange12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange13 : TriggerState {
            internal StateFeelStrange13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6004}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__12$", arg4: 4);
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateFeelStrange14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange14 : TriggerState {
            internal StateFeelStrange14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 205, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange15 : TriggerState {
            internal StateFeelStrange15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6108}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__13$", arg4: 5);
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Talk_A");
                context.SetSkip(arg1: "FeelStrange16");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateFeelStrange16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange16 : TriggerState {
            internal StateFeelStrange16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 105, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateFeelStrange17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange17 : TriggerState {
            internal StateFeelStrange17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6005}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000025_CS__TRAINING01__14$", arg4: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateFeelStrange18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFeelStrange18 : TriggerState {
            internal StateFeelStrange18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new[] {105, 205});
                context.CreateMonster(arg1: new[] {106, 206}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLastQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLastQuestStart01 : TriggerState {
            internal StateLastQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10031020, textId: 10031020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000448}, arg3: new byte[] {1})) {
                    context.State = new StateDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10031020);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateMinimapGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide01 : TriggerState {
            internal StateMinimapGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetEffect(arg1: new[] {6109}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001557, arg3: "$63000025_CS__TRAINING01__19$", arg4: 7);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Talk_A");
                context.SetSkip(arg1: "MinimapGuide02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateMinimapGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide02 : TriggerState {
            internal StateMinimapGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetNpcEmotionSequence(arg1: 106, arg2: "Idle_A");
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateMinimapGuide03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide03 : TriggerState {
            internal StateMinimapGuide03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventId: 10031080);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10031083")) {
                    context.State = new StateDelay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTimeToLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTimeToLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave02 : TriggerState {
            internal StateTimeToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: false);
                context.MoveUser(arg1: 63000025, arg2: 20, arg3: 9900);
                context.DestroyMonster(arg1: new[] {106, 206});
                context.CreateMonster(arg1: new[] {107, 207}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTimeToLeave03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave03 : TriggerState {
            internal StateTimeToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip(arg1: "NpcLeave_CSkip", arg2: "nextState");
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMonologue01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue01 : TriggerState {
            internal StateMonologue01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6110}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$63000025_CS__TRAINING01__15$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new StateMonologue02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue02 : TriggerState {
            internal StateMonologue02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 701, arg2: true);
                context.MoveNpc(arg1: 107, arg2: "MS2PatrolData_104");
                context.MoveNpc(arg1: 207, arg2: "MS2PatrolData_204");
                context.SetEffect(arg1: new[] {6111}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$63000025_CS__TRAINING01__16$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMonologue03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue03 : TriggerState {
            internal StateMonologue03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {6006}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 207, arg3: "$63000025_CS__TRAINING01__17$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMonologue04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMonologue04 : TriggerState {
            internal StateMonologue04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 702, arg2: true);
                context.SetEffect(arg1: new[] {6112}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 107, arg3: "$63000025_CS__TRAINING01__18$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2200)) {
                    context.State = new StateNpcLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcLeave01 : TriggerState {
            internal StateNpcLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.DestroyMonster(arg1: new[] {107});
                context.MoveUser(arg1: 63000025, arg2: 40, arg3: 9900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 800)) {
                    context.State = new StateNpcLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcLeave02 : TriggerState {
            internal StateNpcLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {207});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcLeave_CSkip : TriggerState {
            internal StateNpcLeave_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.DestroyMonster(arg1: new[] {107, 207});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 702, arg2: false);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
                context.ShowGuideSummary(entityId: 10020012, textId: 10020012);
                context.SetEffect(arg1: new[] {5001, 5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    context.State = new StateGuideNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10020012);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new[] {5002, 5000}, arg2: true);
                context.ShowGuideSummary(entityId: 1060, textId: 1060);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
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
                context.HideGuideSummary(entityId: 1060);
                context.SetEffect(arg1: new[] {5400, 5401, 5402, 5403, 5404, 5405, 5406, 5407, 5408, 5409, 5410}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}