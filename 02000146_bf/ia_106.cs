namespace Maple2.Trigger._02000146_bf {
    public static class _ia_106 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000181}, state: 1);
                context.SetActor(triggerId: 206, visible: true, initialSequence: "Attack_Idle_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000181}, arg2: 0)) {
                    return new StateNPCSpawn(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 206, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{406});
            }
        }

        private class StateNPCSpawn : TriggerState {
            internal StateNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 406, script: "$02000146_BF__IA_106__0$", arg4: 3);
                context.SetTimer(timerId: "1", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{406})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 8);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
