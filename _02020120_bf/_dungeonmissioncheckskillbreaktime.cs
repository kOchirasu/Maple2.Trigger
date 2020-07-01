namespace Maple2.Trigger._02020120_bf {
    public static class _dungeonmissioncheckskillbreaktime {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {199})) {
                    return new State보스스킬브레이크시작_대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State보스스킬브레이크시작_대기중 : TriggerState {
            internal State보스스킬브레이크시작_대기중(ITriggerContext context) : base(context) { }

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
                    return new State던전미션_스킬브레이크저지_성공(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 99, additionalEffectId: 50000367, level: 1)) {
                    return new State던전미션_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23037004);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State종료(context);
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
                    return new State시작대기중(context);
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