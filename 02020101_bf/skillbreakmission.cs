namespace Maple2.Trigger._02020101_bf {
    public static class _skillbreakmission {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_체크 : TriggerState {
            internal State던전미션_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetNpcExtraData(spawnId: 101, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new State던전미션_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success : TriggerState {
            internal State던전미션_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23038004);
            }

            public override TriggerState? Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 62100024, level: 1)) {
                    return new StateWait(context);
                }

                return null;
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
