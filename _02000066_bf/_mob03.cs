namespace Maple2.Trigger._02000066_bf {
    public static class _mob03 {
        public class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "80", arg2: 80);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "80")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "75", arg2: 75);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "75")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "68", arg2: 68);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "68")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "63", arg2: 63);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {905})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "63")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "58", arg2: 58);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "58")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "68", arg2: 68);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "68")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "62", arg2: 62);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {909})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "62")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "60")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "55", arg2: 55);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "55")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "52", arg2: 52);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    return new State대기시간(context);
                }

                if (context.TimeExpired(arg1: "52")) {
                    return new State생성랜덤(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "49", arg2: 49);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "49")) {
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
                context.CreateMonster(arg1: new[] {1201}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State2번생성 : TriggerState {
            internal State2번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1202}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State3번생성 : TriggerState {
            internal State3번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1203}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State4번생성 : TriggerState {
            internal State4번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1204}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State5번생성 : TriggerState {
            internal State5번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1205}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State6번생성 : TriggerState {
            internal State6번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1206}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State7번생성 : TriggerState {
            internal State7번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1207}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State8번생성 : TriggerState {
            internal State8번생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {1208}, arg2: false);
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208});
            }

            public override TriggerState Execute() {
                return new State대기시간(context);
            }

            public override void OnExit() { }
        }
    }
}