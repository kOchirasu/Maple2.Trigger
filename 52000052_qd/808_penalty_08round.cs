namespace Maple2.Trigger._52000052_qd {
    public static class _808_penalty_08round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyMob", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "PenaltyMob") == 1) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart01 : TriggerState {
            internal State1stWaveStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90886, 90888}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State1stWaveStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart02 : TriggerState {
            internal State1stWaveStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90881, 90883}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State2ndWaveStart01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart01 : TriggerState {
            internal State2ndWaveStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90890, 90892}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State2ndWaveStart02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart02 : TriggerState {
            internal State2ndWaveStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{90897, 90899}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{90880, 90881, 90882, 90883, 90884, 90885, 90886, 90887, 90888, 90889, 90890, 90891, 90892, 90893, 90894, 90895, 90896, 90897, 90898, 90899})) {
                    return new StatePenaltyFinished01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished01 : TriggerState {
            internal StatePenaltyFinished01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{90880, 90881, 90882, 90883, 90884, 90885, 90886, 90887, 90888, 90889, 90890, 90891, 90892, 90893, 90894, 90895, 90896, 90897, 90898, 90899});
                context.SetUserValue(triggerId: 908, key: "PenaltyFinish", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePenaltyFinished02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished02 : TriggerState {
            internal StatePenaltyFinished02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
