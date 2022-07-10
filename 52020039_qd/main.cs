namespace Maple2.Trigger._52020039_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000590}, questStates: new byte[]{3})) {
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000600}, questStates: new byte[]{1})) {
                    return new StateNPC소환(context);
                }

                if (context.QuestUserDetected(boxIds: new []{9001}, questIds: new []{91000600}, questStates: new byte[]{2})) {
                    return new StateNPC소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC소환 : TriggerState {
            internal StateNPC소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120}, arg2: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
