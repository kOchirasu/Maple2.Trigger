namespace Maple2.Trigger._02020101_bf {
    public static class _seed {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

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

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1001})) {
                    context.State = new State보스전유저감지(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스전유저감지 : TriggerState {
            internal State보스전유저감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {1002})) {
                    context.State = new State보스체력체크1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스체력체크1 : TriggerState {
            internal State보스체력체크1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.70f) {
                    context.State = new State씨앗패턴1_확률체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_확률체크 : TriggerState {
            internal State씨앗패턴1_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴1_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴1_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴1_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴1_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_1 : TriggerState {
            internal State씨앗패턴1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴1_1_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_2 : TriggerState {
            internal State씨앗패턴1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴1_2_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_3 : TriggerState {
            internal State씨앗패턴1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴1_3_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_4 : TriggerState {
            internal State씨앗패턴1_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴1_4_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_1_심기 : TriggerState {
            internal State씨앗패턴1_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴1_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_2_심기 : TriggerState {
            internal State씨앗패턴1_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴1_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_3_심기 : TriggerState {
            internal State씨앗패턴1_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴1_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_4_심기 : TriggerState {
            internal State씨앗패턴1_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴1_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴1_종료 : TriggerState {
            internal State씨앗패턴1_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    context.State = new State보스체력체크2(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State보스체력체크2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스체력체크2 : TriggerState {
            internal State보스체력체크2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.40f) {
                    context.State = new State씨앗패턴2_확률체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_확률체크 : TriggerState {
            internal State씨앗패턴2_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 2);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴2_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴2_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴2_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴2_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_1 : TriggerState {
            internal State씨앗패턴2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴2_1_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_2 : TriggerState {
            internal State씨앗패턴2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴2_2_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_3 : TriggerState {
            internal State씨앗패턴2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴2_3_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_4 : TriggerState {
            internal State씨앗패턴2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴2_4_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_1_심기 : TriggerState {
            internal State씨앗패턴2_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴2_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_2_심기 : TriggerState {
            internal State씨앗패턴2_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴2_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_3_심기 : TriggerState {
            internal State씨앗패턴2_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴2_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_4_심기 : TriggerState {
            internal State씨앗패턴2_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴2_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴2_종료 : TriggerState {
            internal State씨앗패턴2_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    context.State = new State보스체력체크3(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State보스체력체크3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State보스체력체크3 : TriggerState {
            internal State보스체력체크3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetNpcHpRate(spawnPointId: 101) <= 0.15f) {
                    context.State = new State씨앗패턴3_확률체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_확률체크 : TriggerState {
            internal State씨앗패턴3_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 3);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴3_1(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴3_2(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴3_3(context);
                    return;
                }

                if (context.RandomCondition(arg1: 25f)) {
                    context.State = new State씨앗패턴3_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_1 : TriggerState {
            internal State씨앗패턴3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9001}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002124}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002124}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9001}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴3_1_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_2 : TriggerState {
            internal State씨앗패턴3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9002}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002125}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002125}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9002}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴3_2_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_3 : TriggerState {
            internal State씨앗패턴3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002126}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002126}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴3_3_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_4 : TriggerState {
            internal State씨앗패턴3_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {9004}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(arg1: new[] {10002127}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002127}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new State씨앗패턴3_4_심기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_1_심기 : TriggerState {
            internal State씨앗패턴3_1_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴3_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_2_심기 : TriggerState {
            internal State씨앗패턴3_2_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴3_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_3_심기 : TriggerState {
            internal State씨앗패턴3_3_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴3_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_4_심기 : TriggerState {
            internal State씨앗패턴3_4_심기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 1);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new[] {10002128}, arg2: 0) || context.ObjectInteracted(arg1: new[] {10002129}, arg2: 0)) {
                    context.State = new State씨앗패턴3_종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State씨앗패턴3_종료 : TriggerState {
            internal State씨앗패턴3_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {901, 902}, arg2: true);
                context.SetInteractObject(arg1: new[] {10002128, 10002129}, arg2: 2);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {1003}, arg2: 70002110, arg3: 1, arg5: false);
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 9);
                context.SetSkill(arg1: new[] {901, 902}, arg2: false);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {9001, 9002, 9003, 9004}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}