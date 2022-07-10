namespace Maple2.Trigger._03000014_ad {
    public static class _ia_114 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000114}, state: 1);
                context.SetActor(triggerId: 114, visible: true, initialSequence: "Dead_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000114}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 114, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{92}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 92, patrolName: "MS2PatrolData402");
                context.SetConversation(type: 1, spawnId: 92, script: "$03000014_AD__IA_114__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 292, spawnIds: new []{92})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{92});
                context.SetTimer(timerId: "302", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "302")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
