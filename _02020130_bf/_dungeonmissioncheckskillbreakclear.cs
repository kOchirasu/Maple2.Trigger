namespace Maple2.Trigger._02020130_bf {
    public static class _dungeonmissioncheckskillbreakclear {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {601})) {
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
                    return new State던전미션_스킬브레이크저지_성공(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_성공(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션_스킬브레이크저지_성공(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 701, additionalEffectId: 50000264, level: 1)) {
                    return new State보스스킬브레이크시작_대기중(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 702, additionalEffectId: 50000264, level: 3)) {
                    return new State보스스킬브레이크시작_대기중(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 703, additionalEffectId: 50000264, level: 2)) {
                    return new State보스스킬브레이크시작_대기중(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23040005);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1100)) {
                    return new State종료(context);
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