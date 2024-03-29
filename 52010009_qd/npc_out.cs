namespace Maple2.Trigger._52010009_qd {
    public static class _npc_out {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{111})) {
                    return new StateNpc_out(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{112})) {
                    return new StateNpc_out(context);
                }

                if (context.NpcDetected(boxId: 702, spawnIds: new []{113})) {
                    return new StateNpc_out(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_out : TriggerState {
            internal StateNpc_out(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111, 112, 113});
            }

            public override TriggerState? Execute() {
                return new StateIdle(context);
            }

            public override void OnExit() { }
        }
    }
}
