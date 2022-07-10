namespace Maple2.Trigger._02000334_bf {
    public static class _wave_03 {
        public class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 90099, spawnIds: new []{152})) {
                    return new State1차타이머(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1차타이머 : TriggerState {
            internal State1차타이머(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
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
                context.CreateMonster(spawnIds: new []{131}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State2TimedCreation : TriggerState {
            internal State2TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{132}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State3TimedCreation : TriggerState {
            internal State3TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{133}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State4TimedCreation : TriggerState {
            internal State4TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{134}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State5TimedCreation : TriggerState {
            internal State5TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{131}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State6TimedCreation : TriggerState {
            internal State6TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{132}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State7TimedCreation : TriggerState {
            internal State7TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{133}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }

        private class State8TimedCreation : TriggerState {
            internal State8TimedCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{134}, arg2: true);
            }

            public override TriggerState? Execute() {
                return new StateWaitTime(context);
            }

            public override void OnExit() { }
        }
    }
}
