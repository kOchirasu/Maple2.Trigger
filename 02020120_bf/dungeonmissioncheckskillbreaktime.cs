namespace Maple2.Trigger._02020120_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss스킬브레이크시작_Waiting : TriggerState {
            internal StateBoss스킬브레이크시작_Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50004546, level: 1)) {
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
                if (context.GetNpcExtraData(spawnPointId: 99, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50000367, level: 1)) {
                    return new State던전미션_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success : TriggerState {
            internal State던전미션_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23037004);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50004546, level: 1)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}