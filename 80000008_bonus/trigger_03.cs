namespace Maple2.Trigger._80000008_bonus {
    public static class _trigger_03 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000210}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000210}, arg2: 0)) {
                    return new State소환(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State소환 : TriggerState {
            internal State소환(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_301");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 401, spawnIds: new []{103})) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{103});
                context.SetTimer(timerId: "3", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    return new State아이템(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State아이템 : TriggerState {
            internal State아이템(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateItem(spawnIds: new []{503});
            }

            public override TriggerState? Execute() {
                return new StateWait(context);
            }

            public override void OnExit() { }
        }
    }
}
