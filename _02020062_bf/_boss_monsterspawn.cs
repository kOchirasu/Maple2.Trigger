namespace Maple2.Trigger._02020062_bf {
    public static class _boss_monsterspawn {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 1) {
                    context.State = new State스폰(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스폰 : TriggerState {
            internal State스폰(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "MonsterSpawn") == 0) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new[] {494}, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}