namespace Maple2.Trigger._02000384_bf {
    public static class _normal {
        public class StateRoomCheck2 : TriggerState {
            internal StateRoomCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateIdle(context);
                }

                if (!context.IsDungeonRoom()) {
                    // return new StateQuest_idle(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_Idle : TriggerState {
            internal StateQuest_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103, 104, 105}, arg2: false);
                context.SetMesh(triggerIds: new []{1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809}, visible: false);
                context.SetLadder(triggerId: 1101, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1102, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1103, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1104, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1105, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1106, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1107, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1108, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1109, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1110, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1111, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1112, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1113, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1114, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1115, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1116, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1117, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1118, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1201, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1202, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1203, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1204, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1205, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1206, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1207, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1208, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1209, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1210, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1211, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1212, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1213, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1214, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1215, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1216, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1217, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1218, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1301, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1302, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1303, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1304, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1305, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1306, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1307, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1308, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1309, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1310, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1311, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1312, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1313, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1314, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1315, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1316, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1317, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1318, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1401, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1402, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1403, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1404, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1405, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1406, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1407, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1408, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1409, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1410, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1411, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1412, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1413, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1414, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1415, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1416, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1417, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1418, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1501, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1502, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1503, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1504, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1505, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1506, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1507, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1508, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1509, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1510, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1511, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1512, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1513, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1514, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1515, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1516, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1517, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1518, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1601, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1602, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1603, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1604, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1605, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1606, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1607, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1608, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1609, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1610, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1611, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1612, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1613, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1614, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1615, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1616, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1617, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 1618, visible: false, animationEffect: false, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{101, 102, 103, 104, 105})) {
                    return new StateStep_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_02 : TriggerState {
            internal StateStep_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917}, visible: true);
                context.SetLadder(triggerId: 1101, visible: true, animationEffect: true, animationDelay: 1);
                context.SetLadder(triggerId: 1102, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1103, visible: true, animationEffect: true, animationDelay: 3);
                context.SetLadder(triggerId: 1104, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 1105, visible: true, animationEffect: true, animationDelay: 5);
                context.SetLadder(triggerId: 1106, visible: true, animationEffect: true, animationDelay: 6);
                context.SetLadder(triggerId: 1107, visible: true, animationEffect: true, animationDelay: 7);
                context.SetLadder(triggerId: 1108, visible: true, animationEffect: true, animationDelay: 8);
                context.SetLadder(triggerId: 1109, visible: true, animationEffect: true, animationDelay: 9);
                context.SetLadder(triggerId: 1110, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 1111, visible: true, animationEffect: true, animationDelay: 11);
                context.SetLadder(triggerId: 1112, visible: true, animationEffect: true, animationDelay: 12);
                context.SetLadder(triggerId: 1113, visible: true, animationEffect: true, animationDelay: 13);
                context.SetLadder(triggerId: 1114, visible: true, animationEffect: true, animationDelay: 14);
                context.SetLadder(triggerId: 1115, visible: true, animationEffect: true, animationDelay: 15);
                context.SetLadder(triggerId: 1116, visible: true, animationEffect: true, animationDelay: 16);
                context.SetLadder(triggerId: 1117, visible: true, animationEffect: true, animationDelay: 17);
                context.SetLadder(triggerId: 1118, visible: true, animationEffect: true, animationDelay: 18);
                context.SetLadder(triggerId: 1201, visible: true, animationEffect: true, animationDelay: 1);
                context.SetLadder(triggerId: 1202, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1203, visible: true, animationEffect: true, animationDelay: 3);
                context.SetLadder(triggerId: 1204, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 1205, visible: true, animationEffect: true, animationDelay: 5);
                context.SetLadder(triggerId: 1206, visible: true, animationEffect: true, animationDelay: 6);
                context.SetLadder(triggerId: 1207, visible: true, animationEffect: true, animationDelay: 7);
                context.SetLadder(triggerId: 1208, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1209, visible: true, animationEffect: true, animationDelay: 8);
                context.SetLadder(triggerId: 1210, visible: true, animationEffect: true, animationDelay: 9);
                context.SetLadder(triggerId: 1211, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 1212, visible: true, animationEffect: true, animationDelay: 11);
                context.SetLadder(triggerId: 1213, visible: true, animationEffect: true, animationDelay: 12);
                context.SetLadder(triggerId: 1214, visible: true, animationEffect: true, animationDelay: 13);
                context.SetLadder(triggerId: 1215, visible: true, animationEffect: true, animationDelay: 14);
                context.SetLadder(triggerId: 1216, visible: true, animationEffect: true, animationDelay: 15);
                context.SetLadder(triggerId: 1217, visible: true, animationEffect: true, animationDelay: 16);
                context.SetLadder(triggerId: 1218, visible: true, animationEffect: true, animationDelay: 17);
                context.SetLadder(triggerId: 1301, visible: true, animationEffect: true, animationDelay: 1);
                context.SetLadder(triggerId: 1302, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1303, visible: true, animationEffect: true, animationDelay: 3);
                context.SetLadder(triggerId: 1304, visible: true, animationEffect: true, animationDelay: 4);
                context.SetLadder(triggerId: 1305, visible: true, animationEffect: true, animationDelay: 5);
                context.SetLadder(triggerId: 1306, visible: true, animationEffect: true, animationDelay: 6);
                context.SetLadder(triggerId: 1307, visible: true, animationEffect: true, animationDelay: 7);
                context.SetLadder(triggerId: 1308, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1309, visible: true, animationEffect: true, animationDelay: 8);
                context.SetLadder(triggerId: 1310, visible: true, animationEffect: true, animationDelay: 9);
                context.SetLadder(triggerId: 1311, visible: true, animationEffect: true, animationDelay: 10);
                context.SetLadder(triggerId: 1312, visible: true, animationEffect: true, animationDelay: 11);
                context.SetLadder(triggerId: 1313, visible: true, animationEffect: true, animationDelay: 12);
                context.SetLadder(triggerId: 1314, visible: true, animationEffect: true, animationDelay: 13);
                context.SetLadder(triggerId: 1315, visible: true, animationEffect: true, animationDelay: 14);
                context.SetLadder(triggerId: 1316, visible: true, animationEffect: true, animationDelay: 15);
                context.SetLadder(triggerId: 1317, visible: true, animationEffect: true, animationDelay: 16);
                context.SetLadder(triggerId: 1318, visible: true, animationEffect: true, animationDelay: 17);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new StateStep_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_03 : TriggerState {
            internal StateStep_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203})) {
                    return new StateStep_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_04 : TriggerState {
            internal StateStep_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(triggerId: 1401, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1402, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1403, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1404, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1405, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1406, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1407, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1408, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1409, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1410, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1411, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1412, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1413, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1414, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1415, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1416, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1417, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1418, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1501, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1502, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1503, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1504, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1505, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1506, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1507, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1508, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1509, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1510, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1511, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1512, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1513, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1514, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1515, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1516, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1517, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1518, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{703})) {
                    return new StateStep_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_05 : TriggerState {
            internal StateStep_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{301, 302, 303}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{301, 302, 303})) {
                    return new StateStep_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_06 : TriggerState {
            internal StateStep_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "LadderGoBossRoom") == 1) {
                    return new StateStep_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_07 : TriggerState {
            internal StateStep_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809}, visible: true);
                context.SetLadder(triggerId: 1601, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1602, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1603, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1604, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1605, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1606, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1607, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1608, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1609, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1610, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1611, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1612, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1613, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1614, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1615, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1616, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1617, visible: true, animationEffect: true, animationDelay: 2);
                context.SetLadder(triggerId: 1618, visible: true, animationEffect: true, animationDelay: 2);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
