namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreakmission2 {
        public class StateWait1 : TriggerState {
            internal StateWait1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 111, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션_체크1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크1 : TriggerState {
            internal State던전미션_체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success1 : TriggerState {
            internal State던전미션_스킬브레이크저지_Success1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039005);
            }

            public override TriggerState? Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 62100016, level: 1)) {
                    return new StateWait2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait2 : TriggerState {
            internal StateWait2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 151, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션_체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크2 : TriggerState {
            internal State던전미션_체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success2 : TriggerState {
            internal State던전미션_스킬브레이크저지_Success2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039005);
            }

            public override TriggerState? Execute() {
                return new StateEnd(context);
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
