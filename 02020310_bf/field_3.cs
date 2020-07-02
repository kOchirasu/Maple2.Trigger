namespace Maple2.Trigger._02020310_bf {
    public static class _field_3 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000313, 12000314, 12000315, 12000316, 12000317, 12000318}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateArriveBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateArriveBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateArriveBlock_3(context);
                }

                if (context.GetUserValue(key: "Block") == 4) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 0);
                    return new StateArriveBlock_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_1 : TriggerState {
            internal StateArriveBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9004})) {
                    return new StateArriveBlock_Delay_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_1 : TriggerState {
            internal StateArriveBlock_Delay_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2004}, arg2: false);
                    return new StateBlock_1(context);
                }

                if (context.MonsterDead(arg1: new[] {1110, 1303, 1304, 1309, 1310, 1311, 1312, 1313, 1314})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000313}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: true);
                    return new StateCableOn_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1110, 1303, 1304, 1309, 1310, 1311, 1312, 1313, 1314})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000313}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: true);
                    return new StateCableOn_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_2 : TriggerState {
            internal StateArriveBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9005})) {
                    return new StateArriveBlock_Delay_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_2 : TriggerState {
            internal StateArriveBlock_Delay_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2005}, arg2: false);
                    return new StateBlock_2(context);
                }

                if (context.MonsterDead(arg1: new[] {1111, 1301, 1302, 1321, 1322, 1323, 1324, 1325, 1326})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000314, 12000315}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: true);
                    return new StateCableOn_14_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1111, 1301, 1302, 1321, 1322, 1323, 1324, 1325, 1326})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000314, 12000315}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: true);
                    return new StateCableOn_14_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_3 : TriggerState {
            internal StateArriveBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9006})) {
                    return new StateArriveBlock_Delay_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_3 : TriggerState {
            internal StateArriveBlock_Delay_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2006}, arg2: false);
                    return new StateBlock_3(context);
                }

                if (context.MonsterDead(arg1: new[] {1112, 1307, 1308, 1327, 1328, 1329, 1330, 1331, 1332})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000316, 12000317}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: true);
                    return new StateCableOn_16_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1112, 1307, 1308, 1327, 1328, 1329, 1330, 1331, 1332})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000316, 12000317}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: true);
                    return new StateCableOn_16_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_4 : TriggerState {
            internal StateArriveBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9007})) {
                    return new StateArriveBlock_Delay_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_4 : TriggerState {
            internal StateArriveBlock_Delay_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.CreateMonster(arg1: new[] {2007}, arg2: false);
                    return new StateBlock_4(context);
                }

                if (context.MonsterDead(arg1: new[] {1113, 1305, 1306, 1315, 1316, 1317, 1318, 1319, 1320})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000318}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: true);
                    return new StateCableOn_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_4 : TriggerState {
            internal StateBlock_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1113, 1305, 1306, 1315, 1316, 1317, 1318, 1319, 1320})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.SetInteractObject(arg1: new[] {12000318}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1114, 1115, 1116, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: true);
                    return new StateCableOn_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_13 : TriggerState {
            internal StateCableOn_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000313}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000313}, arg2: 0);
                    context.SetMesh(arg1: new[] {1110001, 1110002, 1110003, 1110004, 1110005, 1110006, 1110007, 1110008, 1110009, 1110010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_14_15 : TriggerState {
            internal StateCableOn_14_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000314}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000314, 12000315}, arg2: 0);
                    context.SetMesh(arg1: new[] {1120001, 1120002, 1120003, 1120004, 1120005, 1120006, 1120007, 1120008, 1120009, 1120010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_14(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000315}, arg2: 0)) {
                    context.SetVisibleBreakableObject(arg1: new[] {1016}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000314, 12000315}, arg2: 0);
                    context.SetMesh(arg1: new[] {1130001, 1130002, 1130003, 1130004, 1130005, 1130006, 1130007, 1130008, 1130009, 1130010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_16_17 : TriggerState {
            internal StateCableOn_16_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000316}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000316, 12000317}, arg2: 0);
                    context.SetMesh(arg1: new[] {1140001, 1140002, 1140003, 1140004, 1140005, 1140006, 1140007, 1140008, 1140009, 1140010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_16(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000317}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000316, 12000317}, arg2: 0);
                    context.SetMesh(arg1: new[] {1150001, 1150002, 1150003, 1150004, 1150005, 1150006, 1150007, 1150008, 1150009, 1150010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_18 : TriggerState {
            internal StateCableOn_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000318}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000318}, arg2: 0);
                    context.SetMesh(arg1: new[] {1160001, 1160002, 1160003, 1160004, 1160005, 1160006, 1160007, 1160008, 1160009, 1160010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13 : TriggerState {
            internal StateCableDelay_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__0$", arg3: 3000);
                    return new StateCableDelay_13_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14 : TriggerState {
            internal StateCableDelay_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__1$", arg3: 3000);
                    return new StateCableDelay_14_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15 : TriggerState {
            internal StateCableDelay_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__2$", arg3: 3000);
                    return new StateCableDelay_15_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16 : TriggerState {
            internal StateCableDelay_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__3$", arg3: 3000);
                    return new StateCableDelay_16_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17 : TriggerState {
            internal StateCableDelay_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__4$", arg3: 3000);
                    return new StateCableDelay_17_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18 : TriggerState {
            internal StateCableDelay_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__5$", arg3: 3000);
                    return new StateCableDelay_18_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_2 : TriggerState {
            internal StateCableDelay_13_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__6$", arg3: 1000);
                    return new StateCableDelay_13_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_2 : TriggerState {
            internal StateCableDelay_14_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__7$", arg3: 1000);
                    return new StateCableDelay_14_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_2 : TriggerState {
            internal StateCableDelay_15_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__8$", arg3: 1000);
                    return new StateCableDelay_15_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_2 : TriggerState {
            internal StateCableDelay_16_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__9$", arg3: 1000);
                    return new StateCableDelay_16_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_2 : TriggerState {
            internal StateCableDelay_17_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__10$", arg3: 1000);
                    return new StateCableDelay_17_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_2 : TriggerState {
            internal StateCableDelay_18_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__11$", arg3: 1000);
                    return new StateCableDelay_18_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_3 : TriggerState {
            internal StateCableDelay_13_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__12$", arg3: 1000);
                    return new StateCableDelay_13_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_3 : TriggerState {
            internal StateCableDelay_14_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__13$", arg3: 1000);
                    return new StateCableDelay_14_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_3 : TriggerState {
            internal StateCableDelay_15_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__14$", arg3: 1000);
                    return new StateCableDelay_15_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_3 : TriggerState {
            internal StateCableDelay_16_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__15$", arg3: 1000);
                    return new StateCableDelay_16_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_3 : TriggerState {
            internal StateCableDelay_17_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__16$", arg3: 1000);
                    return new StateCableDelay_17_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_3 : TriggerState {
            internal StateCableDelay_18_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__17$", arg3: 1000);
                    return new StateCableDelay_18_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_4 : TriggerState {
            internal StateCableDelay_13_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__18$", arg3: 1000);
                    return new StateCableDelay_13_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_4 : TriggerState {
            internal StateCableDelay_14_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__19$", arg3: 1000);
                    return new StateCableDelay_14_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_4 : TriggerState {
            internal StateCableDelay_15_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__20$", arg3: 1000);
                    return new StateCableDelay_15_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_4 : TriggerState {
            internal StateCableDelay_16_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__21$", arg3: 1000);
                    return new StateCableDelay_16_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_4 : TriggerState {
            internal StateCableDelay_17_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__22$", arg3: 1000);
                    return new StateCableDelay_17_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_4 : TriggerState {
            internal StateCableDelay_18_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_3__23$", arg3: 1000);
                    return new StateCableDelay_18_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_13_5 : TriggerState {
            internal StateCableDelay_13_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1013}, arg2: true);
                    return new StateCableOff_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_14_5 : TriggerState {
            internal StateCableDelay_14_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1014}, arg2: true);
                    return new StateCableOff_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_15_5 : TriggerState {
            internal StateCableDelay_15_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1015}, arg2: true);
                    return new StateCableOff_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_16_5 : TriggerState {
            internal StateCableDelay_16_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1016}, arg2: true);
                    return new StateCableOff_16(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_17_5 : TriggerState {
            internal StateCableDelay_17_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1017}, arg2: true);
                    return new StateCableOff_17(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_18_5 : TriggerState {
            internal StateCableDelay_18_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(arg1: new[] {1018}, arg2: true);
                    return new StateCableOff_18(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_13 : TriggerState {
            internal StateCableOff_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_14 : TriggerState {
            internal StateCableOff_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_15 : TriggerState {
            internal StateCableOff_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 2);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_16 : TriggerState {
            internal StateCableOff_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 1);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_17 : TriggerState {
            internal StateCableOff_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 2);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_18 : TriggerState {
            internal StateCableOff_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 3);
                    return new StateEnd_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_03 : TriggerState {
            internal StateEnd_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}