namespace Maple2.Trigger._02020051_bf {
    public static class _106_summon_mob_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {1001}, isStart: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_monster_2") == 1) {
                    return new State몬스터등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {1001}, isStart: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_monster_2") == 2) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}