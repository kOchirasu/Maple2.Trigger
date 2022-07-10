namespace Maple2.Trigger._02020101_bf {
    public static class _skillbreak {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900001, key: "SkillBreakFail", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.CheckNpcAdditionalEffect(spawnId: 101, additionalEffectId: 70002181, level: 1)) {
                    return new StateSkill브레이크_실패(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크_실패 : TriggerState {
            internal StateSkill브레이크_실패(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 70002151, level: 1, arg5: false);
                context.SetUserValue(triggerId: 900001, key: "SkillBreakFail", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
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
