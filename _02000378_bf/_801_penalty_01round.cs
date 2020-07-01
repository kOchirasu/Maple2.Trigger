namespace Maple2.Trigger._02000378_bf {
    public static class _801_penalty_01round {
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
                context.CreateMonster(arg1: new[] {90180, 90182, 90184, 90186, 90188}, arg2: false);
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
                context.CreateMonster(arg1: new[] {90181, 90183, 90185, 90187, 90189}, arg2: false);
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
                context.CreateMonster(arg1: new[] {90190, 90192, 90194, 90196, 90198}, arg2: false);
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
                context.CreateMonster(arg1: new[] {90191, 90193, 90195, 90197, 90199}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {
                    90180, 90181, 90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193,
                    90194, 90195, 90196, 90197, 90198, 90199
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
                    90180, 90181, 90182, 90183, 90184, 90185, 90186, 90187, 90188, 90189, 90190, 90191, 90192, 90193,
                    90194, 90195, 90196, 90197, 90198, 90199
                });
                context.SetUserValue(triggerId: 901, key: "PenaltyFinish", value: 1);
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