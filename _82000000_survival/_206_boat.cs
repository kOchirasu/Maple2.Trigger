namespace Maple2.Trigger._82000000_survival {
    public static class _206_boat {
        public class StateBoatPatrol : TriggerState {
            internal StateBoatPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcToPatrolInBox(boxId: 9506, npcId: 11400001, spawnId: "interactObject", patrolName: "MS2PatrolData_206");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    context.State = new StateBoatPatrol(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}