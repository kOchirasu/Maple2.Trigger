namespace Maple2.Trigger._52100042_qd {
    public static class _main {
        public class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001}, arg2: false);
                context.SetMesh(arg1: new[] {6002}, arg2: false);
                context.SetMesh(arg1: new[] {6003}, arg2: false);
                context.SetMesh(arg1: new[] {6004}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {701})) {
                    context.State = new StateroomCheck(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateroomCheck : TriggerState {
            internal StateroomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new Statelevelcheck(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new Statequest_raid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statelevelcheck : TriggerState {
            internal Statelevelcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetDungeonLevel() == 2) {
                    context.State = new Stateraid(context);
                    return;
                }

                if (context.GetDungeonLevel() == 3) {
                    context.State = new Statechaos_raid(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateraid : TriggerState {
            internal Stateraid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statechaos_raid : TriggerState {
            internal Statechaos_raid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {402}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    context.State = new Stateend(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statequest_raid : TriggerState {
            internal Statequest_raid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(
                    arg1: new[] {
                        1900, 1901, 1902, 1903, 1904, 1905, 1906, 1907, 1908, 1909, 1910, 1911, 1912, 1913, 1914, 1915,
                        1916, 1917
                    }, arg2: true);
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
                context.SetMesh(arg1: new[] {1800, 1801, 1802, 1803, 1804, 1805, 1806, 1807, 1808, 1809},
                    arg2: true);
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
                context.CreateMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 511}, arg2: false);
                context.CreateMonster(arg1: new[] {403}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    context.State = new Statequest_end(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {720})) {
                    context.State = new StatenpcSpawn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatenpcSpawn : TriggerState {
            internal StatenpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {510}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    context.State = new Statequest_end(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateend : TriggerState {
            internal Stateend(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(arg1: 90000, arg2: "trigger", arg3: "Madracan03");
                context.SetAchievement(arg1: 90000, arg2: "trigger", arg3: "Madracan_Q03");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class Statequest_end : TriggerState {
            internal Statequest_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 510, arg3: "$52100042_QD__MAIN__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 510, arg3: "$52100042_QD__MAIN__1$", arg4: 2, arg5: 2);
                context.SetAchievement(arg1: 90000, arg2: "trigger", arg3: "Madracan_Q03");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestEnd_warp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd_warp : TriggerState {
            internal StateQuestEnd_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateQuestEnd_warp_End(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52100043, arg2: 0);
            }
        }

        private class StateQuestEnd_warp_End : TriggerState {
            internal StateQuestEnd_warp_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}