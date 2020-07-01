namespace Maple2.Trigger._52100302_qd {
    public static class _field_2 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000507, 12000508, 12000509, 12000510, 12000511, 12000512}, arg2: 2);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    return new StateArriveBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    return new StateArriveBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 0);
                    return new StateArriveBlock_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_1 : TriggerState {
            internal StateArriveBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.CreateMonster(arg1: new[] {2001}, arg2: false);
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
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__0$", duration: 3000);
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__1$", duration: 4000);
                    return new StateBlock_1_01(context);
                }

                if (context.MonsterDead(arg1: new[] {1107, 1203, 1204, 1213, 1214, 1215, 1216, 1217, 1218})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000001}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000002}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 103, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: true);
                    return new StateCableOn_07_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_01 : TriggerState {
            internal StateBlock_1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000001}, arg2: false);
                    return new StateBlock_1_02(context);
                }

                if (context.MonsterDead(arg1: new[] {1107, 1203, 1204, 1213, 1214, 1215, 1216, 1217, 1218})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000001}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000002}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 103, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: true);
                    return new StateCableOn_07_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_02 : TriggerState {
            internal StateBlock_1_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000002}, arg2: false);
                    return new StateBlock_1(context);
                }

                if (context.MonsterDead(arg1: new[] {1107, 1203, 1204, 1213, 1214, 1215, 1216, 1217, 1218})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000001}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000002}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 103, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: true);
                    return new StateCableOn_07_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1107, 1203, 1204, 1213, 1214, 1215, 1216, 1217, 1218})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000001}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000002}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 103, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 106, isEnable: true);
                    return new StateCableOn_07_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_2 : TriggerState {
            internal StateArriveBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9002})) {
                    context.CreateMonster(arg1: new[] {2002}, arg2: false);
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
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__2$", duration: 3000);
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__3$", duration: 4000);
                    return new StateBlock_2_01(context);
                }

                if (context.MonsterDead(arg1: new[] {1108, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000003}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000004}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 104, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: true);
                    return new StateCableOn_09_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_01 : TriggerState {
            internal StateBlock_2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000003}, arg2: false);
                    return new StateBlock_2_02(context);
                }

                if (context.MonsterDead(arg1: new[] {1108, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000003}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000004}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 104, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: true);
                    return new StateCableOn_09_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_02 : TriggerState {
            internal StateBlock_2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000004}, arg2: false);
                    return new StateBlock_2(context);
                }

                if (context.MonsterDead(arg1: new[] {1108, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000003}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000004}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 104, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: true);
                    return new StateCableOn_09_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1108, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000003}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000004}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 104, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 107, isEnable: true);
                    return new StateCableOn_09_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_3 : TriggerState {
            internal StateArriveBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9003})) {
                    context.CreateMonster(arg1: new[] {2003}, arg2: false);
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
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__4$", duration: 3000);
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_2__5$", duration: 4000);
                    return new StateBlock_3_01(context);
                }

                if (context.MonsterDead(arg1: new[] {1109, 1201, 1202, 1219, 1220, 1221, 1222, 1223, 1224})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000005}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000006}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 105, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: true);
                    return new StateCableOn_11_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_01 : TriggerState {
            internal StateBlock_3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000005}, arg2: false);
                    return new StateBlock_3_02(context);
                }

                if (context.MonsterDead(arg1: new[] {1109, 1201, 1202, 1219, 1220, 1221, 1222, 1223, 1224})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000005}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000006}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 105, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: true);
                    return new StateCableOn_11_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_02 : TriggerState {
            internal StateBlock_3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000006}, arg2: false);
                    return new StateBlock_3(context);
                }

                if (context.MonsterDead(arg1: new[] {1109, 1201, 1202, 1219, 1220, 1221, 1222, 1223, 1224})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000005}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000006}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 105, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: true);
                    return new StateCableOn_11_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1109, 1201, 1202, 1219, 1220, 1221, 1222, 1223, 1224})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000005}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000006}, arg2: false);
                    context.DestroyMonster(arg1: new[] {30001, 30002, 30003, 30004}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1110, 1111, 1112, 1113, 1301, 1302, 1304, 1305, 1306, 1307, 1308, 1309, 1310, 1311, 1312, 1314, 1315, 1316, 1317, 1318, 1319, 1320, 1321, 1322, 1324, 1325, 1326, 1327, 1328, 1329, 1330, 1331, 1332}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 105, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 108, isEnable: true);
                    return new StateCableOn_11_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_07_08 : TriggerState {
            internal StateCableOn_07_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000507}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30005}, arg2: false);
                    context.SetMesh(arg1: new[] {1101001, 1101002, 1101003, 1101004, 1101005, 1101006, 1101007, 1101008, 1101009, 1101010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_07(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000508}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000507, 12000508}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30006, 30007}, arg2: false);
                    context.SetMesh(arg1: new[] {1102001, 1102002, 1102003, 1102004, 1102005, 1102006, 1102007, 1102008, 1102009, 1102010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_09_10 : TriggerState {
            internal StateCableOn_09_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000509}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30008}, arg2: false);
                    context.SetMesh(arg1: new[] {1103001, 1103002, 1103003, 1103004, 1103005, 1103006, 1103007, 1103008, 1103009, 1103010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_09(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000510}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000509, 12000510}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30009}, arg2: false);
                    context.SetMesh(arg1: new[] {1104001, 1104002, 1104003, 1104004, 1104005, 1104006, 1104007, 1104008, 1104009, 1104010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_11_12 : TriggerState {
            internal StateCableOn_11_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000511}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30010, 30011}, arg2: false);
                    context.SetMesh(arg1: new[] {1105001, 1105002, 1105003, 1105004, 1105005, 1105006, 1105007, 1105008, 1105009, 1105010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_11(context);
                }

                if (context.ObjectInteracted(arg1: new[] {12000512}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000511, 12000512}, arg2: 0);
                    context.CreateMonster(arg1: new[] {30012}, arg2: false);
                    context.SetMesh(arg1: new[] {1106001, 1106002, 1106003, 1106004, 1106005, 1106006, 1106007, 1106008, 1106009, 1106010}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07 : TriggerState {
            internal StateCableDelay_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__6$", arg3: 3000);
                    return new StateCableDelay_07_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08 : TriggerState {
            internal StateCableDelay_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__7$", arg3: 3000);
                    return new StateCableDelay_08_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09 : TriggerState {
            internal StateCableDelay_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__8$", arg3: 3000);
                    return new StateCableDelay_09_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10 : TriggerState {
            internal StateCableDelay_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__9$", arg3: 3000);
                    return new StateCableDelay_10_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11 : TriggerState {
            internal StateCableDelay_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__10$", arg3: 3000);
                    return new StateCableDelay_11_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12 : TriggerState {
            internal StateCableDelay_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__11$", arg3: 3000);
                    return new StateCableDelay_12_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07_2 : TriggerState {
            internal StateCableDelay_07_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__12$", arg3: 1000);
                    return new StateCableDelay_07_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08_2 : TriggerState {
            internal StateCableDelay_08_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__13$", arg3: 1000);
                    return new StateCableDelay_08_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09_2 : TriggerState {
            internal StateCableDelay_09_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__14$", arg3: 1000);
                    return new StateCableDelay_09_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10_2 : TriggerState {
            internal StateCableDelay_10_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__15$", arg3: 1000);
                    return new StateCableDelay_10_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11_2 : TriggerState {
            internal StateCableDelay_11_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__16$", arg3: 1000);
                    return new StateCableDelay_11_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12_2 : TriggerState {
            internal StateCableDelay_12_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__17$", arg3: 1000);
                    return new StateCableDelay_12_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07_3 : TriggerState {
            internal StateCableDelay_07_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__18$", arg3: 1000);
                    return new StateCableDelay_07_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08_3 : TriggerState {
            internal StateCableDelay_08_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__19$", arg3: 1000);
                    return new StateCableDelay_08_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09_3 : TriggerState {
            internal StateCableDelay_09_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__20$", arg3: 1000);
                    return new StateCableDelay_09_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10_3 : TriggerState {
            internal StateCableDelay_10_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__21$", arg3: 1000);
                    return new StateCableDelay_10_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11_3 : TriggerState {
            internal StateCableDelay_11_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__22$", arg3: 1000);
                    return new StateCableDelay_11_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12_3 : TriggerState {
            internal StateCableDelay_12_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__23$", arg3: 1000);
                    return new StateCableDelay_12_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07_4 : TriggerState {
            internal StateCableDelay_07_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__24$", arg3: 1000);
                    return new StateCableDelay_07_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08_4 : TriggerState {
            internal StateCableDelay_08_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__25$", arg3: 1000);
                    return new StateCableDelay_08_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09_4 : TriggerState {
            internal StateCableDelay_09_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__26$", arg3: 1000);
                    return new StateCableDelay_09_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10_4 : TriggerState {
            internal StateCableDelay_10_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__27$", arg3: 1000);
                    return new StateCableDelay_10_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11_4 : TriggerState {
            internal StateCableDelay_11_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveNpc(arg1: 30010, arg2: "MS2PatrolData_110");
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__28$", arg3: 1000);
                    return new StateCableDelay_11_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12_4 : TriggerState {
            internal StateCableDelay_12_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$52100302_QD__FIELD_2__29$", arg3: 1000);
                    return new StateCableDelay_12_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_07_5 : TriggerState {
            internal StateCableDelay_07_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__30$", duration: 6000);
                    context.MoveNpc(arg1: 30005, arg2: "MS2PatrolData_105");
                    context.SetBreakable(arg1: new[] {1007}, arg2: true);
                    return new StateCableOff_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_08_5 : TriggerState {
            internal StateCableDelay_08_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__31$", duration: 6000);
                    context.MoveNpc(arg1: 30006, arg2: "MS2PatrolData_106");
                    context.MoveNpc(arg1: 30007, arg2: "MS2PatrolData_107");
                    context.SetBreakable(arg1: new[] {1008}, arg2: true);
                    return new StateCableOff_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_09_5 : TriggerState {
            internal StateCableDelay_09_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__32$", duration: 6000);
                    context.MoveNpc(arg1: 30008, arg2: "MS2PatrolData_108");
                    context.SetBreakable(arg1: new[] {1009}, arg2: true);
                    return new StateCableOff_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_10_5 : TriggerState {
            internal StateCableDelay_10_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__33$", duration: 6000);
                    context.MoveNpc(arg1: 30009, arg2: "MS2PatrolData_109");
                    context.SetBreakable(arg1: new[] {1010}, arg2: true);
                    return new StateCableOff_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_11_5 : TriggerState {
            internal StateCableDelay_11_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__34$", duration: 6000);
                    context.MoveNpc(arg1: 30011, arg2: "MS2PatrolData_111");
                    context.MoveNpc(arg1: 30011, arg2: "MS2PatrolData_111");
                    context.SetBreakable(arg1: new[] {1011}, arg2: true);
                    return new StateCableOff_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_12_5 : TriggerState {
            internal StateCableDelay_12_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_normal", script: "$52100302_QD__FIELD_2__35$", duration: 6000);
                    context.MoveNpc(arg1: 30012, arg2: "MS2PatrolData_112");
                    context.SetBreakable(arg1: new[] {1012}, arg2: true);
                    return new StateCableOff_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_07 : TriggerState {
            internal StateCableOff_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_08 : TriggerState {
            internal StateCableOff_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_09 : TriggerState {
            internal StateCableOff_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 2);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_10 : TriggerState {
            internal StateCableOff_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 3);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_11 : TriggerState {
            internal StateCableOff_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 4);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_12 : TriggerState {
            internal StateCableOff_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900004, key: "Block", value: 1);
                    return new StateEnd_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_02 : TriggerState {
            internal StateEnd_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}