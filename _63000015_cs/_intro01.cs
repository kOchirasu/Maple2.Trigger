using System;

namespace Maple2.Trigger._63000015_cs {
    public static class _intro01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "Guide");
                context.SetSound(arg1: 10000, arg2: false);
                context.SetPortal(arg1: 1, arg2: false, arg3: false, arg4: false);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetEffect(arg1: new int[] {5207}, arg2: false);
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.CreateMonster(arg1: new int[] {101, 201, 202, 203, 204, 205, 206}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StatePlayOpeningMovie01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside10 : TriggerState {
            internal StateStandAside10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateStandAside11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside11 : TriggerState {
            internal StateStandAside11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_206");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new StateWeiHongQuest03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside20 : TriggerState {
            internal StateStandAside20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: true);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateStandAside21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside21 : TriggerState {
            internal StateStandAside21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_206");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayOpeningMovie01 : TriggerState {
            internal StatePlayOpeningMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {90000430},
                    arg3: new byte[] {2})) {
                    context.State = new StateStandAside10(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {90000430},
                    arg3: new byte[] {3})) {
                    context.State = new StateStandAside20(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePlayOpeningMovie02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayOpeningMovie02 : TriggerState {
            internal StatePlayOpeningMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: @"common\Common_Opening.usm", movieID: 2);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "2")) {
                    context.State = new StatePlayMovie01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 190000)) {
                    context.State = new StatePlayMovie01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie01 : TriggerState {
            internal StatePlayMovie01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePlayMovie02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePlayMovie02 : TriggerState {
            internal StatePlayMovie02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "SceneMovie");
                context.WidgetAction(arg1: "SceneMovie", arg2: "Clear");
                context.PlaySceneMovie(fileName: "Cut_Blackstar_Crash.swf", movieID: 1);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "SceneMovie", arg2: "IsStop", arg3: "1")) {
                    context.State = new StateWeiHongTalk01(context);
                    return;
                }

                if (context.WaitTick(waitTick: 66000)) {
                    context.State = new StateWeiHongTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk01 : TriggerState {
            internal StateWeiHongTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSound(arg1: 10000, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 600, arg2: true);
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateWeiHongTalk02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }
        }

        private class StateWeiHongTalk02 : TriggerState {
            internal StateWeiHongTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(arg1: 601, arg2: true);
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__0$", arg4: 6);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateWeiHongTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk03 : TriggerState {
            internal StateWeiHongTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateWeiHongTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk04 : TriggerState {
            internal StateWeiHongTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__1$", arg4: 6);
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateWeiHongTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk05 : TriggerState {
            internal StateWeiHongTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateWeiHongTalk06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk06 : TriggerState {
            internal StateWeiHongTalk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__2$", arg4: 5);
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk07");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWeiHongTalk07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk07 : TriggerState {
            internal StateWeiHongTalk07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 601, arg2: false);
                context.SetMesh(arg1: new int[] {3001, 3002, 3003, 3004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateStandAside01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside01 : TriggerState {
            internal StateStandAside01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 201, arg2: "MS2PatrolData_201");
                context.MoveNpc(arg1: 202, arg2: "MS2PatrolData_202");
                context.MoveNpc(arg1: 204, arg2: "MS2PatrolData_204");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new StateStandAside02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside02 : TriggerState {
            internal StateStandAside02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(arg1: 203, arg2: "MS2PatrolData_203");
                context.MoveNpc(arg1: 205, arg2: "MS2PatrolData_205");
                context.MoveNpc(arg1: 206, arg2: "MS2PatrolData_206");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 400)) {
                    context.State = new StateStandAside03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStandAside03 : TriggerState {
            internal StateStandAside03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateKeytypeSelect01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateKeytypeSelect01 : TriggerState {
            internal StateKeytypeSelect01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.GuideEvent(eventID: 10020005);
            }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Guide", arg2: "IsTriggerEvent", arg3: "10020009")) {
                    context.State = new StateMeetWeiHong01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetWeiHong01 : TriggerState {
            internal StateMeetWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetEffect(arg1: new int[] {5100}, arg2: true);
                context.SetEffect(arg1: new int[] {5101}, arg2: true);
                context.ShowGuideSummary(entityID: 10020010, textID: 10020010);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new StateMeetWeiHong02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMeetWeiHong02 : TriggerState {
            internal StateMeetWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5100}, arg2: false);
                context.SetEffect(arg1: new int[] {5101}, arg2: false);
                context.HideGuideSummary(entityID: 10020010);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeiHongTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk10 : TriggerState {
            internal StateWeiHongTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 602, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeiHongTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk11 : TriggerState {
            internal StateWeiHongTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__3$", arg4: 5);
                context.SetEffect(arg1: new int[] {8005}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk12");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWeiHongTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk12 : TriggerState {
            internal StateWeiHongTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8005}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateWeiHongTalk13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk13 : TriggerState {
            internal StateWeiHongTalk13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__4$", arg4: 5);
                context.SetEffect(arg1: new int[] {8003}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk14");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWeiHongTalk14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk14 : TriggerState {
            internal StateWeiHongTalk14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8003}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateMafiaTalk10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk10 : TriggerState {
            internal StateMafiaTalk10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {6000}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 201, arg3: "$63000015_CS__INTRO01__5$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMafiaTalk11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk11 : TriggerState {
            internal StateMafiaTalk11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 201, arg2: "Idle_A");
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$63000015_CS__INTRO01__6$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateMafiaTalk12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMafiaTalk12 : TriggerState {
            internal StateMafiaTalk12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 202, arg2: "Idle_A");
                context.SetConversation(arg1: 1, arg2: 206, arg3: "$63000015_CS__INTRO01__7$", arg4: 3, arg5: 0);
                context.SetNpcEmotionSequence(arg1: 206, arg2: "Talk_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateWeiHongTalk20(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {6000}, arg2: false);
            }
        }

        private class StateWeiHongTalk20 : TriggerState {
            internal StateWeiHongTalk20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 206, arg2: "Idle_A");
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000015_CS__INTRO01__8$", arg4: 6);
                context.SetEffect(arg1: new int[] {8004}, arg2: true);
                context.SetSkip(arg1: "WeiHongQuest01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateWeiHongQuest01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest01 : TriggerState {
            internal StateWeiHongQuest01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new int[] {8004}, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 602, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeiHongQuest02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest02 : TriggerState {
            internal StateWeiHongQuest02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10020020, textID: 10020020);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {90000430},
                    arg3: new byte[] {2})) {
                    context.State = new StateWeiHongQuest03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongQuest03 : TriggerState {
            internal StateWeiHongQuest03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10020020);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.ShowGuideSummary(entityID: 10020021, textID: 10020021);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9100}, arg2: new int[] {90000430},
                    arg3: new byte[] {3})) {
                    context.State = new StateGuideNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap01 : TriggerState {
            internal StateGuideNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10020021);
                context.SetPortal(arg1: 1, arg2: true, arg3: false, arg4: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetEffect(arg1: new int[] {5204}, arg2: true);
                context.SetEffect(arg1: new int[] {5205}, arg2: true);
                context.SetEffect(arg1: new int[] {5206}, arg2: true);
                context.SetEffect(arg1: new int[] {5207}, arg2: true);
                context.ShowGuideSummary(entityID: 10020012, textID: 10020012);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9002})) {
                    context.State = new StateGuideNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGuideNextMap02 : TriggerState {
            internal StateGuideNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10020012);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.ShowGuideSummary(entityID: 10020011, textID: 10020011);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new int[] {9100})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 10020011);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {5206}, arg2: false);
                context.SetEffect(arg1: new int[] {5207}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}