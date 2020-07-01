namespace Maple2.Trigger._02000066_bf {
    public static class _mob06 {
        public class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {902})) {
                    context.State = new State3차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {906})) {
                    context.State = new State6차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {910})) {
                    context.State = new State9차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {914})) {
                    context.State = new State12차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State3차생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State6차생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "40", arg2: 40);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "40")) {
                    context.State = new State9차생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State12차생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차생성 : TriggerState {
            internal State3차생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1299}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차생성 : TriggerState {
            internal State6차생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1299}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차생성 : TriggerState {
            internal State9차생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1299}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차생성 : TriggerState {
            internal State12차생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1299}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1299});
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