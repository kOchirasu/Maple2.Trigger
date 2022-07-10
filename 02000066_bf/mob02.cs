namespace Maple2.Trigger._02000066_bf {
    public static class _mob02 {
        public class StateWaitTime : TriggerState {
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
                context.SetTimer(timerId: "12", seconds: 12);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{900})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "12")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2차타이머 : TriggerState {
            internal State2차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "10", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{901})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3차타이머 : TriggerState {
            internal State3차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{902})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "9")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4차타이머 : TriggerState {
            internal State4차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "8", seconds: 8);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{904})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "8")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5차타이머 : TriggerState {
            internal State5차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{905})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "7")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6차타이머 : TriggerState {
            internal State6차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{906})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "6")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7차타이머 : TriggerState {
            internal State7차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{908})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8차타이머 : TriggerState {
            internal State8차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{909})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9차타이머 : TriggerState {
            internal State9차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{910})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State10차타이머 : TriggerState {
            internal State10차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{912})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State11차타이머 : TriggerState {
            internal State11차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{913})) {
                    return new StateWaitTime(context);
                }

                if (context.TimeExpired(timerId: "3")) {
                    return new StateCreationRandom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State12차타이머 : TriggerState {
            internal State12차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{914})) {
                    return new State소멸(context);
                }

                if (context.TimeExpired(timerId: "3")) {
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
                context.CreateMonster(spawnIds: new []{1101}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1102}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1103}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1104}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1105}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1106}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State7TimedCreation : TriggerState {
            internal State7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1107}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State8TimedCreation : TriggerState {
            internal State8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{1108}, arg2: false);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
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
