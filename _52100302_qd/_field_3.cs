using System;

namespace Maple2.Trigger._52100302_qd {
    public static class _field_3 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000513}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000514}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000515}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000516}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000517}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000518}, arg2: 2);
            }

            public override void Execute() {
                if (context.UserValue(key: "Block", value: 1)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateArriveBlock_1(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 2)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateArriveBlock_2(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 3)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateArriveBlock_3(context);
                    return;
                }

                if (context.UserValue(key: "Block", value: 4)) {
                    context.SetUserValue(triggerID: 900004, key: "Block", value: 0);
                    context.State = new StateArriveBlock_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_1 : TriggerState {
            internal StateArriveBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9004")) {
                    context.State = new StateArriveBlock_Delay_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_1 : TriggerState {
            internal StateArriveBlock_Delay_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new int[] {2004}, arg2: false);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1110, 1303, 1304, 1309, 1310, 1311, 1312, 1313, 1314})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000513}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 109, isEnable: true);
                    context.State = new StateCableOn_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1110, 1303, 1304, 1309, 1310, 1311, 1312, 1313, 1314})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000513}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 109, isEnable: true);
                    context.State = new StateCableOn_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_2 : TriggerState {
            internal StateArriveBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9005")) {
                    context.State = new StateArriveBlock_Delay_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_2 : TriggerState {
            internal StateArriveBlock_Delay_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new int[] {2005}, arg2: false);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1111, 1301, 1302, 1321, 1322, 1323, 1324, 1325, 1326})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000514}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000515}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 110, isEnable: true);
                    context.State = new StateCableOn_14_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1111, 1301, 1302, 1321, 1322, 1323, 1324, 1325, 1326})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000514}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000515}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 110, isEnable: true);
                    context.State = new StateCableOn_14_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_3 : TriggerState {
            internal StateArriveBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9006")) {
                    context.State = new StateArriveBlock_Delay_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_3 : TriggerState {
            internal StateArriveBlock_Delay_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new int[] {2006}, arg2: false);
                    context.State = new StateBlock_3(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1112, 1307, 1308, 1327, 1328, 1329, 1330, 1331, 1332})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000516}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000517}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 111, isEnable: true);
                    context.State = new StateCableOn_16_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1112, 1307, 1308, 1327, 1328, 1329, 1330, 1331, 1332})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000516}, arg2: 1);
                    context.SetInteractObject(arg1: new int[] {12000517}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 111, isEnable: true);
                    context.State = new StateCableOn_16_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_4 : TriggerState {
            internal StateArriveBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9007")) {
                    context.State = new StateArriveBlock_Delay_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_4 : TriggerState {
            internal StateArriveBlock_Delay_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new int[] {2007}, arg2: false);
                    context.State = new StateBlock_4(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {1113, 1305, 1306, 1315, 1316, 1317, 1318, 1319, 1320})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new int[] {12000518}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 112, isEnable: true);
                    context.State = new StateCableOn_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_4 : TriggerState {
            internal StateBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {1113, 1305, 1306, 1315, 1316, 1317, 1318, 1319, 1320})) {
                    context.DestroyMonster(arg1: new int[] {2007}, arg2: false);
                    context.SetInteractObject(arg1: new int[] {12000518}, arg2: 1);
                    context.CreateMonster(arg1: new int[] {1114}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1115}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1116}, arg2: false);
                    context.CreateMonster(arg1: new int[] {1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420},
                        arg2: false);
                    context.CreateMonster(arg1: new int[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430},
                        arg2: false);
                    context.EnableSpawnPointPc(spawnPointID: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 112, isEnable: true);
                    context.State = new StateCableOn_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_13 : TriggerState {
            internal StateCableOn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000513}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000513}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1110001, 1110002, 1110003, 1110004, 1110005, 1110006, 1110007, 1110008, 1110009, 1110010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_14_15 : TriggerState {
            internal StateCableOn_14_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000514}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000514}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000515}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1120001, 1120002, 1120003, 1120004, 1120005, 1120006, 1120007, 1120008, 1120009, 1120010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_14(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000515}, arg2: 0)) {
                    context.SetVisibleBreakableObject(arg1: new int[] {1016}, arg2: false);
                    context.SetInteractObject(arg1: new int[] {12000514}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000515}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1130001, 1130002, 1130003, 1130004, 1130005, 1130006, 1130007, 1130008, 1130009, 1130010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_16_17 : TriggerState {
            internal StateCableOn_16_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000516}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000516}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000517}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1140001, 1140002, 1140003, 1140004, 1140005, 1140006, 1140007, 1140008, 1140009, 1140010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_16(context);
                    return;
                }

                if (context.ObjectInteracted(arg1: new int[] {12000517}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000516}, arg2: 0);
                    context.SetInteractObject(arg1: new int[] {12000517}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1150001, 1150002, 1150003, 1150004, 1150005, 1150006, 1150007, 1150008, 1150009, 1150010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_18 : TriggerState {
            internal StateCableOn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000518}, arg2: 0)) {
                    context.SetInteractObject(arg1: new int[] {12000518}, arg2: 0);
                    context.SetMesh(
                        arg1: new int[]
                            {1160001, 1160002, 1160003, 1160004, 1160005, 1160006, 1160007, 1160008, 1160009, 1160010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13 : TriggerState {
            internal StateCableDelay_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__0$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_13_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14 : TriggerState {
            internal StateCableDelay_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__1$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_14_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15 : TriggerState {
            internal StateCableDelay_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__2$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_15_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16 : TriggerState {
            internal StateCableDelay_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__3$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_16_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17 : TriggerState {
            internal StateCableDelay_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__4$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_17_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18 : TriggerState {
            internal StateCableDelay_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__5$", arg3: new int[] {3000});
                    context.State = new StateCableDelay_18_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_2 : TriggerState {
            internal StateCableDelay_13_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__6$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_13_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_2 : TriggerState {
            internal StateCableDelay_14_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__7$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_14_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_2 : TriggerState {
            internal StateCableDelay_15_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__8$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_15_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_2 : TriggerState {
            internal StateCableDelay_16_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__9$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_16_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_2 : TriggerState {
            internal StateCableDelay_17_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__10$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_17_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_2 : TriggerState {
            internal StateCableDelay_18_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__11$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_18_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_3 : TriggerState {
            internal StateCableDelay_13_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__12$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_13_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_3 : TriggerState {
            internal StateCableDelay_14_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__13$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_14_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_3 : TriggerState {
            internal StateCableDelay_15_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__14$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_15_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_3 : TriggerState {
            internal StateCableDelay_16_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__15$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_16_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_3 : TriggerState {
            internal StateCableDelay_17_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__16$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_17_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_3 : TriggerState {
            internal StateCableDelay_18_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__17$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_18_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_4 : TriggerState {
            internal StateCableDelay_13_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__18$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_13_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_4 : TriggerState {
            internal StateCableDelay_14_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__19$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_14_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_4 : TriggerState {
            internal StateCableDelay_15_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__20$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_15_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_4 : TriggerState {
            internal StateCableDelay_16_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__21$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_16_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_4 : TriggerState {
            internal StateCableDelay_17_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__22$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_17_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_4 : TriggerState {
            internal StateCableDelay_18_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_3__23$", arg3: new int[] {1000});
                    context.State = new StateCableDelay_18_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_5 : TriggerState {
            internal StateCableDelay_13_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1013}, arg2: true);
                    context.State = new StateCableOff_13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_5 : TriggerState {
            internal StateCableDelay_14_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1014}, arg2: true);
                    context.State = new StateCableOff_14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_5 : TriggerState {
            internal StateCableDelay_15_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1015}, arg2: true);
                    context.State = new StateCableOff_15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_5 : TriggerState {
            internal StateCableDelay_16_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1016}, arg2: true);
                    context.State = new StateCableOff_16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_5 : TriggerState {
            internal StateCableDelay_17_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1017}, arg2: true);
                    context.State = new StateCableOff_17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_5 : TriggerState {
            internal StateCableDelay_18_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new int[] {1018}, arg2: true);
                    context.State = new StateCableOff_18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_13 : TriggerState {
            internal StateCableOff_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_14 : TriggerState {
            internal StateCableOff_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_15 : TriggerState {
            internal StateCableOff_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 2);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_16 : TriggerState {
            internal StateCableOff_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 1);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_17 : TriggerState {
            internal StateCableOff_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 2);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_18 : TriggerState {
            internal StateCableOff_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerID: 900005, key: "Block", value: 3);
                    context.State = new StateEnd_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_03 : TriggerState {
            internal StateEnd_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}