namespace Maple2.Trigger._02020101_bf {
    public static class _skillbreakmission2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100024, level: 1)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크 : TriggerState {
            internal State던전미션_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_성공(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23038005);
            }

            public override void Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 62100024, level: 1)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}