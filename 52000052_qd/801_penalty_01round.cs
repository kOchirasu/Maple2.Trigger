namespace Maple2.Trigger._52000052_qd {
    public static class _801_penalty_01round {
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
                context.CreateMonster(spawnIds: new []{90180, 90188}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90185, 90189}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90190, 90192}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90195, 90197}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{90180, 90181, 90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193, 90194, 90195, 90196, 90197, 90198, 90199})) {
                    return new StatePenaltyFinished01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished01 : TriggerState {
            internal StatePenaltyFinished01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{90180, 90181, 90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193, 90194, 90195, 90196, 90197, 90198, 90199});
                context.SetUserValue(triggerId: 901, key: "PenaltyFinish", value: 1);
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
