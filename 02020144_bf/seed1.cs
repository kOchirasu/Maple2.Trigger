namespace Maple2.Trigger._02020144_bf {
    public static class _seed1 {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed") == 1) {
                    return new StateWaitTime(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitTime : TriggerState {
            internal StateWaitTime(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127}, arg2: 0);
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002125, 10002126, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting1(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002126, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPlanting4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting1 : TriggerState {
            internal StateSeedPlanting1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting2 : TriggerState {
            internal StateSeedPlanting2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting3 : TriggerState {
            internal StateSeedPlanting3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPlanting4 : TriggerState {
            internal StateSeedPlanting4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무Creation1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: 1)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나무Creation1 : TriggerState {
            internal State나무Creation1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                    context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                    context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 0);
                    context.SetSkill(arg1: new[] {901, 902}, arg2: false);
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
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override TriggerState Execute() {
                return new StateStart(context);
            }

            public override void OnExit() { }
        }
    }
}