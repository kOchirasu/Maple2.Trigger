using System;

namespace Maple2.Trigger._02000300_bf {
    public static class _textballoon {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new int[] {1099})) {
                    context.State = new State랜덤대화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤대화 : TriggerState {
            internal State랜덤대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State20초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State25초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State30초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State35초(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State20초 : TriggerState {
            internal State20초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State25초 : TriggerState {
            internal State25초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 25);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State대화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State대화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State35초 : TriggerState {
            internal State35초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "35", arg2: 35);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "35")) {
                    context.State = new State대화(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1099})) {
                    context.State = new State종료대화(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대화 : TriggerState {
            internal State대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State대사1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State대사2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State대사3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State대사4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사1 : TriggerState {
            internal State대사1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000300_BF__TEXTBALLOON__0$", arg4: 2, arg5: 0);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사2 : TriggerState {
            internal State대사2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__1$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사3 : TriggerState {
            internal State대사3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__2$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대사4 : TriggerState {
            internal State대사4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 2);
                context.SetConversation(arg1: 1, arg2: 1004, arg3: "$02000300_BF__TEXTBALLOON__3$", arg4: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료대화 : TriggerState {
            internal State종료대화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000300_BF__TEXTBALLOON__4$", arg4: 3,
                        arg5: 0);
                    context.SetConversation(arg1: 1, arg2: 1003, arg3: "$02000300_BF__TEXTBALLOON__5$", arg4: 2,
                        arg5: 2);
                    context.SetConversation(arg1: 1, arg2: 1002, arg3: "$02000300_BF__TEXTBALLOON__6$", arg4: 2,
                        arg5: 4);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}