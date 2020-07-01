namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreakmission2 {
        public class State대기1 : TriggerState {
            internal State대기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 111, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션_체크1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크1 : TriggerState {
            internal State던전미션_체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_성공1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공1 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039005);
            }

            public override TriggerState Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100016, level: 1)) {
                    return new State대기2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기2 : TriggerState {
            internal State대기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 151, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션_체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크2 : TriggerState {
            internal State던전미션_체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_성공2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공2 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039005);
            }

            public override TriggerState Execute() {
                return new State종료(context);
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}