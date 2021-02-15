namespace Maple2.Trigger._02020120_bf {
    public static class _dungeonmissioncheckskillbreakclear {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "SkillBreakSuccess") == 1) {
                    return new StateSkill브레이크Success_Dungeon미션랭크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill브레이크Success_Dungeon미션랭크 : TriggerState {
            internal StateSkill브레이크Success_Dungeon미션랭크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonMissionComplete(missionId: 23037005);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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