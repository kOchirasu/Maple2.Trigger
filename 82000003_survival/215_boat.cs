namespace Maple2.Trigger._82000003_survival {
    public static class _215_boat {
        public class StateBoatPatrol : TriggerState {
            internal StateBoatPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcToPatrolInBox(boxId: 9515, npcId: 11400001, spawnId: "interactObject", patrolName: "MS2PatrolData_215");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateBoatPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
