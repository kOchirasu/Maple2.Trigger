using System;

namespace Maple2.Trigger._63000027_cs {
    public static class _mistery01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5400}, arg2: false);
                context.SetEffect(arg1: new int[] {5401}, arg2: false);
                context.SetEffect(arg1: new int[] {5402}, arg2: false);
                context.SetEffect(arg1: new int[] {5500}, arg2: false);
                context.SetMesh(arg1: new int[] {3100}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3103}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(key: "CollapseEnd", value: 0);
                context.SetUserValue(key: "ZoomIn", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
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
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000451},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000450},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing11(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000450},
                    arg3: new byte[] {2})) {
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

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTimeToLeave01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateQuestOnGoing11 : TriggerState {
            internal StateQuestOnGoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "VisionApp02", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLookAround03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
                context.SetConversation(arg1: 1, arg2: 0, arg3: "$63000027_CS__MISTERY01__0$", arg4: 3, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateLookAround04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround04 : TriggerState {
            internal StateLookAround04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 502, arg2: true);
                context.SetPcEmotionSequence(arg1: "Bore_C");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateVisionApp01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionApp01 : TriggerState {
            internal StateVisionApp01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateVisionApp02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionApp02 : TriggerState {
            internal StateVisionApp02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateVisionTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk01 : TriggerState {
            internal StateVisionTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5400}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$63000027_CS__MISTERY01__1$", arg4: 5);
                context.SetSkip(arg1: "VisionTalk04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateVisionTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk02 : TriggerState {
            internal StateVisionTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateVisionTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk03 : TriggerState {
            internal StateVisionTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001560, arg3: "$63000027_CS__MISTERY01__2$", arg4: 5);
                context.SetSkip(arg1: "VisionTalk04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateVisionTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk04 : TriggerState {
            internal StateVisionTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CameraSelect(arg1: 601, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateVisionTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionTalk05 : TriggerState {
            internal StateVisionTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateFirstQuestEnd01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateFirstQuestEnd01 : TriggerState {
            internal StateFirstQuestEnd01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10034010, textID: 10034010);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9100})) {
                    context.State = new StateFirstQuestEnd02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10034010);
            }
        }

        private class StateFirstQuestEnd02 : TriggerState {
            internal StateFirstQuestEnd02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10034020, textID: 10034020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000450},
                    arg3: new byte[] {3})) {
                    context.State = new StateSecondQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10034020);
            }
        }

        private class StateSecondQuestStart01 : TriggerState {
            internal StateSecondQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10034030, textID: 10034030);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000451},
                    arg3: new byte[] {1})) {
                    context.State = new StateTimeToLeave01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10034030);
            }
        }

        private class StateTimeToLeave01 : TriggerState {
            internal StateTimeToLeave01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    context.State = new StateTimeToLeave02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave02 : TriggerState {
            internal StateTimeToLeave02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.MoveUser(arg1: 63000027, arg2: 10, arg3: 9900);
                context.SetSceneSkip(arg1: "VisionSayGoodbye04", arg2: "exit");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 250)) {
                    context.State = new StateTimeToLeave03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTimeToLeave03 : TriggerState {
            internal StateTimeToLeave03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 701, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCGetEffect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCGetEffect01 : TriggerState {
            internal StatePCGetEffect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9900}, arg2: 70000097, arg3: 1);
                context.SetEffect(arg1: new int[] {5500}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateVisionSayGoodbye01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye01 : TriggerState {
            internal StateVisionSayGoodbye01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5402}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000027_CS__MISTERY01__3$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateVisionSayGoodbye02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye02 : TriggerState {
            internal StateVisionSayGoodbye02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5401}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000027_CS__MISTERY01__4$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000027_CS__MISTERY01__5$", arg4: 3, arg5: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateVisionSayGoodbye03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye03 : TriggerState {
            internal StateVisionSayGoodbye03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_102");
                context.SetSceneSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateVisionSayGoodbye04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateVisionSayGoodbye04 : TriggerState {
            internal StateVisionSayGoodbye04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateCollapse01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse01 : TriggerState {
            internal StateCollapse01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.CameraSelect(arg1: 710, arg2: true);
                context.SetMesh(arg1: new int[] {3100}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3102}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3103}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetUserValue(triggerID: 2, key: "CollapseStart", value: 1);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "ZoomIn", value: 1)) {
                    context.State = new StateCollapse02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCollapse02 : TriggerState {
            internal StateCollapse02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 711, arg2: true);
            }

            public override void Execute() {
                if (context.UserValue(key: "CollapseEnd", value: 1)) {
                    context.State = new StatePCFainted01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCFainted01 : TriggerState {
            internal StatePCFainted01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(arg1: "Down2_A,Down_Idle_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2667)) {
                    context.State = new StatePCTeleport01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_A", arg2: 10000f);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePCTeleport02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000028, arg2: 1, arg3: 9900);
                context.CameraSelect(arg1: 711, arg2: false);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9900})) {
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