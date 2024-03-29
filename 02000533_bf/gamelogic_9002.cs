using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02000533_bf {
    public static class _gamelogic_9002 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(type: WidgetType.TypingGame);
                context.CreateWidget(type: WidgetType.Round);
                context.WidgetAction(type: WidgetType.Round, name: "SettingFinalRound", args: "1");
                context.WidgetAction(type: WidgetType.Round, name: "SettingAllowedFailCount", args: "3");
                context.WidgetAction(type: WidgetType.Round, name: "SettingRoundInitIfFail", args: "0");
                context.LockMyPc(isLock: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "GameLogicStart") == 1) {
                    return new State게임진입(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State게임진입 : TriggerState {
            internal State게임진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State새라운드시작가능체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State새라운드시작가능체크 : TriggerState {
            internal State새라운드시작가능체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Round, condition: "GameClear")) {
                    return new State게임Success종료(context);
                }

                if (context.WidgetCondition(type: WidgetType.Round, condition: "GameFail")) {
                    return new State게임실패종료(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new State라운드체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드체크 : TriggerState {
            internal State라운드체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.Round, condition: "CurrentRound", value: "= 1")) {
                    return new State라운드1시작전UI(context);
                }

                if (context.WidgetCondition(type: WidgetType.Round, condition: "CurrentRound", value: "= 2")) {
                    return new State라운드2시작전UI(context);
                }

                if (context.WidgetCondition(type: WidgetType.Round, condition: "CurrentRound", value: "= 3")) {
                    return new State라운드3시작전UI(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드1시작전UI : TriggerState {
            internal State라운드1시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__0$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__1$", duration: 6000);
                    context.WidgetAction(type: WidgetType.TypingGame, name: "Start", widgetArgType: 7, args: "6000");
                    return new State라운드1진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드1진행 : TriggerState {
            internal State라운드1진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "1")) {
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "1");
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__2$", duration: 3000);
                    return new State라운드종료(context);
                }

                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "0")) {
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "0");
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__3$", duration: 3000);
                    return new State라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드2시작전UI : TriggerState {
            internal State라운드2시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__4$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__5$", duration: 4000);
                    context.WidgetAction(type: WidgetType.TypingGame, name: "Start", widgetArgType: 6, args: "4000");
                    return new State라운드2진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드2진행 : TriggerState {
            internal State라운드2진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "1")) {
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__6$", duration: 3000);
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "1");
                    return new State라운드종료(context);
                }

                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "0")) {
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__7$", duration: 3000);
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "0");
                    return new State라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드3시작전UI : TriggerState {
            internal State라운드3시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__8$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__9$", duration: 3000);
                    context.WidgetAction(type: WidgetType.TypingGame, name: "Start", widgetArgType: 7, args: "3000");
                    return new State라운드3진행(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드3진행 : TriggerState {
            internal State라운드3진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "1")) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__10$", duration: 3000);
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "1");
                    return new State라운드종료(context);
                }

                if (context.WidgetCondition(type: WidgetType.TypingGame, condition: "Result", value: "0")) {
                    context.SetEventUI(arg1: 1, script: "$02000533_BF__GAMELOGIC_9002__11$", duration: 3000);
                    context.WidgetAction(type: WidgetType.Round, name: "RoundResult", args: "0");
                    return new State라운드종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State라운드종료 : TriggerState {
            internal State라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                context.LockMyPc(isLock: false);
                    return new State새라운드시작가능체크(context);
            }

            public override void OnExit() { }
        }

        private class State게임Success종료 : TriggerState {
            internal State게임Success종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9001, key: "GameLogicEnd", value: 1);
                context.SetUserValue(key: "GameLogicStart", value: 999);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }

        private class State게임실패종료 : TriggerState {
            internal State게임실패종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 9001, key: "GameLogicEnd", value: 2);
                context.SetUserValue(key: "GameLogicStart", value: 999);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}
