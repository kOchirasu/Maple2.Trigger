namespace Maple2.Trigger._02000066_bf {
    public static class _mob02 {
        public class State대기시간 : TriggerState {
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
                context.SetTimer(arg1: "12", arg2: 12);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "12")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "9")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "8", arg2: 8);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "8")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {905})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "7")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "6")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {909})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "3")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    return new State소멸(context);
                }

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
                context.CreateMonster(arg1: new[] {1101}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1102}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1103}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1104}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1105}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1106}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1107}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1108}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }
    }
}