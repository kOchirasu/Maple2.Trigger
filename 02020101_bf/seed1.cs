namespace Maple2.Trigger._02020101_bf {
    public static class _seed1 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
                context.SetSkill(triggerIds: new []{901, 902}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Seed") == 1) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnabled : TriggerState {
            internal StateEnabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127}, state: 0);
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002124}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{10002125, 10002126, 10002127}, state: 0);
                    context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting1(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002125}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{10002124, 10002126, 10002127}, state: 0);
                    context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002126}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002127}, state: 0);
                    context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002127}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126}, state: 0);
                    context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting1 : TriggerState {
            internal StateSeedPlanting1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(boxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting2 : TriggerState {
            internal StateSeedPlanting2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(boxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting3 : TriggerState {
            internal StateSeedPlanting3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(boxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting4 : TriggerState {
            internal StateSeedPlanting4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(boxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나무Creation1 : TriggerState {
            internal State나무Creation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{901, 902}, enabled: true);
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 2);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                    context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                    context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 0);
                    context.SetSkill(triggerIds: new []{901, 902}, enabled: false);
                    context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetSkill(triggerIds: new []{901, 902}, enabled: false);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
            }

            public override TriggerState? Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }
    }
}
