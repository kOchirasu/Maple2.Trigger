namespace Maple2.Trigger._63000019_cs {
    public static class _drinkjuice01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {5300, 5400, 5000, 5001, 5002, 5100, 5101, 5102, 5103, 5200, 5201, 5202, 8000, 8001, 8002}, arg2: false);
                context.CreateMonster(arg1: new[] {101, 201, 301, 401, 501}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateLodingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateLodingDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000438}, arg3: new byte[] {3})) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000442}, arg3: new byte[] {3})) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000442}, arg3: new byte[] {2})) {
                    context.State = new StateMoveToBartender01(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000437}, arg3: new byte[] {3})) {
                    context.State = new StateTalkToWeiHong02(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000437}, arg3: new byte[] {2})) {
                    context.State = new StateMoveToWeiHong01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToWeiHong01 : TriggerState {
            internal StateMoveToWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024010, textId: 10024010);
                context.SetEffect(arg1: new[] {5000, 5001, 5100, 5101, 5102, 5103, 5300}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new StateTalkToWeiHong01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024010);
                context.SetEffect(arg1: new[] {5100, 5101, 5102, 5103, 5300}, arg2: false);
            }
        }

        private class StateTalkToWeiHong01 : TriggerState {
            internal StateTalkToWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024020, textId: 10024020);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000437}, arg3: new byte[] {3})) {
                    context.State = new StateTalkToWeiHong02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024020);
            }
        }

        private class StateTalkToWeiHong02 : TriggerState {
            internal StateTalkToWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024030, textId: 10024030);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000438}, arg3: new byte[] {2})) {
                    context.State = new StateMoveToBartender01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMoveToBartender01 : TriggerState {
            internal StateMoveToBartender01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024040, textId: 10024040);
                context.SetEffect(arg1: new[] {5000, 5001, 5200, 5201, 5202, 5400}, arg2: true);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new StateMoveToBartender02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024040);
                context.SetEffect(arg1: new[] {5400, 5001, 5200, 5201, 5202}, arg2: false);
            }
        }

        private class StateMoveToBartender02 : TriggerState {
            internal StateMoveToBartender02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024050, textId: 10024050);
                context.SetEffect(arg1: new[] {5000}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateTalkToBartender01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkToBartender01 : TriggerState {
            internal StateTalkToBartender01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000438}, arg3: new byte[] {3})) {
                    context.State = new StateQuestComplete01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10024050);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9900}, arg2: new[] {90000442}, arg3: new byte[] {3})) {
                    context.State = new StateTalkingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTalkingDelay01 : TriggerState {
            internal StateTalkingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWeiHongTalk01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk01 : TriggerState {
            internal StateWeiHongTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000019_CS__DRINKJUICE01__0$", arg4: 5);
                context.SetEffect(arg1: new[] {8000}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWeiHongTalk02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk02 : TriggerState {
            internal StateWeiHongTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {8000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeiHongTalk03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk03 : TriggerState {
            internal StateWeiHongTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11001547, arg3: "$63000019_CS__DRINKJUICE01__1$", arg4: 4);
                context.SetEffect(arg1: new[] {8001}, arg2: true);
                context.SetSkip(arg1: "WeiHongTalk04");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateWeiHongTalk04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk04 : TriggerState {
            internal StateWeiHongTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {8001}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateWeiHongTalk05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk05 : TriggerState {
            internal StateWeiHongTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 2, arg2: 11000251, arg3: "$63000019_CS__DRINKJUICE01__2$", arg4: 8);
                context.SetEffect(arg1: new[] {8002}, arg2: true);
                context.SetSkip(arg1: "MovingDelay01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateMovingDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMovingDelay01 : TriggerState {
            internal StateMovingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(arg1: new[] {8002}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.MoveUser(arg1: 63000020, arg2: 1, arg3: 9900);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}