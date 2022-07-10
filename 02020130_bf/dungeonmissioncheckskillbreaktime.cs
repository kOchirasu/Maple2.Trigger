namespace Maple2.Trigger._02020130_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 0);
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 0);
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{601})) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss스킬브레이크시작_Waiting : TriggerState {
            internal StateBoss스킬브레이크시작_Waiting(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 701, additionalEffectId: 50004546, level: 2)) {
                    return new State던전미션_체크(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 702, additionalEffectId: 62100024, level: 2)) {
                    return new State던전미션_체크(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 703, additionalEffectId: 62100016, level: 2)) {
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
                if (context.GetUserValue(key: "IshuraSkillBreakClear") == 1 && context.GetUserValue(key: "YuperiaSkillBreakClear") == 1 && context.GetUserValue(key: "RenduebianSkillBreakClear") == 1) {
                    return new State던전미션_스킬브레이크저지_Success(context);
                }

                if (context.GetNpcExtraData(spawnId: 701, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnId: 701, additionalEffectId: 70002171, level: 1) && context.GetNpcExtraData(spawnId: 702, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnId: 702, additionalEffectId: 70002171, level: 1) && context.GetNpcExtraData(spawnId: 703, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnId: 703, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_3개변수1Setting(context);
                }

                if (context.GetNpcExtraData(spawnId: 701, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 701, additionalEffectId: 70002171, level: 1)) {
                    return new StateIshura미션_변수1Setting(context);
                }

                if (context.GetNpcExtraData(spawnId: 702, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 702, additionalEffectId: 70002171, level: 1)) {
                    return new State유페리아미션_변수1Setting(context);
                }

                if (context.GetNpcExtraData(spawnId: 703, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 703, additionalEffectId: 70002171, level: 1)) {
                    return new State렌듀비앙미션_변수1Setting(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 701, additionalEffectId: 50000264, level: 1)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 702, additionalEffectId: 50000264, level: 3)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 703, additionalEffectId: 50000264, level: 2)) {
                    return new StateBoss스킬브레이크시작_Waiting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_3개변수1Setting : TriggerState {
            internal State던전미션_3개변수1Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 1);
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 1);
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIshura미션_변수1Setting : TriggerState {
            internal StateIshura미션_변수1Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State유페리아미션_변수1Setting : TriggerState {
            internal State유페리아미션_변수1Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙미션_변수1Setting : TriggerState {
            internal State렌듀비앙미션_변수1Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    return new State던전미션_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_Success : TriggerState {
            internal State던전미션_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23040004);
            }

            public override TriggerState? Execute() {
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

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
