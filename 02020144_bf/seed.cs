namespace Maple2.Trigger._02020144_bf {
    public static class _seed {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetUserValue(triggerId: 900005, key: "TimerReset", value: 0);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1001})) {
                    return new StateBossUserDetection(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossUserDetection : TriggerState {
            internal StateBossUserDetection(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1002})) {
                    return new StateBossHealthCheck1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossHealthCheck1 : TriggerState {
            internal StateBossHealthCheck1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 101) <= 0.70f) {
                    return new StateSeedPattern1_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_확률체크 : TriggerState {
            internal StateSeedPattern1_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern1_1(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern1_2(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern1_3(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern1_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_1 : TriggerState {
            internal StateSeedPattern1_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9001}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002124}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002124}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern1_1_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_2 : TriggerState {
            internal StateSeedPattern1_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9002}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002125}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002125}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern1_2_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_3 : TriggerState {
            internal StateSeedPattern1_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9003}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002126}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002126}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern1_3_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_4 : TriggerState {
            internal StateSeedPattern1_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9004}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002127}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002127}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern1_4_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_1_Planting : TriggerState {
            internal StateSeedPattern1_1_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_2_Planting : TriggerState {
            internal StateSeedPattern1_2_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_3_Planting : TriggerState {
            internal StateSeedPattern1_3_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_4_Planting : TriggerState {
            internal StateSeedPattern1_4_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern1_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern1_종료 : TriggerState {
            internal StateSeedPattern1_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: true);
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 2);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 1) {
                    return new StateBossHealthCheck2(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBossHealthCheck2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossHealthCheck2 : TriggerState {
            internal StateBossHealthCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: false);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 101) <= 0.40f) {
                    return new StateSeedPattern2_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_확률체크 : TriggerState {
            internal StateSeedPattern2_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern2_1(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern2_2(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern2_3(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern2_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_1 : TriggerState {
            internal StateSeedPattern2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9001}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002124}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002124}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern2_1_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_2 : TriggerState {
            internal StateSeedPattern2_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9002}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002125}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002125}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern2_2_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_3 : TriggerState {
            internal StateSeedPattern2_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9003}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002126}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002126}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern2_3_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_4 : TriggerState {
            internal StateSeedPattern2_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9004}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002127}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002127}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern2_4_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_1_Planting : TriggerState {
            internal StateSeedPattern2_1_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_2_Planting : TriggerState {
            internal StateSeedPattern2_2_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_3_Planting : TriggerState {
            internal StateSeedPattern2_3_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_4_Planting : TriggerState {
            internal StateSeedPattern2_4_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern2_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern2_종료 : TriggerState {
            internal StateSeedPattern2_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 0);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: true);
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 2);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 2) {
                    return new StateBossHealthCheck3(context);
                }

                if (context.WaitTick(waitTick: 10000)) {
                    return new StateBossHealthCheck3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBossHealthCheck3 : TriggerState {
            internal StateBossHealthCheck3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: false);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetNpcHpRate(spawnId: 101) <= 0.15f) {
                    return new StateSeedPattern3_확률체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_확률체크 : TriggerState {
            internal StateSeedPattern3_확률체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 3);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern3_1(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern3_2(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern3_3(context);
                }

                if (context.RandomCondition(rate: 25f)) {
                    return new StateSeedPattern3_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_1 : TriggerState {
            internal StateSeedPattern3_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9001}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002124}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002124}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9001}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern3_1_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_2 : TriggerState {
            internal StateSeedPattern3_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9002}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002125}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002125}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9002}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern3_2_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_3 : TriggerState {
            internal StateSeedPattern3_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9003}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002126}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002126}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9003}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern3_3_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_4 : TriggerState {
            internal StateSeedPattern3_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{9004}, visible: true, arg3: 0, arg4: 0, arg5: 2f);
                context.SetInteractObject(interactIds: new []{10002127}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002127}, arg2: 0)) {
                    context.SetMesh(triggerIds: new []{9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateSeedPattern3_4_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_1_Planting : TriggerState {
            internal StateSeedPattern3_1_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_2_Planting : TriggerState {
            internal StateSeedPattern3_2_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_3_Planting : TriggerState {
            internal StateSeedPattern3_3_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_4_Planting : TriggerState {
            internal StateSeedPattern3_4_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
                    return new StateEnd(context);
                }

                if (context.GetUserValue(key: "TimerReset") == 3) {
                    return new StateEnd(context);
                }

                if (context.ObjectInteracted(interactIds: new []{10002128}, arg2: 0) || context.ObjectInteracted(interactIds: new []{10002129}, arg2: 0)) {
                    return new StateSeedPattern3_종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedPattern3_종료 : TriggerState {
            internal StateSeedPattern3_종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{901, 902}, arg2: true);
                context.SetInteractObject(interactIds: new []{10002128, 10002129}, state: 2);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101})) {
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
                context.AddBuff(boxIds: new []{1003}, skillId: 70002110, level: 1, arg5: false);
                context.SetUserValue(triggerId: 900005, key: "TimerStart", value: 9);
                context.SetSkill(triggerIds: new []{901, 902}, arg2: false);
                context.SetActor(triggerId: 1401, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetActor(triggerId: 1402, visible: true, initialSequence: "Interaction_lapentatree_A01_Off");
                context.SetMesh(triggerIds: new []{9001, 9002, 9003, 9004}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{10002124, 10002125, 10002126, 10002127, 10002128, 10002129}, state: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
