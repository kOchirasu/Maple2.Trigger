namespace Maple2.Trigger._02000149_in {
    public static class _ia_105 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000194}, state: 1);
                context.SetActor(triggerId: 205, visible: true, initialSequence: "Sit_Chair_Idle_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000194}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 205, visible: false, initialSequence: "Sit_Chair_Idle_A");
                context.CreateMonster(spawnIds: new []{405});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 405, patrolName: "MS2PatrolData_505");
                context.SetConversation(type: 1, spawnId: 405, script: "$02000149_IN__IA_105__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 405, script: "$02000149_IN__IA_105__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 605, spawnIds: new []{405})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{405});
                context.SetTimer(timerId: "1", seconds: 5);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
