using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1501});
                context.DestroyMonster(arg1: new int[] {1502});
                context.DestroyMonster(arg1: new int[] {1503});
                context.DestroyMonster(arg1: new int[] {1504});
                context.DestroyMonster(arg1: new int[] {1505});
                context.DestroyMonster(arg1: new int[] {1506});
                context.DestroyMonster(arg1: new int[] {1507});
                context.DestroyMonster(arg1: new int[] {1508});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "103")) {
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
                if (context.NpcDetected(arg1: 102, arg2: new int[] {900})) {
                    context.State = new State1차타이머(context);
                    return;
                }

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

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 14);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {900})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "6", arg2: 6);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "6")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {904})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {905})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "11", arg2: 11);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {908})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "11")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "5", arg2: 5);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {909})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "5")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "14", arg2: 14);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {912})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "14")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "7", arg2: 7);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {913})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "7")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 13);
                context.CreateMonster(arg1: new int[] {1501}, arg2: false);
                context.CreateMonster(arg1: new int[] {1502}, arg2: false);
                context.CreateMonster(arg1: new int[] {1503}, arg2: false);
                context.CreateMonster(arg1: new int[] {1504}, arg2: false);
                context.CreateMonster(arg1: new int[] {1505}, arg2: false);
                context.CreateMonster(arg1: new int[] {1506}, arg2: false);
                context.CreateMonster(arg1: new int[] {1507}, arg2: false);
                context.CreateMonster(arg1: new int[] {1508}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1501});
                context.DestroyMonster(arg1: new int[] {1502});
                context.DestroyMonster(arg1: new int[] {1503});
                context.DestroyMonster(arg1: new int[] {1504});
                context.DestroyMonster(arg1: new int[] {1505});
                context.DestroyMonster(arg1: new int[] {1506});
                context.DestroyMonster(arg1: new int[] {1507});
                context.DestroyMonster(arg1: new int[] {1508});
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