namespace Maple2.Trigger._99999985_plantest_08 {
    public static class _ia_110 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000009}, state: 1);
                context.SetActor(triggerId: 1101, visible: true, initialSequence: "SOS_B");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() {
                context.CreateMonster(spawnIds: new []{306});
            }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000009}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 1101, visible: false, initialSequence: "SOS_B");
                context.DestroyMonster(spawnIds: new []{306});
                context.CreateMonster(spawnIds: new []{110});
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 110, patrolName: "MS2PatrolData110");
                context.SetConversation(type: 1, spawnId: 110, script: "$02000116_BF__IA_110__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 110, script: "$02000116_BF__IA_110__1$", arg4: 2, arg5: 2);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 110, spawnIds: new []{110})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{110});
                context.SetTimer(timerId: "110", seconds: 1);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "110")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
