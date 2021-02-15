namespace Maple2.Trigger._02100000_bf {
    public static class _spawnpoint {
        public class State리Spawn변경_1 : TriggerState {
            internal State리Spawn변경_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103})) { }

                return null;
            }

            public override void OnExit() { }
        }
    }
}