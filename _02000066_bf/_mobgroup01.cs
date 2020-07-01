namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup01 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.DestroyMonster(arg1: new[] {1002});
                context.DestroyMonster(arg1: new[] {1003});
                context.DestroyMonster(arg1: new[] {1004});
                context.DestroyMonster(arg1: new[] {1005});
                context.DestroyMonster(arg1: new[] {1006});
                context.DestroyMonster(arg1: new[] {1007});
                context.DestroyMonster(arg1: new[] {1008});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {900})) {
                    context.State = new State1차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {902})) {
                    context.State = new State3차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {904})) {
                    context.State = new State4차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {906})) {
                    context.State = new State6차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {908})) {
                    context.State = new State7차타이머(context);
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

                if (context.NpcDetected(arg1: 102, arg2: new[] {914})) {
                    context.State = new State12차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "51", arg2: 51);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "51")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "42", arg2: 42);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "42")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "37", arg2: 37);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "37")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 33);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "30", arg2: 30);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "30")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "27", arg2: 27);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "27")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 25);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "25")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
                context.CreateMonster(arg1: new[] {1001}, arg2: false);
                context.CreateMonster(arg1: new[] {1002}, arg2: false);
                context.CreateMonster(arg1: new[] {1003}, arg2: false);
                context.CreateMonster(arg1: new[] {1004}, arg2: false);
                context.CreateMonster(arg1: new[] {1005}, arg2: false);
                context.CreateMonster(arg1: new[] {1006}, arg2: false);
                context.CreateMonster(arg1: new[] {1007}, arg2: false);
                context.CreateMonster(arg1: new[] {1008}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1001});
                context.DestroyMonster(arg1: new[] {1002});
                context.DestroyMonster(arg1: new[] {1003});
                context.DestroyMonster(arg1: new[] {1004});
                context.DestroyMonster(arg1: new[] {1005});
                context.DestroyMonster(arg1: new[] {1006});
                context.DestroyMonster(arg1: new[] {1007});
                context.DestroyMonster(arg1: new[] {1008});
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