namespace Maple2.Trigger._52010023_qd {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.CreateMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002500}, questStates: new byte[]{2})) {
                    return new StateEvent_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_01 : TriggerState {
            internal StateEvent_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$52010023_QD__MAIN__0$", arg4: 5);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 702, spawnIds: new []{101})) {
                    return new StateNpc_out(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_out : TriggerState {
            internal StateNpc_out(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.DestroyMonster(spawnIds: new []{101});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
