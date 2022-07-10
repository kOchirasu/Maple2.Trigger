namespace Maple2.Trigger._02000066_bf {
    public static class _mob06 {
        public class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{902})) {
                    return new State3차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{906})) {
                    return new State6차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{910})) {
                    return new State9차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{914})) {
                    return new State12차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new State3차Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "5")) {
                    return new State6차Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "40", seconds: 40);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "40")) {
                    return new State9차Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "20")) {
                    return new State12차Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차Creation : TriggerState {
            internal State3차Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1299}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차Creation : TriggerState {
            internal State6차Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1299}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차Creation : TriggerState {
            internal State9차Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1299}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차Creation : TriggerState {
            internal State12차Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1299}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1299});
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}
