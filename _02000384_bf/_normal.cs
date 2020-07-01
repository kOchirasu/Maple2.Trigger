namespace Maple2.Trigger._02000384_bf {
    public static class _normal {
        public class StateroomCheck2 : TriggerState {
            internal StateroomCheck2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    // context.State = new Statequest_idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequest_Idle : TriggerState {
            internal Statequest_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102, 103, 104, 105}, arg2: false);
                context.SetMesh(arg1: new[] {1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917, 1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809}, arg2: false);
                context.SetLadder(arg1: 1101, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1102, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1103, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1104, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1105, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1106, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1107, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1108, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1109, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1110, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1111, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1112, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1113, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1114, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1115, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1116, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1117, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1118, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1201, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1202, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1203, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1204, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1205, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1206, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1207, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1208, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1209, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1210, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1211, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1212, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1213, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1214, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1215, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1216, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1217, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1218, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1301, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1302, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1303, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1304, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1305, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1306, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1307, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1308, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1309, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1310, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1311, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1312, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1313, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1314, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1315, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1316, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1317, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1318, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1401, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1402, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1403, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1404, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1405, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1406, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1407, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1408, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1409, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1410, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1411, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1412, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1413, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1414, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1415, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1416, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1417, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1418, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1501, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1502, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1503, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1504, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1505, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1506, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1507, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1508, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1509, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1510, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1511, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1512, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1513, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1514, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1515, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1516, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1517, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1518, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1601, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1602, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1603, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1604, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1605, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1606, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1607, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1608, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1609, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1610, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1611, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1612, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1613, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1614, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1615, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1616, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1617, arg2: false, arg3: false, arg4: 0);
                context.SetLadder(arg1: 1618, arg2: false, arg3: false, arg4: 0);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {101, 102, 103, 104, 105})) {
                    context.State = new Statestep_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_02 : TriggerState {
            internal Statestep_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915, 1916, 1917}, arg2: true);
                context.SetLadder(arg1: 1101, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 1102, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1103, arg2: true, arg3: true, arg4: 3);
                context.SetLadder(arg1: 1104, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 1105, arg2: true, arg3: true, arg4: 5);
                context.SetLadder(arg1: 1106, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 1107, arg2: true, arg3: true, arg4: 7);
                context.SetLadder(arg1: 1108, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 1109, arg2: true, arg3: true, arg4: 9);
                context.SetLadder(arg1: 1110, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 1111, arg2: true, arg3: true, arg4: 11);
                context.SetLadder(arg1: 1112, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 1113, arg2: true, arg3: true, arg4: 13);
                context.SetLadder(arg1: 1114, arg2: true, arg3: true, arg4: 14);
                context.SetLadder(arg1: 1115, arg2: true, arg3: true, arg4: 15);
                context.SetLadder(arg1: 1116, arg2: true, arg3: true, arg4: 16);
                context.SetLadder(arg1: 1117, arg2: true, arg3: true, arg4: 17);
                context.SetLadder(arg1: 1118, arg2: true, arg3: true, arg4: 18);
                context.SetLadder(arg1: 1201, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 1202, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1203, arg2: true, arg3: true, arg4: 3);
                context.SetLadder(arg1: 1204, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 1205, arg2: true, arg3: true, arg4: 5);
                context.SetLadder(arg1: 1206, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 1207, arg2: true, arg3: true, arg4: 7);
                context.SetLadder(arg1: 1208, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1209, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 1210, arg2: true, arg3: true, arg4: 9);
                context.SetLadder(arg1: 1211, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 1212, arg2: true, arg3: true, arg4: 11);
                context.SetLadder(arg1: 1213, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 1214, arg2: true, arg3: true, arg4: 13);
                context.SetLadder(arg1: 1215, arg2: true, arg3: true, arg4: 14);
                context.SetLadder(arg1: 1216, arg2: true, arg3: true, arg4: 15);
                context.SetLadder(arg1: 1217, arg2: true, arg3: true, arg4: 16);
                context.SetLadder(arg1: 1218, arg2: true, arg3: true, arg4: 17);
                context.SetLadder(arg1: 1301, arg2: true, arg3: true, arg4: 1);
                context.SetLadder(arg1: 1302, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1303, arg2: true, arg3: true, arg4: 3);
                context.SetLadder(arg1: 1304, arg2: true, arg3: true, arg4: 4);
                context.SetLadder(arg1: 1305, arg2: true, arg3: true, arg4: 5);
                context.SetLadder(arg1: 1306, arg2: true, arg3: true, arg4: 6);
                context.SetLadder(arg1: 1307, arg2: true, arg3: true, arg4: 7);
                context.SetLadder(arg1: 1308, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1309, arg2: true, arg3: true, arg4: 8);
                context.SetLadder(arg1: 1310, arg2: true, arg3: true, arg4: 9);
                context.SetLadder(arg1: 1311, arg2: true, arg3: true, arg4: 10);
                context.SetLadder(arg1: 1312, arg2: true, arg3: true, arg4: 11);
                context.SetLadder(arg1: 1313, arg2: true, arg3: true, arg4: 12);
                context.SetLadder(arg1: 1314, arg2: true, arg3: true, arg4: 13);
                context.SetLadder(arg1: 1315, arg2: true, arg3: true, arg4: 14);
                context.SetLadder(arg1: 1316, arg2: true, arg3: true, arg4: 15);
                context.SetLadder(arg1: 1317, arg2: true, arg3: true, arg4: 16);
                context.SetLadder(arg1: 1318, arg2: true, arg3: true, arg4: 17);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {702})) {
                    context.State = new Statestep_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_03 : TriggerState {
            internal Statestep_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201, 202, 203}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {201, 202, 203})) {
                    context.State = new Statestep_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_04 : TriggerState {
            internal Statestep_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLadder(arg1: 1401, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1402, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1403, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1404, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1405, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1406, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1407, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1408, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1409, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1410, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1411, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1412, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1413, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1414, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1415, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1416, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1417, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1418, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1501, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1502, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1503, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1504, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1505, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1506, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1507, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1508, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1509, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1510, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1511, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1512, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1513, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1514, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1515, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1516, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1517, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1518, arg2: true, arg3: true, arg4: 2);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {703})) {
                    context.State = new Statestep_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_05 : TriggerState {
            internal Statestep_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {301, 302, 303}, arg2: false);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {301, 302, 303})) {
                    context.State = new Statestep_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_06 : TriggerState {
            internal Statestep_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "LadderGoBossRoom") == 1) {
                    context.State = new Statestep_07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statestep_07 : TriggerState {
            internal Statestep_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809}, arg2: true);
                context.SetLadder(arg1: 1601, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1602, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1603, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1604, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1605, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1606, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1607, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1608, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1609, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1610, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1611, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1612, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1613, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1614, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1615, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1616, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1617, arg2: true, arg3: true, arg4: 2);
                context.SetLadder(arg1: 1618, arg2: true, arg3: true, arg4: 2);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}