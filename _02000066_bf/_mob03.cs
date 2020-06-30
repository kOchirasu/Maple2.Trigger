using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _mob03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기시간(context);

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.NpcDetected(arg1: 102, arg2: new int[] {901})) {
                    context.State = new State2차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {902})) {
                    context.State = new State3차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {904})) {
                    context.State = new State4차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {905})) {
                    context.State = new State5차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {906})) {
                    context.State = new State6차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {908})) {
                    context.State = new State7차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {909})) {
                    context.State = new State8차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {910})) {
                    context.State = new State9차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {912})) {
                    context.State = new State10차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {913})) {
                    context.State = new State11차타이머(context);
                    return;
                }

                if (context.NpcDetected(arg1: 102, arg2: new int[] {914})) {
                    context.State = new State12차타이머(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "80", arg2: 80);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "80")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "75", arg2: 75);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "75")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "68", arg2: 68);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {904})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "68")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "63", arg2: 63);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {905})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "63")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "58", arg2: 58);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "58")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "68", arg2: 68);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {908})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "68")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "62", arg2: 62);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {909})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "62")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "60", arg2: 60);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "60")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "55", arg2: 55);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {912})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "55")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "52", arg2: 52);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {913})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "52")) {
                    context.State = new State생성랜덤(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "49", arg2: 49);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "49")) {
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
                context.CreateMonster(arg1: new int[] {1201}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1202}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1203}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1204}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1205}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1206}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1207}, arg2: false);
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
                context.CreateMonster(arg1: new int[] {1208}, arg2: false);
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
                context.DestroyMonster(arg1: new int[] {1201});
                context.DestroyMonster(arg1: new int[] {1202});
                context.DestroyMonster(arg1: new int[] {1203});
                context.DestroyMonster(arg1: new int[] {1204});
                context.DestroyMonster(arg1: new int[] {1205});
                context.DestroyMonster(arg1: new int[] {1206});
                context.DestroyMonster(arg1: new int[] {1207});
                context.DestroyMonster(arg1: new int[] {1208});
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