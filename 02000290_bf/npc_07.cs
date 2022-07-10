namespace Maple2.Trigger._02000290_bf {
    public static class _npc_07 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6001, 6002}, visible: false);
                context.SetInteractObject(interactIds: new []{10000464}, state: 1);
                context.SetActor(triggerId: 9007, visible: true, initialSequence: "Down_Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000464}, arg2: 0)) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 9007, visible: false, initialSequence: "Down_Idle_A");
                context.SetUserValue(triggerId: 9999995, key: "dungeonclear", value: 1);
            }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{907});
                context.SetTimer(timerId: "2", seconds: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    context.SetEffect(triggerIds: new []{6001}, visible: true);
                    context.SetConversation(type: 1, spawnId: 907, script: "$02000290_BF__NPC_07__0$", arg4: 3);
                    return new StateNPC이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPC이동 : TriggerState {
            internal StateNPC이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "4", seconds: 4);
                context.MoveNpc(spawnId: 907, patrolName: "MS2PatrolData907");
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    context.SetEffect(triggerIds: new []{6002}, visible: true);
                    context.SetConversation(type: 1, spawnId: 907, script: "$02000290_BF__NPC_07__1$", arg4: 3);
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
