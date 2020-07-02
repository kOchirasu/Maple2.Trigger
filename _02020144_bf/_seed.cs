namespace Maple2.Trigger._02020144_bf {
    public static class _seed {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetUserValue(triggerId: 900005, key: "TimerReset", value: 0);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    return new StateBossUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossUserDetection : TriggerState {
            internal StateBossUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    return new StateBoss체력체크1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss체력체크1 : TriggerState {
            internal StateBoss체력체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.70f) {
                    return new State씨앗Pattern1_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_확률체크 : TriggerState {
            internal State씨앗Pattern1_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern1_1(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern1_2(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern1_3(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern1_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_1 : TriggerState {
            internal State씨앗Pattern1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern1_1_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_2 : TriggerState {
            internal State씨앗Pattern1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern1_2_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_3 : TriggerState {
            internal State씨앗Pattern1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern1_3_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_4 : TriggerState {
            internal State씨앗Pattern1_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern1_4_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_1_심기 : TriggerState {
            internal State씨앗Pattern1_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_2_심기 : TriggerState {
            internal State씨앗Pattern1_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_3_심기 : TriggerState {
            internal State씨앗Pattern1_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_4_심기 : TriggerState {
            internal State씨앗Pattern1_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern1_종료 : TriggerState {
            internal State씨앗Pattern1_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBoss체력체크2(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBoss체력체크2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss체력체크2 : TriggerState {
            internal StateBoss체력체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.40f) {
                    return new State씨앗Pattern2_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_확률체크 : TriggerState {
            internal State씨앗Pattern2_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 2);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern2_1(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern2_2(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern2_3(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern2_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_1 : TriggerState {
            internal State씨앗Pattern2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern2_1_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_2 : TriggerState {
            internal State씨앗Pattern2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern2_2_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_3 : TriggerState {
            internal State씨앗Pattern2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern2_3_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_4 : TriggerState {
            internal State씨앗Pattern2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern2_4_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_1_심기 : TriggerState {
            internal State씨앗Pattern2_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_2_심기 : TriggerState {
            internal State씨앗Pattern2_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_3_심기 : TriggerState {
            internal State씨앗Pattern2_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_4_심기 : TriggerState {
            internal State씨앗Pattern2_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern2_종료 : TriggerState {
            internal State씨앗Pattern2_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBoss체력체크3(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBoss체력체크3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss체력체크3 : TriggerState {
            internal StateBoss체력체크3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.15f) {
                    return new State씨앗Pattern3_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_확률체크 : TriggerState {
            internal State씨앗Pattern3_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 3);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern3_1(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern3_2(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern3_3(context);
                }

                if (context.RandomCondition(arg1: 25f)) {
                    return new State씨앗Pattern3_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_1 : TriggerState {
            internal State씨앗Pattern3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern3_1_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_2 : TriggerState {
            internal State씨앗Pattern3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern3_2_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_3 : TriggerState {
            internal State씨앗Pattern3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern3_3_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_4 : TriggerState {
            internal State씨앗Pattern3_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new State씨앗Pattern3_4_심기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_1_심기 : TriggerState {
            internal State씨앗Pattern3_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_2_심기 : TriggerState {
            internal State씨앗Pattern3_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_3_심기 : TriggerState {
            internal State씨앗Pattern3_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_4_심기 : TriggerState {
            internal State씨앗Pattern3_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    return new State씨앗Pattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State씨앗Pattern3_종료 : TriggerState {
            internal State씨앗Pattern3_종료(ITriggerContext context) : base(context) { }

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

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 9);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}