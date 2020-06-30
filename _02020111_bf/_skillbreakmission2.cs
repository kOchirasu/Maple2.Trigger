using System;

namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreakmission2 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기1(context);

        private class State대기1 : TriggerState {
            internal State대기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 111, additionalEffectID: 62100016, level: 1)) {
                    context.State = new State던전미션_체크1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크1 : TriggerState {
            internal State던전미션_체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_성공1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공1 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 23039005);
            }

            public override void Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 62100016, level: 1)) {
                    context.State = new State대기2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 151, additionalEffectID: 62100016, level: 1)) {
                    context.State = new State던전미션_체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크2 : TriggerState {
            internal State던전미션_체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointID: 101, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_성공2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공2 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 23039005);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}