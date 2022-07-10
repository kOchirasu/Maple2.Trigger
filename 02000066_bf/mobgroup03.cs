namespace Maple2.Trigger._02000066_bf {
    public static class _mobgroup03 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508});
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
                context.SetTimer(timerId: "14", seconds: 14);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "14")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 6);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "6")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 11);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "11")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 11);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{904})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "11")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{905})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "11", seconds: 11);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{908})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "11")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{909})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 14);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{912})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "14")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "7", seconds: 7);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{913})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "7")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "13", seconds: 13);
                context.CreateMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "13")) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508});
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}
