using System;

namespace Maple2.Trigger._52010032_qd {
    public static class _main_quest10003087 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateReady(context);

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2001}, arg2: new int[] {10003086, 10003087},
                    arg3: new byte[] {2})) {
                    context.State = new StateNpcSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {601}, arg2: true);
                context.CreateMonster(arg1: new int[] {602}, arg2: true);
                context.SetNpcEmotionSequence(arg1: 601, arg2: "Idle_A");
                context.SetNpcEmotionSequence(arg1: 602, arg2: "Idle_A");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}