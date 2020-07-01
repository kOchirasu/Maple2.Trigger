namespace Maple2.Trigger._02000252_bf {
    public static class _middle {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 902) == 1) {
                    context.State = new State바닥삭제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State바닥삭제 : TriggerState {
            internal State바닥삭제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "2", arg2: 5);
                context.SetMesh(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142}, arg2: false, arg3: 0, arg4: 100);
                context.CreateMonster(arg1: new[] {1075, 1076, 1077, 1078, 1079, 1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094}, arg2: false);
                context.SetEffect(arg1: new[] {8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State스킬01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬01 : TriggerState {
            internal State스킬01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetEffect(arg1: new[] {8201, 8202, 8203, 8204, 8205, 8206, 8207, 8208, 8209, 8210, 8211, 8212, 8213, 8214, 8215, 8216, 8217, 8218}, arg2: false);
                context.SetSkill(arg1: new[] {1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬02대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02대기 : TriggerState {
            internal State스킬02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬02 : TriggerState {
            internal State스킬02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬03대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03대기 : TriggerState {
            internal State스킬03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬03 : TriggerState {
            internal State스킬03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬04대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04대기 : TriggerState {
            internal State스킬04대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1313, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬04 : TriggerState {
            internal State스킬04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬05대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05대기 : TriggerState {
            internal State스킬05대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬05 : TriggerState {
            internal State스킬05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬06대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06대기 : TriggerState {
            internal State스킬06대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1325, 1326, 1327, 1328, 1328, 1330, 1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬06 : TriggerState {
            internal State스킬06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬07대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07대기 : TriggerState {
            internal State스킬07대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1331, 1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬07(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬07 : TriggerState {
            internal State스킬07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬08대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08대기 : TriggerState {
            internal State스킬08대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬08 : TriggerState {
            internal State스킬08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬09대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09대기 : TriggerState {
            internal State스킬09대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1343, 1344, 1345, 1346, 1347, 1348, 1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬09(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬09 : TriggerState {
            internal State스킬09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬10대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10대기 : TriggerState {
            internal State스킬10대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬10 : TriggerState {
            internal State스킬10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬11대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11대기 : TriggerState {
            internal State스킬11대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬11 : TriggerState {
            internal State스킬11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬12대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12대기 : TriggerState {
            internal State스킬12대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1361, 1362, 1363, 1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬12 : TriggerState {
            internal State스킬12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬13대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13대기 : TriggerState {
            internal State스킬13대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬13 : TriggerState {
            internal State스킬13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬14대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14대기 : TriggerState {
            internal State스킬14대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1373, 1374, 1375, 1376, 1377, 1378, 1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬14(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬14 : TriggerState {
            internal State스킬14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬15대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15대기 : TriggerState {
            internal State스킬15대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1379, 1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬15(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬15 : TriggerState {
            internal State스킬15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬16대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16대기 : TriggerState {
            internal State스킬16대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬16(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬16 : TriggerState {
            internal State스킬16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬17대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17대기 : TriggerState {
            internal State스킬17대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬17(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬17 : TriggerState {
            internal State스킬17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬18대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18대기 : TriggerState {
            internal State스킬18대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1391, 1392, 1393, 1394, 1395, 1396, 1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬18(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬18 : TriggerState {
            internal State스킬18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬19대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19대기 : TriggerState {
            internal State스킬19대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1397, 1398, 1399, 1400, 1401, 1402, 1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬19 : TriggerState {
            internal State스킬19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1409, 1410, 1411, 1412, 1413, 1414}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬20대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20대기 : TriggerState {
            internal State스킬20대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1403, 1404, 1405, 1406, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬20 : TriggerState {
            internal State스킬20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬21대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21대기 : TriggerState {
            internal State스킬21대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1409, 1410, 1411, 1412, 1413, 1414, 1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬21 : TriggerState {
            internal State스킬21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬22대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22대기 : TriggerState {
            internal State스킬22대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1415, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬22(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬22 : TriggerState {
            internal State스킬22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬23대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23대기 : TriggerState {
            internal State스킬23대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1421, 1422, 1423, 1424, 1425, 1426, 1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬23(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬23 : TriggerState {
            internal State스킬23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬24대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24대기 : TriggerState {
            internal State스킬24대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1427, 1428, 1429, 1430, 1431, 1432, 1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬24(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬24 : TriggerState {
            internal State스킬24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬25대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25대기 : TriggerState {
            internal State스킬25대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1433, 1434, 1435, 1436, 1437, 1438, 1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬25(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬25 : TriggerState {
            internal State스킬25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬26대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26대기 : TriggerState {
            internal State스킬26대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1439, 1440, 1441, 1442, 1443, 1444, 1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬26(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬26 : TriggerState {
            internal State스킬26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬27대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27대기 : TriggerState {
            internal State스킬27대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1445, 1446, 1447, 1448, 1449, 1450, 1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬27(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬27 : TriggerState {
            internal State스킬27(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬28대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28대기 : TriggerState {
            internal State스킬28대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1451, 1452, 1453, 1454, 1455, 1456, 1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬28(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬28 : TriggerState {
            internal State스킬28(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬29대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29대기 : TriggerState {
            internal State스킬29대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1457, 1458, 1459, 1460, 1461, 1462, 1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬29(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬29 : TriggerState {
            internal State스킬29(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬30대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30대기 : TriggerState {
            internal State스킬30대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1463, 1464, 1465, 1466, 1467, 1468, 1469, 1470, 1471, 1472, 1473, 1475, 1474, 1476, 1477, 1478, 1479, 1480}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬30(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬30 : TriggerState {
            internal State스킬30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬31대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31대기 : TriggerState {
            internal State스킬31대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1469, 1470, 1471, 1472, 1473, 1474, 1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬31(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬31 : TriggerState {
            internal State스킬31(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬32대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32대기 : TriggerState {
            internal State스킬32대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1475, 1476, 1477, 1478, 1479, 1480, 1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬32(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬32 : TriggerState {
            internal State스킬32(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬33대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33대기 : TriggerState {
            internal State스킬33대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1481, 1482, 1483, 1484, 1485, 1486, 1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498}, arg2: false);
            }

            public override void Execute() {
                if (true) {
                    context.State = new State스킬33(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬33 : TriggerState {
            internal State스킬33(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1);
                context.SetSkill(arg1: new[] {1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498, 1499, 1500, 1501, 1502, 1503, 1504}, arg2: true);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State스킬34대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State스킬34대기 : TriggerState {
            internal State스킬34대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkill(arg1: new[] {1487, 1488, 1489, 1490, 1491, 1492, 1493, 1494, 1495, 1496, 1497, 1498, 1499, 1500, 1501, 1502, 1503, 1504}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}