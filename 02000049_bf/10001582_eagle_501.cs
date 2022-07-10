namespace Maple2.Trigger._02000049_bf {
    public static class _10001582_eagle_501 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000052}, state: 1);
                context.SetActor(triggerId: 501, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000052}, arg2: 0)) {
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return new StateNPC이동(context);
            }

            public override void OnExit() {
                context.SetActor(triggerId: 501, visible: false, initialSequence: "Idle_A");
                context.CreateMonster(spawnIds: new []{5001}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 5001, patrolName: "MS2PatrolData_501");
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{5001});
                context.SetTimer(timerId: "2", seconds: 50);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
