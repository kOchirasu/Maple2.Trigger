namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003107 {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {2001}, arg2: new[] {10003105, 10003106},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcSpawn_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn_01 : TriggerState {
            internal StateNpcSpawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {502}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 502, arg2: "Idle_A");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}