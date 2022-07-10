namespace Maple2.Trigger._02020015_bf {
    public static class _02020015_main {
        public class State감지 : TriggerState {
            internal State감지(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110, 1111, 1112, 1113, 1114, 1115, 1116, 1117, 1118, 1119, 1120, 1121, 1122, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 1225, 1226, 1227, 1228, 1229, 1230, 1231, 1232, 1233, 1234, 1235, 1236, 1237, 1238, 1239, 1240, 1241, 1242, 1243, 1244, 1245, 1246, 1247, 1248, 1249, 1250, 1251, 1252, 1253, 1254, 1255}, visible: false);
                context.SetMesh(triggerIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, visible: true);
                context.SetCube(triggerIds: new []{1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448}, visible: false);
                context.SetUserValue(triggerId: 99990002, key: "Timer", value: 0);
                context.SetLadder(triggerId: 2001, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2002, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2003, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2004, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2005, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2006, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2007, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2008, visible: false, animationEffect: false, animationDelay: 0);
                context.SetLadder(triggerId: 2009, visible: false, animationEffect: false, animationDelay: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{901})) {
                    return new State엘리베이터(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State엘리베이터 : TriggerState {
            internal State엘리베이터(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State복도(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State복도 : TriggerState {
            internal State복도(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{902})) {
                    return new State내부진입(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State내부진입 : TriggerState {
            internal State내부진입(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{903}, jobCode: 0)) {
                    return new StateSetup(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "20초 후 발판이 사라집니다.", duration: 3000);
                context.SetMesh(triggerIds: new []{1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015, 1016, 1017, 1018, 1019}, visible: true);
                context.SetUserValue(triggerId: 99990002, key: "Timer", value: 1);
            }

            public override TriggerState? Execute() {
                return new StateBoss(context);
            }

            public override void OnExit() { }
        }

        private class StateBoss : TriggerState {
            internal StateBoss(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111}, arg2: false);
                context.SetMesh(triggerIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, visible: false);
                context.SetCube(triggerIds: new []{1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{111})) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
