namespace Maple2.Trigger._02000066_bf {
    public static class _mob05 {
        public class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {901})) {
                    context.State = new State2차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {905})) {
                    context.State = new State5차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {908})) {
                    context.State = new State7차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {909})) {
                    context.State = new State8차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {910})) {
                    context.State = new State9차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {912})) {
                    context.State = new State10차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {913})) {
                    context.State = new State11차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {914})) {
                    context.State = new State12차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 13);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {905})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {909})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "9")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 8);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "8")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성랜덤 : TriggerState {
            internal State생성랜덤(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1401, 1402, 1403, 1404}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1401, 1402, 1403, 1404});
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