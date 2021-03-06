namespace Maple2.Trigger._02020100_bf {
    public static class _main {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: false);
                context.SetUserValue(triggerId: 99990002, key: "Seed1start", value: 0);
                context.SetUserValue(triggerId: 99990003, key: "Seed2start", value: 0);
                context.SetUserValue(triggerId: 99990004, key: "Seed3start", value: 0);
                context.SetPortal(portalId: 1, visible: false, enabled: false, minimapVisible: false);
                context.SetLadder(arg1: 2001, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2002, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2003, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2004, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2005, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2006, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 2007, arg2: false, arg3: false, arg4: 0);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014}, arg2: false, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114}, arg2: true, arg3: 0, arg4: 0);
                context.SetMesh(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230}, arg2: true, arg3: 0, arg4: 0);
                context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1403, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetActor(arg1: 1404, arg2: true, arg3: "Interaction_lapentatree_A01_Off");
                context.SetMesh(arg1: new[] {1301, 1302, 1303, 1304}, arg2: false, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {10002109, 10002110, 10002111, 10002112, 10002113, 10002115, 10002116, 10002122}, arg2: 0);
                context.SetBreakable(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019}, arg2: false);
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005, 9006, 9007, 9008, 9009, 9010, 9011, 9012, 9013, 9014, 9015, 9016, 9017, 9018, 9019, 9020, 9021, 9022, 9023, 9024, 9025, 9026, 9027, 9028, 9029, 9030, 9031, 9032, 9033, 9034}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {901})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9001, 9002, 9003, 9004, 9005}, arg2: false);
                context.SetMesh(arg1: new[] {1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114}, arg2: false, arg3: 0, arg4: 0);
                context.CreateMonster(arg1: new[] {201}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {201})) {
                    return new StateSeedExperience(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedExperience : TriggerState {
            internal StateSeedExperience(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9006, 9007, 9008, 9009}, arg2: false);
                context.SetMesh(arg1: new[] {1007, 1008, 1009, 1010}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.CreateMonster(arg1: new[] {202, 203, 204, 205}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {202, 203, 204, 205})) {
                    return new StateSeedExperience_씨앗들기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedExperience_씨앗들기 : TriggerState {
            internal StateSeedExperience_씨앗들기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$02020100_BF__MAIN__0$", arg3: 5000);
                context.SetUserValue(triggerId: 99990005, key: "Seed0start", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed0interact") == 1) {
                    return new StateSeedExperience_나무Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedExperience_나무Planting : TriggerState {
            internal StateSeedExperience_나무Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002116}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002116}, arg2: 0)) {
                    context.SetActor(arg1: 1401, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                    context.SetUserValue(triggerId: 99990005, key: "Seed0start", value: 2);
                    return new StateSeedExperience_끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeedExperience_끝 : TriggerState {
            internal StateSeedExperience_끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9010, 9011, 9012, 9013}, arg2: false);
                context.SetMesh(arg1: new[] {1011, 1012, 1013, 1014}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.CreateMonster(arg1: new[] {207, 208, 209}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {207, 208, 209})) {
                    return new StateLadderEnable(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLadderEnable : TriggerState {
            internal StateLadderEnable(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 2001, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 2002, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 2003, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 2004, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 2005, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 2006, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 2007, arg2: true, arg3: true, arg4: 14);
                context.CreateMonster(arg1: new[] {210, 211, 212}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {210, 211, 212})) {
                    return new StateSeed1Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed1Enabled : TriggerState {
            internal StateSeed1Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 0, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: true);
                context.SetUserValue(triggerId: 99990002, key: "Seed1start", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed1interact") == 1) {
                    return new StateSeed1_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed1_전투 : TriggerState {
            internal StateSeed1_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9014, 9015, 9016, 9017, 9018}, arg2: false);
                context.CreateMonster(arg1: new[] {213, 214, 215, 216}, arg2: false);
                context.SetMesh(arg1: new[] {1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210}, arg2: false, arg3: 0, arg4: 0);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {213, 214, 215, 216})) {
                    return new StateSeed1_Planting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed1_Planting : TriggerState {
            internal StateSeed1_Planting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9019, 9020, 9021, 9022}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002, 1003, 1004}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.SetInteractObject(arg1: new[] {10002112}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002112}, arg2: 0)) {
                    return new StateSeed2Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed2Enabled : TriggerState {
            internal StateSeed2Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9023, 9024}, arg2: false);
                context.EnableSpawnPointPc(spawnPointId: 1, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: true);
                context.SetUserValue(triggerId: 99990002, key: "Seed1start", value: 2);
                context.SetUserValue(triggerId: 99990003, key: "Seed2start", value: 1);
                context.SetMesh(arg1: new[] {1005, 1006}, arg2: true, arg3: 0, arg4: 250, arg5: 3f);
                context.SetActor(arg1: 1402, arg2: true, arg3: "Interaction_lapentatree_A01_On");
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed2interact") == 1) {
                    return new StateSeed2_전투(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSeed2_전투 : TriggerState {
            internal StateSeed2_전투(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9025, 9026, 9027, 9028, 9029}, arg2: false);
                context.SetEventUI(arg1: 1, script: "$02020100_BF__MAIN__1$", arg3: 5000);
                context.CreateMonster(arg1: new[] {111, 112, 113, 114, 115, 116}, arg2: false);
                context.SetMesh(arg1: new[] {1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220}, arg2: false, arg3: 0, arg4: 0);
                context.SetInteractObject(arg1: new[] {10002113}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10002113}, arg2: 0)) {
                    return new StateSetup1_지역감지(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup1_지역감지 : TriggerState {
            internal StateSetup1_지역감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAgent(arg1: new[] {9030, 9031, 9032, 9033, 9034}, arg2: false);
                context.SetActor(arg1: 1403, arg2: true, arg3: "Interaction_lapentatree_A01_On");
                context.SetMesh(arg1: new[] {1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230}, arg2: false, arg3: 0, arg4: 0);
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115, 116});
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {903})) {
                    return new StateSetup1WaitEnabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup1WaitEnabled : TriggerState {
            internal StateSetup1WaitEnabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {225, 226}, arg2: false);
                context.SetUserValue(triggerId: 99990003, key: "Seed2start", value: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed3interact") == 1) {
                    return new StateSetup1_Monster처리(context);
                }

                if (context.MonsterDead(arg1: new[] {225, 226})) {
                    return new StateSetup1_Monster처리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup1_Monster처리 : TriggerState {
            internal StateSetup1_Monster처리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990004, key: "Seed3start", value: 1);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Seed3interact") == 1) {
                    return new StateSetup1Enabled(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup1Enabled : TriggerState {
            internal StateSetup1Enabled(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10002122}, arg2: 1);
                context.EnableSpawnPointPc(spawnPointId: 2, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 3, isEnable: true);
                context.CreateMonster(arg1: new[] {121, 122, 123, 124}, arg2: false);
                context.SetBreakable(arg1: new[] {5001, 5002, 5003, 5004, 5005, 5006, 5007, 5008, 5009, 5011, 5012, 5013, 5014, 5015, 5016, 5017, 5018, 5019}, arg2: true);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "EliteClear") == 1) {
                    return new StateBoss(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 99990005, key: "Seed4start", value: 2);
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115, 116, 117, 118, 119});
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}