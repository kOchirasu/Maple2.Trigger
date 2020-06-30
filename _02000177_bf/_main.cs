using System;
using Maple2.Trigger._dungeon_common;

namespace Maple2.Trigger._02000177_bf {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Stateidle(context);

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State =
                        new _checkusercount.StateCheckUserCount(context, new StateDungeonStart(context));
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDungeonStart : TriggerState {
            internal StateDungeonStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {10001058}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001059}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {10001060}, arg2: 1);
                context.CreateMonster(arg1: new int[] {101, 102, 103, 104}, arg2: false);
                context.CreateMonster(arg1: new int[] {110, 111, 112, 113, 114, 115, 116, 117}, arg2: false);
                context.CreateMonster(arg1: new int[] {120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130},
                    arg2: false);
                context.CreateMonster(arg1: new int[] {141, 142, 143, 144, 145, 146}, arg2: false);
                context.CreateMonster(arg1: new int[] {150, 151, 152, 153, 154, 155, 156, 157, 158, 159}, arg2: false);
                context.SetMesh(
                    arg1: new int[] {
                        1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012, 1013, 1014, 1015,
                        1016, 1017, 1018, 1019, 1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031,
                        1032, 1033, 1034, 1035, 1036, 1037, 1038, 1039, 1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047,
                        1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055, 1056, 1057, 1058, 1059, 1060, 1061, 1062, 1063,
                        1064, 1065, 1066, 1067, 1068, 1069, 1070, 1071, 1072, 1073, 1074, 1075, 1076, 1077, 1078, 1079,
                        1080, 1081, 1082, 1083, 1084, 1085, 1086, 1087, 1088, 1089, 1090, 1091, 1092, 1093, 1094, 1095,
                        1096, 1097, 1098, 1099
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        1300, 1301, 1302, 1303, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1313, 1314, 1315,
                        1316, 1317, 1318, 1319, 1320, 1321, 1322, 1323, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331,
                        1332, 1333, 1334, 1335, 1336, 1337, 1338, 1339, 1340, 1341, 1342, 1343, 1344, 1345, 1346, 1347,
                        1348, 1349, 1350, 1351, 1352, 1353, 1354, 1355, 1356, 1357, 1358, 1359, 1360, 1361, 1362, 1363,
                        1364, 1365, 1366, 1367, 1368, 1369, 1370, 1371, 1372, 1373, 1374, 1375, 1376, 1377, 1378, 1379,
                        1380, 1381, 1382, 1383, 1384, 1385, 1386, 1387, 1388, 1389, 1390, 1391, 1392, 1393, 1394, 1395,
                        1396, 1397, 1398, 1399
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {741, 742, 743, 744, 745, 746, 747, 748, 749, 750}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {999}, arg2: false);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8001, 8002}, arg2: 1);
                context.SetMesh(arg1: new int[] {1100, 1101, 1102, 1103, 1104, 1105, 1106, 1107, 1108, 1109, 1110},
                    arg2: false, arg3: 0, arg4: 0, arg5: 10f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateStart_02(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
            }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$02000177_BF__MAIN__0$", arg3: new int[] {3000}, arg4: "0");
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.ShowGuideSummary(entityID: 20001773, textID: 20001773, durationTime: 4000);
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_2001");
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001058}, arg2: 0)) {
                    context.State = new StateStep_2(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10001058}, arg2: 2);
                context.SetEffect(arg1: new int[] {6661}, arg2: false);
            }
        }

        private class StateStep_2 : TriggerState {
            internal StateStep_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {1000, 1001, 1002, 1003, 1004, 1005, 1006, 1007, 1008, 1009, 1010, 1011, 1012},
                    arg2: true, arg3: 0, arg4: 100, arg5: 10f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001059}, arg2: 0)) {
                    context.State = new StateStep_3(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10001059}, arg2: 2);
                context.SetEffect(arg1: new int[] {6662}, arg2: false);
            }
        }

        private class StateStep_3 : TriggerState {
            internal StateStep_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {1020, 1021, 1022, 1023, 1024, 1025, 1026, 1027, 1028, 1029, 1030, 1031, 1032},
                    arg2: true, arg3: 0, arg4: 100, arg5: 10f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10001060}, arg2: 0)) {
                    context.State = new StateStep_4(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetInteractObject(arg1: new int[] {10001060}, arg2: 2);
                context.SetEffect(arg1: new int[] {6663}, arg2: false);
            }
        }

        private class StateStep_4 : TriggerState {
            internal StateStep_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new int[] {
                        1040, 1041, 1042, 1043, 1044, 1045, 1046, 1047, 1048, 1049, 1050, 1051, 1052, 1053, 1054, 1055,
                        1056, 1057, 1058, 1059, 1060
                    }, arg2: true, arg3: 0, arg4: 100, arg5: 10f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}