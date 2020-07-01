namespace Maple2.Trigger._52100107_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000890},
                    arg3: new byte[] {3})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000900},
                    arg3: new byte[] {1})) {
                    context.State = new StateNPC소환(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000900},
                    arg3: new byte[] {2})) {
                    context.State = new StateNPC소환(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}