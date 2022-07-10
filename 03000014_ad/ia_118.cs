namespace Maple2.Trigger._03000014_ad {
    public static class _ia_118 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000118}, state: 1);
                context.SetActor(triggerId: 118, visible: true, initialSequence: "Dead_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000118}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 118, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{96}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 96, patrolName: "MS2PatrolData406");
                context.SetConversation(type: 1, spawnId: 96, script: "$03000014_AD__IA_118__0$", arg4: 4);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 296, spawnIds: new []{96})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{96});
                context.SetTimer(timerId: "306", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "306")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
