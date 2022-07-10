namespace Maple2.Trigger._02000146_bf {
    public static class _ia_112 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000187}, state: 1);
                context.SetActor(triggerId: 212, visible: true, initialSequence: "Attack_Idle_A");
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
                if (context.ObjectInteracted(interactIds: new []{10000187}, arg2: 0)) {
                    return new StateNPCSpawn(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 212, visible: false, initialSequence: "Attack_Idle_A");
                context.CreateMonster(spawnIds: new []{412});
            }
        }

        private class StateNPCSpawn : TriggerState {
            internal StateNPCSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 412, script: "$02000146_BF__IA_112__0$", arg4: 2);
                context.SetTimer(timerId: "1", seconds: 15);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{412})) {
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
