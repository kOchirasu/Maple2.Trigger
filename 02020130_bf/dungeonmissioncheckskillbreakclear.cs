namespace Maple2.Trigger._02020130_bf {
    public static class _dungeonmissioncheckskillbreakclear {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {601})) {
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
                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 50004546, level: 2)) {
                    return new State던전미션_체크(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 62100024, level: 2)) {
                    return new State던전미션_체크(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 62100016, level: 2)) {
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
                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 50000264, level: 1)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 50000264, level: 3)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 50000264, level: 2)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success : TriggerState {
            internal State던전미션_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23040005);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new StateEnd(context);
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