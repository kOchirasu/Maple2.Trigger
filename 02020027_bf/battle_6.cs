namespace Maple2.Trigger._02020027_bf {
    public static class _battle_6 {
        public class StateBattleStart : TriggerState {
            internal StateBattleStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990009, key: "summon_2", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1003})) {
                    return new StateSkill사용(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill사용 : TriggerState {
            internal StateSkill사용(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "summon_2") == 1) {
                    return new StateMonster소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonster소환 : TriggerState {
            internal StateMonster소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: false, arg3: 1000);
            }

            public override TriggerState? Execute() {
                // return new State길막삭제(context);
                    return null;
            }

            public override void OnExit() { }
        }
    }
}
