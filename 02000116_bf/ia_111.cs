namespace Maple2.Trigger._02000116_bf {
    public static class _ia_111 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000010}, state: 1);
                context.SetActor(triggerId: 1111, visible: true, initialSequence: "SOS_B");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{307});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000010}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 1111, visible: false, initialSequence: "SOS_B");
                context.DestroyMonster(spawnIds: new []{307});
                context.CreateMonster(spawnIds: new []{111});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData111");
                context.SetConversation(type: 1, spawnId: 111, script: "$02000116_BF__IA_111__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 111, script: "$02000116_BF__IA_111__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 111, spawnIds: new []{111})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{111});
                context.SetTimer(timerId: "111", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "111")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
