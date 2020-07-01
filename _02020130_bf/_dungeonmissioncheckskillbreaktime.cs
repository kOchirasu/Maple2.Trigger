namespace Maple2.Trigger._02020130_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 0);
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 0);
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {601})) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스스킬브레이크시작_대기중 : TriggerState {
            internal State보스스킬브레이크시작_대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 50004546, level: 2)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 62100024, level: 2)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 62100016, level: 2)) {
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
                if (context.GetUserValue(key: "IshuraSkillBreakClear") == 1 && context.GetUserValue(key: "YuperiaSkillBreakClear") == 1 && context.GetUserValue(key: "RenduebianSkillBreakClear") == 1) {
                    context.State = new State던전미션_스킬브레이크저지_성공(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 701, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 70002171, level: 1) && context.GetNpcExtraData(spawnPointId: 702, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 70002171, level: 1) && context.GetNpcExtraData(spawnPointId: 703, extraDataKey: "brokenShieldRemainTick") >= 6000 && context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State던전미션_3개변수1셋팅(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 701, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State이슈라미션_변수1셋팅(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 702, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State유페리아미션_변수1셋팅(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 703, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State렌듀비앙미션_변수1셋팅(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 50000264, level: 1)) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 50000264, level: 3)) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 50000264, level: 2)) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_3개변수1셋팅 : TriggerState {
            internal State던전미션_3개변수1셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 1);
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 1);
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State이슈라미션_변수1셋팅 : TriggerState {
            internal State이슈라미션_변수1셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State유페리아미션_변수1셋팅 : TriggerState {
            internal State유페리아미션_변수1셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State렌듀비앙미션_변수1셋팅 : TriggerState {
            internal State렌듀비앙미션_변수1셋팅(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 100)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23040004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1100)) {
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