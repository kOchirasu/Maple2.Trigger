using System;

namespace Maple2.Trigger._02020130_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "IshuraSkillBreakClear", value: 0);
                context.SetUserValue(key: "RenduebianSkillBreakClear", value: 0);
                context.SetUserValue(key: "YuperiaSkillBreakClear", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {601})) {
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
                if (context.CheckNpcAdditionalEffect(spawnPointID: 701, additionalEffectID: 50004546, level: 2)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 702, additionalEffectID: 62100024, level: 2)) {
                    context.State = new State던전미션_체크(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 703, additionalEffectID: 62100016, level: 2)) {
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
                if (context.UserValue(key: "IshuraSkillBreakClear", value: 1)
                    && context.UserValue(key: "YuperiaSkillBreakClear", value: 1)
                    && context.UserValue(key: "RenduebianSkillBreakClear", value: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_성공(context);
                    return;
                }

                if (context.CheckNpcExtraData(spawnPointID: 701, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 6000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 701, additionalEffectID: 70002171, level: 1)
                    && context.CheckNpcExtraData(spawnPointID: 702, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 6000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 702, additionalEffectID: 70002171, level: 1)
                    && context.CheckNpcExtraData(spawnPointID: 703, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 6000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 703, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State던전미션_3개변수1셋팅(context);
                    return;
                }

                if (context.CheckNpcExtraData(spawnPointID: 701, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 8000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 701, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State이슈라미션_변수1셋팅(context);
                    return;
                }

                if (context.CheckNpcExtraData(spawnPointID: 702, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 8000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 702, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State유페리아미션_변수1셋팅(context);
                    return;
                }

                if (context.CheckNpcExtraData(spawnPointID: 703, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 8000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 703, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State렌듀비앙미션_변수1셋팅(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 701, additionalEffectID: 50000264, level: 1)) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 702, additionalEffectID: 50000264, level: 3)) {
                    context.State = new State보스스킬브레이크시작_대기중(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 703, additionalEffectID: 50000264, level: 2)) {
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
                context.DungeonMissionComplete(missionID: 23040004);
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