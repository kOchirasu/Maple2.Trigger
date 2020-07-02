namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

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
                context.SetTimer(arg1: "45", arg2: 45);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {900})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "45")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 22);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {901})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "22")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "40", arg2: 40);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "40")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "33", arg2: 33);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {904})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "33")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 16);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {905})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "16")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "28", arg2: 28);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "28")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "25", arg2: 25);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {908})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "25")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "13", arg2: 13);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {909})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "13")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "22", arg2: 22);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "22")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "20", arg2: 20);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {912})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "20")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {913})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(arg1: "10")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "16", arg2: 16);
                context.CreateMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(arg1: "16")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
            }

            public override TriggerState Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}