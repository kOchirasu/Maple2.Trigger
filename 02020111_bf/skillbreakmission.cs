namespace Maple2.Trigger._02020111_bf {
    public static class _skillbreakmission {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 1) {
                    return new StateWait_1차_발동체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_1차_발동체크 : TriggerState {
            internal StateWait_1차_발동체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 111, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션1차_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_체크 : TriggerState {
            internal State던전미션1차_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.GetNpcExtraData(spawnId: 111, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션1차_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new State던전미션1차_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_스킬브레이크저지_Success : TriggerState {
            internal State던전미션1차_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039004);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_2차(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션1차_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션1차_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_2차(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_2차 : TriggerState {
            internal StateWait_2차(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 115, additionalEffectId: 62100016, level: 1)) {
                    return new State던전미션2차_체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_체크 : TriggerState {
            internal State던전미션2차_체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.GetNpcExtraData(spawnId: 115, extraDataKey: "brokenShieldRemainTick") >= 8000 && context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002171, level: 1)) {
                    return new State던전미션2차_스킬브레이크저지_Success(context);
                }

                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new State던전미션2차_스킬브레이크저지_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_스킬브레이크저지_Success : TriggerState {
            internal State던전미션2차_스킬브레이크저지_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23039004);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State던전미션2차_스킬브레이크저지_실패 : TriggerState {
            internal State던전미션2차_스킬브레이크저지_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "SkillBreakMissionReset") == 0) {
                    return new StateWait(context);
                }

                if (context.WaitTick(waitTick: 1000)) {
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
