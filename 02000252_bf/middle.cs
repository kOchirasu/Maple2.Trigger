namespace Maple2.Trigger._02000252_bf {
    public static class _middle {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    return new State바닥삭제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State바닥삭제 : TriggerState {
            internal State바닥삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "2", seconds: 5);
                context.SetMesh(triggerIds: new []{101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142}, visible: false, arg3: 0, arg4: 100);
                context.CreateMonster(spawnIds: new []{1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094}, arg2: false);
                context.SetEffect(triggerIds: new []{8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "2")) {
                    return new StateSkill01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill01 : TriggerState {
            internal StateSkill01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetEffect(triggerIds: new []{8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, visible: false);
                context.SetSkill(triggerIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill02Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill02Wait : TriggerState {
            internal StateSkill02Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill02(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill02 : TriggerState {
            internal StateSkill02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill03Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill03Wait : TriggerState {
            internal StateSkill03Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill03(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill03 : TriggerState {
            internal StateSkill03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill04Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill04Wait : TriggerState {
            internal StateSkill04Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill04(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill04 : TriggerState {
            internal StateSkill04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill05Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill05Wait : TriggerState {
            internal StateSkill05Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill05(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill05 : TriggerState {
            internal StateSkill05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill06Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill06Wait : TriggerState {
            internal StateSkill06Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill06(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill06 : TriggerState {
            internal StateSkill06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill07Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill07Wait : TriggerState {
            internal StateSkill07Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill07(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill07 : TriggerState {
            internal StateSkill07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill08Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill08Wait : TriggerState {
            internal StateSkill08Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill08(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill08 : TriggerState {
            internal StateSkill08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill09Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill09Wait : TriggerState {
            internal StateSkill09Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill09(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill09 : TriggerState {
            internal StateSkill09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill10Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill10Wait : TriggerState {
            internal StateSkill10Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill10(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill10 : TriggerState {
            internal StateSkill10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill11Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill11Wait : TriggerState {
            internal StateSkill11Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill11(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill11 : TriggerState {
            internal StateSkill11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill12Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill12Wait : TriggerState {
            internal StateSkill12Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill12(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill12 : TriggerState {
            internal StateSkill12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill13Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill13Wait : TriggerState {
            internal StateSkill13Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill13(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill13 : TriggerState {
            internal StateSkill13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill14Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill14Wait : TriggerState {
            internal StateSkill14Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill14(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill14 : TriggerState {
            internal StateSkill14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill15Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill15Wait : TriggerState {
            internal StateSkill15Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill15(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill15 : TriggerState {
            internal StateSkill15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill16Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill16Wait : TriggerState {
            internal StateSkill16Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill16(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill16 : TriggerState {
            internal StateSkill16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill17Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill17Wait : TriggerState {
            internal StateSkill17Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill17(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill17 : TriggerState {
            internal StateSkill17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill18Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill18Wait : TriggerState {
            internal StateSkill18Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill18(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill18 : TriggerState {
            internal StateSkill18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill19Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill19Wait : TriggerState {
            internal StateSkill19Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill19(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill19 : TriggerState {
            internal StateSkill19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1409, 1410, 1411, 1412, 1413, 1414}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill20Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill20Wait : TriggerState {
            internal StateSkill20Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill20(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill20 : TriggerState {
            internal StateSkill20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill21Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill21Wait : TriggerState {
            internal StateSkill21Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill21(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill21 : TriggerState {
            internal StateSkill21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill22Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill22Wait : TriggerState {
            internal StateSkill22Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill22(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill22 : TriggerState {
            internal StateSkill22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill23Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill23Wait : TriggerState {
            internal StateSkill23Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill23(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill23 : TriggerState {
            internal StateSkill23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill24Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill24Wait : TriggerState {
            internal StateSkill24Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill24(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill24 : TriggerState {
            internal StateSkill24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill25Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill25Wait : TriggerState {
            internal StateSkill25Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill25(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill25 : TriggerState {
            internal StateSkill25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill26Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill26Wait : TriggerState {
            internal StateSkill26Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill26(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill26 : TriggerState {
            internal StateSkill26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill27Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill27Wait : TriggerState {
            internal StateSkill27Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill27(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill27 : TriggerState {
            internal StateSkill27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill28Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill28Wait : TriggerState {
            internal StateSkill28Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill28(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill28 : TriggerState {
            internal StateSkill28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill29Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill29Wait : TriggerState {
            internal StateSkill29Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill29(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill29 : TriggerState {
            internal StateSkill29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill30Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill30Wait : TriggerState {
            internal StateSkill30Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1475, 1474, 1476, 1477, 1478, 1479, 1480}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill30(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill30 : TriggerState {
            internal StateSkill30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill31Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill31Wait : TriggerState {
            internal StateSkill31Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill31(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill31 : TriggerState {
            internal StateSkill31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill32Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill32Wait : TriggerState {
            internal StateSkill32Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill32(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill32 : TriggerState {
            internal StateSkill32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill33Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill33Wait : TriggerState {
            internal StateSkill33Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498}, enabled: false);
            }

            public override TriggerState? Execute() {
                return new StateSkill33(context);
            }

            public override void OnExit() { }
        }

        private class StateSkill33 : TriggerState {
            internal StateSkill33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 1);
                context.SetSkill(triggerIds: new []{1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498, 1499, 1500, 1501, 1502, 1503, 1504}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateSkill34Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkill34Wait : TriggerState {
            internal StateSkill34Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(triggerIds: new []{1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498, 1499, 1500, 1501, 1502, 1503, 1504}, enabled: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
