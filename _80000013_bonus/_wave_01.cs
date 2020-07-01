namespace Maple2.Trigger._80000013_bonus {
    public static class _wave_01 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 702, arg2: new[] {199})) {
                    return new State생성랜덤(context);
                }

                return new State1차타이머(context);
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State1차타이머(context);
                }

                if (context.NpcDetected(arg1: 702, arg2: new[] {199})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State생성랜덤 : TriggerState {
            internal State생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.RandomCondition(arg1: 3f)) {
                    return new State1번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State2번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State3번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State4번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State5번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State6번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State7번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State8번생성(context);
                }

                if (context.RandomCondition(arg1: 3f)) {
                    return new State9번생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {102}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {103}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {104}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {105}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {106}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {107}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {108}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State9번생성 : TriggerState {
            internal State9번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {109}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }
    }
}