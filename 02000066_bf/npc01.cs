namespace Maple2.Trigger._02000066_bf {
    public static class _npc01 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{605}, visible: false);
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Dead_A");
                context.SetInteractObject(interactIds: new []{10000341}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103})) {
                    return new StateNPCCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation : TriggerState {
            internal StateNPCCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
                context.SetInteractObject(interactIds: new []{10000341}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPCCreation조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCCreation조건 : TriggerState {
            internal StateNPCCreation조건(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    context.SetEffect(triggerIds: new []{605}, visible: true);
                    context.ShowGuideSummary(entityId: 20000663, textId: 20000663);
                    context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                    return new StateNPCDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCDestroy : TriggerState {
            internal StateNPCDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "3", seconds: 3);
                context.DestroyMonster(spawnIds: new []{2001});
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "3")) {
                    context.HideGuideSummary(entityId: 20000663);
                    return new StateInteractObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: true, initialSequence: "Dead_A");
                context.SetInteractObject(interactIds: new []{10000341}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000341}, arg2: 0)) {
                    return new State부활(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State부활 : TriggerState {
            internal State부활(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.CreateMonster(spawnIds: new []{2001}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateNPCScript(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNPCScript : TriggerState {
            internal StateNPCScript(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 201, visible: false, initialSequence: "Dead_A");
                context.SetConversation(type: 1, spawnId: 2001, script: "$02000066_BF__NPC01__1$", arg4: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{2001})) {
                    return new StateNPCCreation조건(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
