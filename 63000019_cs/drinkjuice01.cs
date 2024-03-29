namespace Maple2.Trigger._63000019_cs {
    public static class _drinkjuice01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5300, 5400, 5000, 5001, 5002, 5100, 5101, 5102, 5103, 5200, 5201, 5202, 8000, 8001, 8002}, visible: false);
                context.CreateMonster(spawnIds: new []{101, 201, 301, 401, 501}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateLodingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay01 : TriggerState {
            internal StateLodingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLodingDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLodingDelay02 : TriggerState {
            internal StateLodingDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000438}, questStates: new byte[]{3})) {
                    return new StateQuestComplete01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000442}, questStates: new byte[]{3})) {
                    return new StateQuestComplete01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000442}, questStates: new byte[]{2})) {
                    return new StateMoveToBartender01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000437}, questStates: new byte[]{3})) {
                    return new StateTalkToWeiHong02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000437}, questStates: new byte[]{2})) {
                    return new StateMoveToWeiHong01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToWeiHong01 : TriggerState {
            internal StateMoveToWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024010, textId: 10024010);
                context.SetEffect(triggerIds: new []{5000, 5001, 5100, 5101, 5102, 5103, 5300}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateTalkToWeiHong01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024010);
                context.SetEffect(triggerIds: new []{5100, 5101, 5102, 5103, 5300}, visible: false);
            }
        }

        private class StateTalkToWeiHong01 : TriggerState {
            internal StateTalkToWeiHong01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024020, textId: 10024020);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000437}, questStates: new byte[]{3})) {
                    return new StateTalkToWeiHong02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024020);
            }
        }

        private class StateTalkToWeiHong02 : TriggerState {
            internal StateTalkToWeiHong02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024030, textId: 10024030);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000438}, questStates: new byte[]{2})) {
                    return new StateMoveToBartender01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveToBartender01 : TriggerState {
            internal StateMoveToBartender01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024040, textId: 10024040);
                context.SetEffect(triggerIds: new []{5000, 5001, 5200, 5201, 5202, 5400}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateMoveToBartender02(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10024040);
                context.SetEffect(triggerIds: new []{5400, 5001, 5200, 5201, 5202}, visible: false);
            }
        }

        private class StateMoveToBartender02 : TriggerState {
            internal StateMoveToBartender02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10024050, textId: 10024050);
                context.SetEffect(triggerIds: new []{5000}, visible: true);
            }

            public override TriggerState? Execute() {
                return new StateTalkToBartender01(context);
            }

            public override void OnExit() { }
        }

        private class StateTalkToBartender01 : TriggerState {
            internal StateTalkToBartender01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000438}, questStates: new byte[]{3})) {
                    return new StateQuestComplete01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestComplete01 : TriggerState {
            internal StateQuestComplete01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 10024050);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9900}, questIds: new []{90000442}, questStates: new byte[]{3})) {
                    return new StateTalkingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTalkingDelay01 : TriggerState {
            internal StateTalkingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWeiHongTalk01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk01 : TriggerState {
            internal StateWeiHongTalk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000019_CS__DRINKJUICE01__0$", arg4: 5);
                context.SetEffect(triggerIds: new []{8000}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk02(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWeiHongTalk02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk02 : TriggerState {
            internal StateWeiHongTalk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWeiHongTalk03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk03 : TriggerState {
            internal StateWeiHongTalk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11001547, script: "$63000019_CS__DRINKJUICE01__1$", arg4: 4);
                context.SetEffect(triggerIds: new []{8001}, visible: true);
                context.SetSkip(state: new StateWeiHongTalk04(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateWeiHongTalk04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk04 : TriggerState {
            internal StateWeiHongTalk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateWeiHongTalk05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWeiHongTalk05 : TriggerState {
            internal StateWeiHongTalk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 2, spawnId: 11000251, script: "$63000019_CS__DRINKJUICE01__2$", arg4: 8);
                context.SetEffect(triggerIds: new []{8002}, visible: true);
                context.SetSkip(state: new StateMovingDelay01(context));
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateMovingDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMovingDelay01 : TriggerState {
            internal StateMovingDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveCinematicTalk();
                context.SetSkip();
                context.SetEffect(triggerIds: new []{8002}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                context.MoveUser(mapId: 63000020, portalId: 1, boxId: 9900);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
