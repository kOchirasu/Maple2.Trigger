namespace Maple2.Trigger._02000384_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{6001, 6002, 6003, 6004}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{701})) {
                    return new StateRoomCheck(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoomCheck : TriggerState {
            internal StateRoomCheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateLevelcheck(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuest_raid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLevelcheck : TriggerState {
            internal StateLevelcheck(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetDungeonLevel() == 2) {
                    return new StateRaid(context);
                }

                if (context.GetDungeonLevel() == 3) {
                    return new StateChaos_raid(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRaid : TriggerState {
            internal StateRaid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChaos_raid : TriggerState {
            internal StateChaos_raid(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{402}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_raid : TriggerState {
            internal StateQuest_raid(ITriggerContext context) : base(context) { }

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
                context.CreateMonster(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 511, 403}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    return new StateQuest_end(context);
                }

                if (context.UserDetected(boxIds: new []{720})) {
                    return new StateNpcSpawn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpcSpawn : TriggerState {
            internal StateNpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{510}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "ExitPortal") == 1) {
                    return new StateQuest_end(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
                context.SetAchievement(triggerId: 90000, type: "trigger", code: "Madracan03");
                context.SetAchievement(triggerId: 90000, type: "trigger", code: "Madracan_Q03");
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest_end : TriggerState {
            internal StateQuest_end(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 7, script: "$02000384_BF__MAIN__0$", duration: 5000, boxId: 0);
                context.SetConversation(type: 1, spawnId: 510, script: "$02000384_BF__MAIN__1$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 510, script: "$02000384_BF__MAIN__2$", arg4: 2, arg5: 2);
                context.SetAchievement(triggerId: 90000, type: "trigger", code: "Madracan_Q03");
                context.SetPortal(portalId: 4, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
