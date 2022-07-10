namespace Maple2.Trigger._02000116_bf {
    public static class _ia_106 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000005}, state: 1);
                context.SetActor(triggerId: 1061, visible: true, initialSequence: "SOS_B");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{302});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000005}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 1061, visible: false, initialSequence: "SOS_B");
                context.DestroyMonster(spawnIds: new []{302});
                context.CreateMonster(spawnIds: new []{106});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData106");
                context.SetConversation(type: 1, spawnId: 106, script: "$02000116_BF__IA_106__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 106, script: "$02000116_BF__IA_106__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 106, spawnIds: new []{106})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{106});
                context.SetTimer(timerId: "106", seconds: 3);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "106")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
