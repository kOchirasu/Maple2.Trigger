namespace Maple2.Trigger._02000091_bf {
    public static class _im_102 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000533}, state: 1);
                context.SetActor(triggerId: 2102, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000533}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{102});
                context.SetActor(triggerId: 2102, visible: false, initialSequence: "Idle_A");
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_Gull_102");
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 1102, spawnIds: new []{102})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{102});
                context.SetTimer(timerId: "102", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "102")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
