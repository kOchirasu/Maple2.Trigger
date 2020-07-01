namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup03 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new[] {900})) {
                    return new State1차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {901})) {
                    return new State2차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {902})) {
                    return new State3차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {904})) {
                    return new State4차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {905})) {
                    return new State5차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {906})) {
                    return new State6차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {908})) {
                    return new State7차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {909})) {
                    return new State8차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {910})) {
                    return new State9차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {912})) {
                    return new State10차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {913})) {
                    return new State11차타이머(context);
                }

                if (context.NpcDetected(arg1: 102, arg2: new[] {914})) {
                    return new State12차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 14);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "14")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "6")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "11")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "11")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {905})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "11")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {909})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "5")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 14);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "14")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 7);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "7")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 13);
                context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "13")) {
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508});
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }
    }
}