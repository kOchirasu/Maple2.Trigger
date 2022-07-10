namespace Maple2.Trigger._02000499_bf {
    public static class _event_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105, 106, 107, 108}, arg2: false);
                context.SetEffect(triggerIds: new []{5005, 5006, 5007, 5008}, visible: false);
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
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_3012");
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_3013");
                context.MoveNpc(spawnId: 107, patrolName: "MS2PatrolData_3014");
                context.MoveNpc(spawnId: 108, patrolName: "MS2PatrolData_3015");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{105, 106, 107, 108})) {
                    return new StateCompleteEffect(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCompleteEffect : TriggerState {
            internal StateCompleteEffect(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5005, 5006, 5007, 5008}, visible: true);
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
