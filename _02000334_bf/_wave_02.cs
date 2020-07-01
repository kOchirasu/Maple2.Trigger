namespace Maple2.Trigger._02000334_bf {
    public static class _wave_02 {
        public class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new[] {151})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "5")) {
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
                if (context.RandomCondition(arg1: 12f)) {
                    return new State1번생성(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State2번생성(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new State3번생성(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State4번생성(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new State5번생성(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State6번생성(context);
                }

                if (context.RandomCondition(arg1: 12f)) {
                    return new State7번생성(context);
                }

                if (context.RandomCondition(arg1: 13f)) {
                    return new State8번생성(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {115}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {115}, arg2: true);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }
    }
}