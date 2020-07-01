using System;

namespace Maple2.Trigger._63000016_cs {
    public static class _meetjacey01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetPortal(arg1: 2, arg2: true, arg3: false, arg4: true);
                context.SetMesh(arg1: new int[] {3000}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StateWalkIn01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToJacey01 : TriggerState {
            internal StateMoveToJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000016, arg2: 10, arg3: 9000);
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateMoveToJacey02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToJacey02 : TriggerState {
            internal StateMoveToJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyQuest02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkIn01 : TriggerState {
            internal StateWalkIn01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9000}, arg2: new int[] {90000431},
                    arg3: new byte[] {2})) {
                    context.State = new StateMoveToJacey01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateWalkIn02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkIn02 : TriggerState {
            internal StateWalkIn02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateWalkIn03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWalkIn03 : TriggerState {
            internal StateWalkIn03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateMeetJacey01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey01 : TriggerState {
            internal StateMeetJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__0$", arg4: 4);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMeetJacey02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey02 : TriggerState {
            internal StateMeetJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMeetJacey03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetJacey03 : TriggerState {
            internal StateMeetJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1001");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateJaceyTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk01 : TriggerState {
            internal StateJaceyTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__1$", arg4: 5);
                context.SetSkip(arg1: "JaceyTalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateJaceyTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk02 : TriggerState {
            internal StateJaceyTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk03 : TriggerState {
            internal StateJaceyTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(arg1: "MS2PatrolData_1002");
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__2$", arg4: 4);
                context.SetSkip(arg1: "JaceyTalk04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk04 : TriggerState {
            internal StateJaceyTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk05 : TriggerState {
            internal StateJaceyTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__3$", arg4: 4);
                context.SetSkip(arg1: "JaceyTalk06");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyTalk06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk06 : TriggerState {
            internal StateJaceyTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.CameraSelect(arg1: 602, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateMinimapGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide01 : TriggerState {
            internal StateMinimapGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10021010);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10021013")) {
                    context.State = new StateMinimapGuide02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMinimapGuide02 : TriggerState {
            internal StateMinimapGuide02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateJaceyTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk10 : TriggerState {
            internal StateJaceyTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__4$", arg4: 4);
                context.SetSkip(arg1: "JaceyTalk11");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk11 : TriggerState {
            internal StateJaceyTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk12 : TriggerState {
            internal StateJaceyTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__5$", arg4: 4);
                context.SetSkip(arg1: "JaceyTalk13");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyTalk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyTalk13 : TriggerState {
            internal StateJaceyTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePatrolWithJacey01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey01 : TriggerState {
            internal StatePatrolWithJacey01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10021020, textID: 10021020);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_103");
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9100, arg2: new int[] {101})) {
                    context.State = new StatePatrolWithJacey02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey02 : TriggerState {
            internal StatePatrolWithJacey02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__6$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__7$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__8$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9101, arg2: new int[] {101})) {
                    context.State = new StatePatrolWithJacey03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey03 : TriggerState {
            internal StatePatrolWithJacey03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__9$", arg4: 3, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__10$", arg4: 3, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__11$", arg4: 3, arg5: 6);
            }

            public override void Execute() {
                if (context.NpcDetected(arg1: 9102, arg2: new int[] {101})) {
                    context.State = new StatePatrolWithJacey04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePatrolWithJacey04 : TriggerState {
            internal StatePatrolWithJacey04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000016_CS__MEETJACEY01__12$", arg4: 3);
                context.HideGuideSummary(entityID: 10021020);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCallNextRoom01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom01 : TriggerState {
            internal StateCallNextRoom01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 700, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCallNextRoom02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom02 : TriggerState {
            internal StateCallNextRoom02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {3000}, arg2: false, arg3: 100, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3001}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateCallNextRoom03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom03 : TriggerState {
            internal StateCallNextRoom03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__13$", arg4: 4);
                context.SetSkip(arg1: "CallNextRoom04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCallNextRoom04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCallNextRoom04 : TriggerState {
            internal StateCallNextRoom04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CameraSelect(arg1: 700, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyQuest00(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest00 : TriggerState {
            internal StateJaceyQuest00(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10021030, textID: 10021030);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9002}, arg2: new int[] {90000431},
                    arg3: new byte[] {2})) {
                    context.State = new StateJaceyQuest01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest01 : TriggerState {
            internal StateJaceyQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10021030);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyQuest02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest02 : TriggerState {
            internal StateJaceyQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__14$", arg4: 4);
                context.SetSkip(arg1: "JaceyQuest03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyQuest03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest03 : TriggerState {
            internal StateJaceyQuest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateJaceyQuest04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest04 : TriggerState {
            internal StateJaceyQuest04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__15$", arg4: 4);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetSkip(arg1: "JaceyQuest05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateJaceyQuest05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyQuest05 : TriggerState {
            internal StateJaceyQuest05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateAboutPotion01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion01 : TriggerState {
            internal StateAboutPotion01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__16$", arg4: 4);
                context.SetSkip(arg1: "AboutPotion02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateAboutPotion02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion02 : TriggerState {
            internal StateAboutPotion02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateAboutPotion03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion03 : TriggerState {
            internal StateAboutPotion03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001620, arg3: "$63000016_CS__MEETJACEY01__17$", arg4: 4);
                context.SetSkip(arg1: "AboutPotion04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateAboutPotion04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAboutPotion04 : TriggerState {
            internal StateAboutPotion04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_301");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateJaceyLeve01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.GuideEvent(eventID: 10021120);
            }
        }

        private class StateJaceyLeve01 : TriggerState {
            internal StateJaceyLeve01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000016_CS__MEETJACEY01__18$", arg4: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateJaceyLeve02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateJaceyLeve02 : TriggerState {
            internal StateJaceyLeve02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.DestroyMonster(arg1: new int[] {103});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateSendSignalToGuide01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSendSignalToGuide01 : TriggerState {
            internal StateSendSignalToGuide01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10021050);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePortalOpen01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePortalOpen01 : TriggerState {
            internal StatePortalOpen01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}