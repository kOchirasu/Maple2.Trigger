namespace Maple2.Trigger._80000008_bonus {
    public static class _trigger_05 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 808, 809, 810}, visible: false);
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000212}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000212}, arg2: 0)) {
                    return new State소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 401, spawnIds: new []{105})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.SetTimer(timerId: "5", seconds: 1);
                context.SetTimer(timerId: "6", seconds: 1, clearAtZero: true);
                context.SetEffect(triggerIds: new []{801, 802, 803, 804, 805, 806, 807, 808, 809, 810}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "5")) {
                    return new State꽝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State꽝 : TriggerState {
            internal State꽝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102, 103, 104, 105});
                context.SetMesh(triggerIds: new []{201, 202, 203, 204, 205}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10000208, 10000209, 10000210, 10000211, 10000212}, state: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
