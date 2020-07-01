namespace Maple2.Trigger._02020101_bf {
    public static class _skillbreakmission {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크 : TriggerState {
            internal State던전미션_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetNpcExtraData(spawnPointId: 101, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_성공(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new State던전미션_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23038004);
            }

            public override TriggerState Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new State대기(context);
                }

                return null;
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