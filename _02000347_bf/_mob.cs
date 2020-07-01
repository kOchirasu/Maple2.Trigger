namespace Maple2.Trigger._02000347_bf {
    public static class _mob {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {60002})) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010});
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 0)) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State랜덤몬스터소환 : TriggerState {
            internal State랜덤몬스터소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State1번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State2번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State3번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State4번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State5번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State6번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State7번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State8번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State9번소환(context);
                    return;
                }

                if (context.RandomCondition(arg1: 10f)) {
                    context.State = new State10번소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번소환 : TriggerState {
            internal State1번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1001});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번소환 : TriggerState {
            internal State2번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1002});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번소환 : TriggerState {
            internal State3번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1003});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번소환 : TriggerState {
            internal State4번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1004});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번소환 : TriggerState {
            internal State5번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1005});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6번소환 : TriggerState {
            internal State6번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1006});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7번소환 : TriggerState {
            internal State7번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1007});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8번소환 : TriggerState {
            internal State8번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1008});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9번소환 : TriggerState {
            internal State9번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1009});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10번소환 : TriggerState {
            internal State10번소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1010});
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State랜덤몬스터소환(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10000804}, arg2: 1)) {
                    context.State = new State시작(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}