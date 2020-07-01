namespace Maple2.Trigger._02020051_bf {
    public static class _105_summon_mob {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {1003}, isStart: true);
                context.StartCombineSpawn(groupId: new[] {1002}, isStart: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Summon_monster") == 1) {
                    return new State몬스터등장(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State몬스터등장 : TriggerState {
            internal State몬스터등장(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {1003}, isStart: false);
                context.StartCombineSpawn(groupId: new[] {1002}, isStart: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
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
                if (context.GetUserValue(key: "Summon_monster") == 2) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}