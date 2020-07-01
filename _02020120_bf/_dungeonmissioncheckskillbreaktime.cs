using System;

namespace Maple2.Trigger._02020120_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {199})) {
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
                if (context.CheckNpcAdditionalEffect(spawnPointID: 99, additionalEffectID: 50004546, level: 1)) {
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
                if (context.CheckNpcExtraData(spawnPointID: 99, extraDataKey: "brokenShieldRemainTick",
                        extraDataValue: 8000, @operator: "GreaterEqual")
                    && context.CheckNpcAdditionalEffect(spawnPointID: 99, additionalEffectID: 70002171, level: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_성공(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointID: 99, additionalEffectID: 50000367, level: 1)) {
                    context.State = new State던전미션_스킬브레이크저지_실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionID: 23037004);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.CheckNpcAdditionalEffect(spawnPointID: 99, additionalEffectID: 50004546, level: 1)) {
                    context.State = new State시작대기중(context);
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