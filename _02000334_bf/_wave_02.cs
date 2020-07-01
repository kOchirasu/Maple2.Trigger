namespace Maple2.Trigger._02000334_bf {
    public static class _wave_02 {
        public class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 90099, arg2: new[] {151})) {
                    context.State = new State1차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성랜덤 : TriggerState {
            internal State생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 12f)) {
                    context.State = new State1번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 13f)) {
                    context.State = new State2번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12f)) {
                    context.State = new State3번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 13f)) {
                    context.State = new State4번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12f)) {
                    context.State = new State5번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 13f)) {
                    context.State = new State6번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12f)) {
                    context.State = new State7번생성(context);
                    return;
                }

                if (context.RandomCondition(arg1: 13f)) {
                    context.State = new State8번생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1번생성 : TriggerState {
            internal State1번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {115}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {115}, arg2: true);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}