namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup02 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{900})) {
                    return new State1차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{901})) {
                    return new State2차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{902})) {
                    return new State3차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{904})) {
                    return new State4차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{905})) {
                    return new State5차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{906})) {
                    return new State6차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{908})) {
                    return new State7차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{909})) {
                    return new State8차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{910})) {
                    return new State9차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{912})) {
                    return new State10차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{913})) {
                    return new State11차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{914})) {
                    return new State12차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "45", seconds: 45);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "45")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 22);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "22")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "40", seconds: 40);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "40")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "33", seconds: 33);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{904})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "33")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "16", seconds: 16);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{905})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "16")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "28", seconds: 28);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "28")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "25", seconds: 25);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{908})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "25")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 13);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{909})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "13")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "22", seconds: 22);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "22")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 20);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{912})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "20")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{913})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "16", seconds: 16);
                context.CreateMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "16")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108});
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}
