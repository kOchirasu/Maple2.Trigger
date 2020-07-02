namespace Maple2.Trigger._52100107_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000890}, arg3: new byte[] {3})) {
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000900}, arg3: new byte[] {1})) {
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(arg1: new[] {9001}, arg2: new[] {91000900}, arg3: new byte[] {2})) {
                    return new StateNPC소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}