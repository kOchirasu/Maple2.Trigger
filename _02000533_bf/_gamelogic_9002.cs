using System;

namespace Maple2.Trigger._02000533_bf {
    public static class _gamelogic_9002 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateWidget(arg1: "TypingGame");
                context.CreateWidget(arg1: "Round");
                context.WidgetAction(arg1: "Round", arg2: "SettingFinalRound", arg3: "1");
                context.WidgetAction(arg1: "Round", arg2: "SettingAllowedFailCount", arg3: "3");
                context.WidgetAction(arg1: "Round", arg2: "SettingRoundInitIfFail", arg3: "0");
                context.LockMyPc(isLock: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "GameLogicStart", value: 1)) {
                    context.State = new State게임진입(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임진입 : TriggerState {
            internal State게임진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State새라운드시작가능체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State새라운드시작가능체크 : TriggerState {
            internal State새라운드시작가능체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Round", arg2: "GameClear")) {
                    context.State = new State게임성공종료(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "Round", arg2: "GameFail")) {
                    context.State = new State게임실패종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State라운드체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드체크 : TriggerState {
            internal State라운드체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "Round", arg2: "CurrentRound", arg3: "= 1")) {
                    context.State = new State라운드1시작전UI(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "Round", arg2: "CurrentRound", arg3: "= 2")) {
                    context.State = new State라운드2시작전UI(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "Round", arg2: "CurrentRound", arg3: "= 3")) {
                    context.State = new State라운드3시작전UI(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드1시작전UI : TriggerState {
            internal State라운드1시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__0$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__1$", arg3: new int[] {6000});
                    context.WidgetAction(arg1: "TypingGame", arg2: "Start", widgetArgNum: 7, arg3: "6000");
                    context.State = new State라운드1진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드1진행 : TriggerState {
            internal State라운드1진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "1")) {
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "1");
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__2$", arg3: new int[] {3000});
                    context.State = new State라운드종료(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "0")) {
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "0");
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__3$", arg3: new int[] {3000});
                    context.State = new State라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드2시작전UI : TriggerState {
            internal State라운드2시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__4$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__5$", arg3: new int[] {4000});
                    context.WidgetAction(arg1: "TypingGame", arg2: "Start", widgetArgNum: 6, arg3: "4000");
                    context.State = new State라운드2진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드2진행 : TriggerState {
            internal State라운드2진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "1")) {
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__6$", arg3: new int[] {3000});
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "1");
                    context.State = new State라운드종료(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "0")) {
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__7$", arg3: new int[] {3000});
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "0");
                    context.State = new State라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드3시작전UI : TriggerState {
            internal State라운드3시작전UI(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__8$", arg3: new int[] {3000});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__9$", arg3: new int[] {3000});
                    context.WidgetAction(arg1: "TypingGame", arg2: "Start", widgetArgNum: 7, arg3: "3000");
                    context.State = new State라운드3진행(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드3진행 : TriggerState {
            internal State라운드3진행(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "1")) {
                    context.LockMyPc(isLock: true);
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__10$", arg3: new int[] {3000});
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "1");
                    context.State = new State라운드종료(context);
                    return;
                }

                if (context.WidgetCondition(arg1: "TypingGame", arg2: "Result", arg3: "0")) {
                    context.SetEventUI(arg1: 1, arg2: "$02000533_BF__GAMELOGIC_9002__11$", arg3: new int[] {3000});
                    context.WidgetAction(arg1: "Round", arg2: "RoundResult", arg3: "0");
                    context.State = new State라운드종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State라운드종료 : TriggerState {
            internal State라운드종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (true) {
                    context.LockMyPc(isLock: false);
                    context.State = new State새라운드시작가능체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임성공종료 : TriggerState {
            internal State게임성공종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9001, key: "GameLogicEnd", value: 1);
                context.SetUserValue(key: "GameLogicStart", value: 999);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State게임실패종료 : TriggerState {
            internal State게임실패종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 9001, key: "GameLogicEnd", value: 2);
                context.SetUserValue(key: "GameLogicStart", value: 999);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}