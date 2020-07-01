namespace Maple2.Trigger._02000300_bf {
    public static class _mobspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {1099})) {
                    context.State = new State랜덤생성조건(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤생성조건 : TriggerState {
            internal State랜덤생성조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State40초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State35초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State30초(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State45초(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State40초 : TriggerState {
            internal State40초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "45", arg2: 45);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "45")) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State35초 : TriggerState {
            internal State35초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "50", arg2: 50);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "50")) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State30초 : TriggerState {
            internal State30초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "55", arg2: 55);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "55")) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State45초 : TriggerState {
            internal State45초(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State생성(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 1099, arg3: "$02000300_BF__MOBSPAWN__0$", arg4: 2);
                context.SetConversation(arg1: 1, arg2: 1001, arg3: "$02000300_BF__MOBSPAWN__1$", arg4: 3);
                context.CreateMonster(arg1: new[] {1097, 1098}, arg2: true);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1097, 1098})) {
                    context.State = new State랜덤생성조건(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1099})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1098});
                context.DestroyMonster(arg1: new[] {1097});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}