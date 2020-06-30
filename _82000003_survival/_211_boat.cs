using System;

namespace Maple2.Trigger._82000003_survival {
    public static class _211_boat {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateBoatPatrol(context);

        private class StateBoatPatrol : TriggerState {
            internal StateBoatPatrol(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.NpcToPatrolInBox(boxId: 9511, npcId: 11400001, spawnId: "interactObject",
                    patrolName: "MS2PatrolData_211");
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