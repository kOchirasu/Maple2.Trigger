namespace Maple2.Trigger._82000000_survival {
    public static class _209_boat {
        public class StateBoatPatrol : TriggerState {
            internal StateBoatPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcToPatrolInBox(boxId: 9509, npcId: 11400001, spawnId: "interactObject", patrolName: "MS2PatrolData_209");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateBoatPatrol(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}