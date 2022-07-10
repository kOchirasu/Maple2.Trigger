namespace Maple2.Trigger._02020051_bf {
    public static class _106_summon_mob_2 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{1001}, isStart: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon_monster_2") == 1) {
                    return new StateMonsterSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterSpawn : TriggerState {
            internal StateMonsterSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{1001}, isStart: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State리셋(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State리셋 : TriggerState {
            internal State리셋(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Summon_monster_2") == 2) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
