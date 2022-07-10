namespace Maple2.Trigger._02000014_ad {
    public static class _ia_113 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000113}, state: 1);
                context.SetActor(triggerId: 113, visible: true, initialSequence: "Dead_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000113}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 113, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{91}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 91, patrolName: "MS2PatrolData401");
                context.SetConversation(type: 1, spawnId: 91, script: "$02000014_AD__IA_113__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 291, spawnIds: new []{91})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{91});
                context.SetTimer(timerId: "301", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "301")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
