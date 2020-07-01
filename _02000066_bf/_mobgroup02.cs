using System;

namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup02 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작(context);

        private class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1101});
                context.DestroyMonster(arg1: new int[] {1102});
                context.DestroyMonster(arg1: new int[] {1103});
                context.DestroyMonster(arg1: new int[] {1104});
                context.DestroyMonster(arg1: new int[] {1105});
                context.DestroyMonster(arg1: new int[] {1106});
                context.DestroyMonster(arg1: new int[] {1107});
                context.DestroyMonster(arg1: new int[] {1108});
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {103})) {
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
                context.SetTimer(arg1: "45", arg2: 45);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {900})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "45")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 22);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {901})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "40", arg2: 40);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {902})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "40")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 33);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {904})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "33")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 16);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {905})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "16")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "28", arg2: 28);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {906})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "28")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 25);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {908})) {
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

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 13);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {909})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "13")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 22);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {910})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "22")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {912})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "20")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {913})) {
                    context.State = new State대기시간(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 16);
                context.CreateMonster(arg1: new int[] {1101}, arg2: false);
                context.CreateMonster(arg1: new int[] {1102}, arg2: false);
                context.CreateMonster(arg1: new int[] {1103}, arg2: false);
                context.CreateMonster(arg1: new int[] {1104}, arg2: false);
                context.CreateMonster(arg1: new int[] {1105}, arg2: false);
                context.CreateMonster(arg1: new int[] {1106}, arg2: false);
                context.CreateMonster(arg1: new int[] {1107}, arg2: false);
                context.CreateMonster(arg1: new int[] {1108}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {914})) {
                    context.State = new State소멸(context);
                    return;
                }

                if (context.TimeExpired(arg1: "16")) {
                    context.State = new State대기시간(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {1101});
                context.DestroyMonster(arg1: new int[] {1102});
                context.DestroyMonster(arg1: new int[] {1103});
                context.DestroyMonster(arg1: new int[] {1104});
                context.DestroyMonster(arg1: new int[] {1105});
                context.DestroyMonster(arg1: new int[] {1106});
                context.DestroyMonster(arg1: new int[] {1107});
                context.DestroyMonster(arg1: new int[] {1108});
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