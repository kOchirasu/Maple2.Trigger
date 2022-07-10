namespace Maple2.Trigger._02000066_bf {
    public static class _mob04 {
        public class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 102, spawnIds: new []{900})) {
                    return new State1차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{902})) {
                    return new State3차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{904})) {
                    return new State4차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{906})) {
                    return new State6차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{908})) {
                    return new State7차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{910})) {
                    return new State9차타이머(context);
                }

                if (context.NpcDetected(boxId: 102, spawnIds: new []{912})) {
                    return new State10차타이머(context);
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
                context.SetTimer(timerId: "25", seconds: 25);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "25")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "23", seconds: 23);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "23")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "21", seconds: 21);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{904})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "21")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "19", seconds: 19);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "19")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "20", seconds: 20);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{908})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "20")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "18", seconds: 18);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "18")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "16", seconds: 16);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{912})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "16")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "14", seconds: 14);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "14")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreationRandom : TriggerState {
            internal StateCreationRandom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 12f)) {
                    return new State1TimedCreation(context);
                }

                if (context.RandomCondition(rate: 13f)) {
                    return new State2TimedCreation(context);
                }

                if (context.RandomCondition(rate: 12f)) {
                    return new State3TimedCreation(context);
                }

                if (context.RandomCondition(rate: 13f)) {
                    return new State4TimedCreation(context);
                }

                if (context.RandomCondition(rate: 12f)) {
                    return new State5TimedCreation(context);
                }

                if (context.RandomCondition(rate: 13f)) {
                    return new State6TimedCreation(context);
                }

                if (context.RandomCondition(rate: 12f)) {
                    return new State7TimedCreation(context);
                }

                if (context.RandomCondition(rate: 13f)) {
                    return new State8TimedCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1TimedCreation : TriggerState {
            internal State1TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1301}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1302}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1303}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1304}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1305}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1306}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State7TimedCreation : TriggerState {
            internal State7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1307}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State8TimedCreation : TriggerState {
            internal State8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1308}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State소멸 : TriggerState {
            internal State소멸(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308});
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}
