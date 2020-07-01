namespace Maple2.Trigger._52000052_qd {
    public static class _804_penalty_04round {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "PenaltyMob", value: 0);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "PenaltyMob") == 1) {
                    context.State = new StateReady(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart01 : TriggerState {
            internal State1stWaveStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90482, 90486}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State1stWaveStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1stWaveStart02 : TriggerState {
            internal State1stWaveStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90481, 90489}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new State2ndWaveStart01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart01 : TriggerState {
            internal State2ndWaveStart01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90494, 90496}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State2ndWaveStart02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2ndWaveStart02 : TriggerState {
            internal State2ndWaveStart02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {90491, 90495}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {
                    90480, 90481, 90482, 90483, 90484, 90485, 90486, 90487, 90488, 90489, 90490, 90491, 90492, 90493,
                    90494, 90495, 90496, 90497, 90498, 90499
                })) {
                    context.State = new StatePenaltyFinished01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished01 : TriggerState {
            internal StatePenaltyFinished01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {
                    90480, 90481, 90482, 90483, 90484, 90485, 90486, 90487, 90488, 90489, 90490, 90491, 90492, 90493,
                    90494, 90495, 90496, 90497, 90498, 90499
                });
                context.SetUserValue(triggerId: 904, key: "PenaltyFinish", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StatePenaltyFinished02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePenaltyFinished02 : TriggerState {
            internal StatePenaltyFinished02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}