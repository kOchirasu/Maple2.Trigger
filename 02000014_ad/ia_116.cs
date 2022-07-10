namespace Maple2.Trigger._02000014_ad {
    public static class _ia_116 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000116}, state: 1);
                context.SetActor(triggerId: 116, visible: true, initialSequence: "Dead_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000116}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 116, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{94}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 94, patrolName: "MS2PatrolData404");
                context.SetConversation(type: 1, spawnId: 94, script: "$02000014_AD__IA_116__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 294, spawnIds: new []{94})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{94});
                context.SetTimer(timerId: "304", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "304")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
