namespace Maple2.Trigger._02000014_ad {
    public static class _ia_117 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000117}, state: 1);
                context.SetActor(triggerId: 117, visible: true, initialSequence: "Dead_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000117}, arg2: 0)) {
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 117, visible: false, initialSequence: "Dead_A");
                context.CreateMonster(spawnIds: new []{95}, arg2: false);
            }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 95, patrolName: "MS2PatrolData405");
                context.SetConversation(type: 1, spawnId: 95, script: "$02000014_AD__IA_117__0$", arg4: 4, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 295, spawnIds: new []{95})) {
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{95});
                context.SetTimer(timerId: "305", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "305")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
