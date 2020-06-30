using System;

namespace Maple2.Trigger._63000024_cs {
    public static class _wakeup01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5102}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.SetEffect(arg1: new int[] {5500}, arg2: false);
                context.SetEffect(arg1: new int[] {5501}, arg2: false);
                context.SetEffect(arg1: new int[] {5502}, arg2: false);
                context.SetEffect(arg1: new int[] {5503}, arg2: false);
                context.SetEffect(arg1: new int[] {5504}, arg2: false);
                context.SetEffect(arg1: new int[] {5505}, arg2: false);
                context.SetEffect(arg1: new int[] {5506}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {6001}, arg2: false);
                context.SetEffect(arg1: new int[] {6002}, arg2: false);
                context.CreateMonster(arg1: new int[] {101}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new StatePlayMovie01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie01 : TriggerState {
            internal StatePlayMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000444},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing04(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOnGoing03(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestOnGoing02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOnGoing01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing01 : TriggerState {
            internal StateQuestOnGoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new StateMoveToGetWeapon01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing02 : TriggerState {
            internal StateQuestOnGoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing03 : TriggerState {
            internal StateQuestOnGoing03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestStart03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOnGoing04 : TriggerState {
            internal StateQuestOnGoing04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTimeToLeave01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 500, arg2: true);
                context.SetSceneSkip(arg1: "TinChaiTalk04_CSkip", arg2: "nextState");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCDownIdle01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle01 : TriggerState {
            internal StatePCDownIdle01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Down_Idle_D", arg2: 9000f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePCDownIdle02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCDownIdle02 : TriggerState {
            internal StatePCDownIdle02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateLookAround01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {501, 502}, arg2: false);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_101");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateLookAround02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(arg1: "Sit_Ground_Idle_A", arg2: 18000f);
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
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
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
                context.CameraSelect(arg1: 510, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_105");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateLookAround05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround05 : TriggerState {
            internal StateLookAround05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLookAround06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround06 : TriggerState {
            internal StateLookAround06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 511, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateLookAround07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLookAround07 : TriggerState {
            internal StateLookAround07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 600, arg2: true);
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTinChaiTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk01 : TriggerState {
            internal StateTinChaiTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000024_CS__WAKEUP01__0$", arg4: 7);
                context.SetSkip(arg1: "TinChaiTalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new StateTinChaiTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk02 : TriggerState {
            internal StateTinChaiTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTinChaiTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk03 : TriggerState {
            internal StateTinChaiTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6001}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000024_CS__WAKEUP01__1$", arg4: 5);
                context.SetSkip(arg1: "TinChaiTalk04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTinChaiTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk04 : TriggerState {
            internal StateTinChaiTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 600, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State키타입설정안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk04_CSkip : TriggerState {
            internal StateTinChaiTalk04_CSkip(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.MoveNpc(arg1: 101, arg2: "MS2PatrolData_102");
                context.MoveUser(arg1: 63000024, arg2: 10, arg3: 9900);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 600, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State키타입설정안내01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State키타입설정안내01 : TriggerState {
            internal State키타입설정안내01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10030005);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10030009")) {
                    context.State = new StateMeetTinChai01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetTinChai01 : TriggerState {
            internal StateMeetTinChai01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5300}, arg2: true);
                context.SetEffect(arg1: new int[] {5301}, arg2: true);
                context.SetEffect(arg1: new int[] {5302}, arg2: true);
                context.SetEffect(arg1: new int[] {5303}, arg2: true);
                context.SetEffect(arg1: new int[] {5304}, arg2: true);
                context.ShowGuideSummary(entityID: 10030010, textID: 10030010);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9001")) {
                    context.State = new StateMeetTinChai02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetTinChai02 : TriggerState {
            internal StateMeetTinChai02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5300}, arg2: false);
                context.SetEffect(arg1: new int[] {5301}, arg2: false);
                context.SetEffect(arg1: new int[] {5302}, arg2: false);
                context.SetEffect(arg1: new int[] {5303}, arg2: false);
                context.SetEffect(arg1: new int[] {5304}, arg2: false);
                context.HideGuideSummary(entityID: 10030010);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTinChaiTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk10 : TriggerState {
            internal StateTinChaiTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateTinChaiTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk11 : TriggerState {
            internal StateTinChaiTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6002}, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000024_CS__WAKEUP01__2$", arg4: 6);
                context.SetSkip(arg1: "TinChaiTalk14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateTinChaiTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk12 : TriggerState {
            internal StateTinChaiTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTinChaiTalk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk13 : TriggerState {
            internal StateTinChaiTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001708, arg3: "$63000024_CS__WAKEUP01__3$", arg4: 5);
                context.SetSkip(arg1: "TinChaiTalk14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateTinChaiTalk14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTinChaiTalk14 : TriggerState {
            internal StateTinChaiTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10030020, textID: 10030020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10030020);
            }
        }

        private class StateQuestStart01 : TriggerState {
            internal StateQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {2})) {
                    context.State = new StateQuestStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestStart02 : TriggerState {
            internal StateQuestStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000443},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestStart03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestStart03 : TriggerState {
            internal StateQuestStart03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000444},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestStart04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestStart04 : TriggerState {
            internal StateQuestStart04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 1, arg2: true, arg3: false, arg4: false);
                context.DestroyMonster(arg1: new int[] {102});
                context.CreateMonster(arg1: new int[] {103}, arg2: false);
            }

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
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_103");
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000024_CS__WAKEUP01__4$", arg4: 4, arg5: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10030010, textID: 10030010);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5102}, arg2: true);
                context.SetEffect(arg1: new int[] {5500}, arg2: true);
                context.SetEffect(arg1: new int[] {5501}, arg2: true);
                context.SetEffect(arg1: new int[] {5502}, arg2: true);
                context.SetEffect(arg1: new int[] {5503}, arg2: true);
                context.SetEffect(arg1: new int[] {5504}, arg2: true);
                context.SetEffect(arg1: new int[] {5505}, arg2: true);
                context.SetEffect(arg1: new int[] {5506}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9003")) {
                    context.State = new StateGuideNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_104");
                context.HideGuideSummary(entityID: 10030010);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 1060, textID: 1060);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGuideNextMap03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap03 : TriggerState {
            internal StateGuideNextMap03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {103});
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
                context.HideGuideSummary(entityID: 1060);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}