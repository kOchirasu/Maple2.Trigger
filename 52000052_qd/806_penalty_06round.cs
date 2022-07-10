namespace Maple2.Trigger._52000052_qd {
    public static class _806_penalty_06round {
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
                context.CreateMonster(spawnIds: new []{90682, 90688}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90683, 90685}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90694, 90696}, arg2: false);
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
                context.CreateMonster(spawnIds: new []{90691, 90693}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{90680, 90681, 90682, 90683, 90684, 90685, 90686, 90687, 90688, 90689, 90690, 90691, 90692, 90693, 90694, 90695, 90696, 90697, 90698, 90699})) {
                    return new StatePenaltyFinished01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished01 : TriggerState {
            internal StatePenaltyFinished01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{90680, 90681, 90682, 90683, 90684, 90685, 90686, 90687, 90688, 90689, 90690, 90691, 90692, 90693, 90694, 90695, 90696, 90697, 90698, 90699});
                context.SetUserValue(triggerId: 906, key: "PenaltyFinish", value: 1);
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
