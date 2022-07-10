namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003107 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003105, 10003106}, questStates: new byte[]{2})) {
                    return new StateNpcSpawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn_01 : TriggerState {
            internal StateNpcSpawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{502}, arg2: true);
                context.SetNpcEmotionSequence(spawnId: 502, sequenceName: "Idle_A");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
