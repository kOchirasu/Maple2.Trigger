namespace Maple2.Trigger._02020065_bf {
    public static class _battle3_spawnend {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {811, 812, 813, 814})) {
                    context.SetUserValue(triggerId: 99990006, key: "Battle_3_SpawnStart", value: 0);
                }
            }

            public override void OnExit() { }
        }
    }
}