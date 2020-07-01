namespace Maple2.Trigger._02000304_bf {
    public static class _move {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State몬스터체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State몬스터체크 : TriggerState {
            internal State몬스터체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterInCombat(arg1: new[] {2001})) {
                    context.State = new State카운트랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State카운트랜덤 : TriggerState {
            internal State카운트랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State이동대기01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State이동대기02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State이동대기03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State이동대기04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기01 : TriggerState {
            internal State이동대기01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "90", arg2: 90);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "90")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기02 : TriggerState {
            internal State이동대기02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "100", arg2: 100);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "100")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기03 : TriggerState {
            internal State이동대기03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "110", arg2: 110);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "110")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동대기04 : TriggerState {
            internal State이동대기04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "120", arg2: 120);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "120")) {
                    context.State = new State이동(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000304_BF__MOVE__0$", arg4: 2);
                context.SetTimer(arg1: "2", arg2: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "2")) {
                    context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000304_BF__MOVE__1$", arg4: 1);
                    context.MoveRandomUser(arg1: 02000304, arg2: 11, arg3: 101, arg4: 1);
                    context.State = new State이동2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동2 : TriggerState {
            internal State이동2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000304_BF__MOVE__2$", arg4: 1);
                    context.MoveRandomUser(arg1: 02000304, arg2: 12, arg3: 101, arg4: 1);
                    context.State = new State이동3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동3 : TriggerState {
            internal State이동3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000304_BF__MOVE__3$", arg4: 1);
                    context.MoveRandomUser(arg1: 02000304, arg2: 13, arg3: 101, arg4: 1);
                    context.State = new State이동4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이동4 : TriggerState {
            internal State이동4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {2001})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.SetConversation(arg1: 1, arg2: 2001, arg3: "$02000304_BF__MOVE__4$", arg4: 1);
                    context.MoveRandomUser(arg1: 02000304, arg2: 14, arg3: 101, arg4: 1);
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}