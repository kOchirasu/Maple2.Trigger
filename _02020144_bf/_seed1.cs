namespace Maple2.Trigger._02020144_bf {
    public static class _seed1 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

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
                    return new State대기시간(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State대기시간 : TriggerState {
            internal State대기시간(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State활성화(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State활성화 : TriggerState {
            internal State활성화(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127}, arg2: 0);
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002125, 10002126, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗심기1(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002126, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗심기2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002127}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗심기3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126}, arg2: 0);
                    context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗심기4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗심기1 : TriggerState {
            internal State씨앗심기1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무생성1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: true)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗심기2 : TriggerState {
            internal State씨앗심기2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무생성1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: true)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗심기3 : TriggerState {
            internal State씨앗심기3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무생성1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: true)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗심기4 : TriggerState {
            internal State씨앗심기4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State나무생성1(context);
                }

                if (!context.CheckAnyUserAdditionalEffect(triggerBoxId: 1004, additionalEffectId: 70002109, level: true)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State나무생성1 : TriggerState {
            internal State나무생성1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                    context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                    context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 0);
                    context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                    context.SetUserValue(triggerId: 900009, key: "Seed", value: 0);
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

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
                return new State시작(context);
            }

            public override void OnExit() { }
        }
    }
}