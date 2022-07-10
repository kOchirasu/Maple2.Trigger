namespace Maple2.Trigger._02000499_bf {
    public static class _event_a {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104}, arg2: false);
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_3008");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_3009");
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3010");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3011");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104})) {
                    return new StateCompleteEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5001, 5002, 5003, 5004}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
