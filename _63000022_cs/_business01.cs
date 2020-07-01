using System;

namespace Maple2.Trigger._63000022_cs {
    public static class _business01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(arg1: 2, arg2: false, arg3: false, arg4: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
                context.SetEffect(arg1: new int[] {8000}, arg2: false);
                context.SetEffect(arg1: new int[] {8001}, arg2: false);
                context.SetEffect(arg1: new int[] {8002}, arg2: false);
                context.CreateMonster(arg1: new int[] {101, 201, 301, 401}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9000})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetProductionUI(arg1: 4);
                context.CameraSelect(arg1: 500, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000439},
                    arg3: new byte[] {3})) {
                    context.State = new StateQuestOngoing01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000440},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestOngoing11(context);
                    return;
                }

                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateTalkWeiHong01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing01 : TriggerState {
            internal StateQuestOngoing01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CameraSelect(arg1: 500, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestOngoing02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing02 : TriggerState {
            internal StateQuestOngoing02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing11 : TriggerState {
            internal StateQuestOngoing11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
                context.CameraSelect(arg1: 500, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestOngoing12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestOngoing12 : TriggerState {
            internal StateQuestOngoing12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateMoveToNextMap01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong01 : TriggerState {
            internal StateTalkWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Bore_A");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkWeiHong02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong02 : TriggerState {
            internal StateTalkWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalkWeiHong03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong03 : TriggerState {
            internal StateTalkWeiHong03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelect(arg1: 501, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateTalkWeiHong04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong04 : TriggerState {
            internal StateTalkWeiHong04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000022_CS__BUSINESS01__0$", arg4: 6);
                context.SetEffect(arg1: new int[] {8000}, arg2: true);
                context.SetSkip(arg1: "TalkWeiHong05");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalkWeiHong05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong05 : TriggerState {
            internal StateTalkWeiHong05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
                context.MoveUserPath(arg1: "MS2PatrolData_1000");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateTalkWeiHong06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong06 : TriggerState {
            internal StateTalkWeiHong06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Talk_A");
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000022_CS__BUSINESS01__1$", arg4: 6);
                context.SetEffect(arg1: new int[] {8001}, arg2: true);
                context.SetSkip(arg1: "TalkWeiHong07");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateTalkWeiHong07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong07 : TriggerState {
            internal StateTalkWeiHong07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetNpcEmotionSequence(arg1: 101, arg2: "Idle_A");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkWeiHong08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong08 : TriggerState {
            internal StateTalkWeiHong08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000022_CS__BUSINESS01__3$", arg4: 3);
                context.SetSkip(arg1: "TalkWeiHong09");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateTalkWeiHong09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong09 : TriggerState {
            internal StateTalkWeiHong09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkWeiHong10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong10 : TriggerState {
            internal StateTalkWeiHong10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000022_CS__BUSINESS01__2$", arg4: 6);
                context.SetEffect(arg1: new int[] {8002}, arg2: true);
                context.SetSkip(arg1: "TalkWeiHong11");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateTalkWeiHong11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkWeiHong11 : TriggerState {
            internal StateTalkWeiHong11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.CameraSelect(arg1: 501, arg2: false);
                context.DestroyMonster(arg1: new int[] {101});
                context.CreateMonster(arg1: new int[] {102}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10024020, textID: 10024020);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000439},
                    arg3: new byte[] {3})) {
                    context.State = new StateNextQuestStart01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10024020);
            }
        }

        private class StateNextQuestStart01 : TriggerState {
            internal StateNextQuestStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10024030, textID: 10024030);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {9900}, arg2: new int[] {90000440},
                    arg3: new byte[] {1})) {
                    context.State = new StateMoveToNextMap01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 10024030);
            }
        }

        private class StateMoveToNextMap01 : TriggerState {
            internal StateMoveToNextMap01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 10027010, textID: 10027010);
                context.SetEffect(arg1: new int[] {5000}, arg2: true);
                context.SetEffect(arg1: new int[] {5001}, arg2: true);
                context.SetEffect(arg1: new int[] {5200}, arg2: true);
                context.SetEffect(arg1: new int[] {5201}, arg2: true);
                context.SetEffect(arg1: new int[] {5202}, arg2: true);
                context.SetEffect(arg1: new int[] {5203}, arg2: true);
                context.SetEffect(arg1: new int[] {5204}, arg2: true);
                context.SetEffect(arg1: new int[] {5205}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {9001})) {
                    context.State = new StateMoveToNextMap02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToNextMap02 : TriggerState {
            internal StateMoveToNextMap02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {5002}, arg2: true);
                context.SetPortal(arg1: 2, arg2: true, arg3: true, arg4: true);
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
                context.HideGuideSummary(entityID: 10027010);
                context.SetEffect(arg1: new int[] {5002}, arg2: false);
                context.SetEffect(arg1: new int[] {5000}, arg2: false);
                context.SetEffect(arg1: new int[] {5001}, arg2: false);
                context.SetEffect(arg1: new int[] {5200}, arg2: false);
                context.SetEffect(arg1: new int[] {5201}, arg2: false);
                context.SetEffect(arg1: new int[] {5202}, arg2: false);
                context.SetEffect(arg1: new int[] {5203}, arg2: false);
                context.SetEffect(arg1: new int[] {5204}, arg2: false);
                context.SetEffect(arg1: new int[] {5205}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}