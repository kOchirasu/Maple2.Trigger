namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreakmission {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 1) {
                    context.State = new State대기_1차_발동체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기_1차_발동체크 : TriggerState {
            internal State대기_1차_발동체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 111, additionalEffectId: 62100016, level: 1)) {
                    context.State = new State던전미션1차_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_체크 : TriggerState {
            internal State던전미션1차_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 111, extraDataKey: "brokenShieldRemainTick") >= 8000
                    && context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State던전미션1차_스킬브레이크저지_성공(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002181, level: 1)) {
                    context.State = new State던전미션1차_스킬브레이크저지_실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션1차_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039004);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기_2차(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션1차_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기_2차(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기_2차 : TriggerState {
            internal State대기_2차(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 115, additionalEffectId: 62100016, level: 1)) {
                    context.State = new State던전미션2차_체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_체크 : TriggerState {
            internal State던전미션2차_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.GetNpcExtraData(spawnPointId: 115, extraDataKey: "brokenShieldRemainTick") >= 8000
                    && context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002171, level: 1)) {
                    context.State = new State던전미션2차_스킬브레이크저지_성공(context);
                    return;
                }

                if (context.CheckNpcAdditionalEffect(spawnPointId: 101, additionalEffectId: 70002181, level: 1)) {
                    context.State = new State던전미션2차_스킬브레이크저지_실패(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_스킬브레이크저지_성공 : TriggerState {
            internal State던전미션2차_스킬브레이크저지_성공(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039004);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션2차_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    context.State = new State대기(context);
                    return;
                }

                if (context.WaitTick(waitTick: 1000)) {
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