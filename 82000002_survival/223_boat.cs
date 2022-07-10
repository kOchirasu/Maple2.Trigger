namespace Maple2.Trigger._82000002_survival {
    public static class _223_boat {
        public class StateBoatPatrol : TriggerState {
            internal StateBoatPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcToPatrolInBox(boxId: 9523, npcId: 11400001, spawnId: "interactObject", patrolName: "MS2PatrolData_223");
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
