namespace Maple2.Trigger._02000116_bf {
    public static class _ia_105 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000004}, state: 1);
                context.SetActor(triggerId: 1051, visible: true, initialSequence: "SOS_B");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{301});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000004}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 1051, visible: false, initialSequence: "SOS_B");
                context.DestroyMonster(spawnIds: new []{301});
                context.CreateMonster(spawnIds: new []{105});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData105");
                context.SetConversation(type: 1, spawnId: 105, script: "$02000116_BF__IA_105__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 105, script: "$02000116_BF__IA_105__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 105, spawnIds: new []{105})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{105});
                context.SetTimer(timerId: "105", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "105")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
