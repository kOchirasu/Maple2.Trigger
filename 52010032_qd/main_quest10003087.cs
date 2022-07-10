namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003087 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003086, 10003087}, questStates: new byte[]{2})) {
                    return new StateNpcSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{601, 602}, arg2: true);
                context.SetNpcEmotionSequence(spawnId: 601, sequenceName: "Idle_A");
                context.SetNpcEmotionSequence(spawnId: 602, sequenceName: "Idle_A");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
