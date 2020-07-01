namespace Maple2.Trigger._02020310_bf {
    public static class _field_4 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000319}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000320}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000321}, arg2: 2);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    context.State = new StateArriveBlock_1(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    context.State = new StateArriveBlock_2(context);
                    return;
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    context.State = new StateArriveBlock_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_1 : TriggerState {
            internal StateArriveBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9008})) {
                    context.CreateMonster(arg1: new[] {2008}, arg2: false);
                    context.State = new StateArriveBlock_Delay_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_1 : TriggerState {
            internal StateArriveBlock_Delay_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlock_1_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000007}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000008}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 113, isEnable: true);
                    context.State = new StateCableOn_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_01 : TriggerState {
            internal StateBlock_1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000007}, arg2: false);
                    context.State = new StateBlock_1_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000007}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000008}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 113, isEnable: true);
                    context.State = new StateCableOn_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_02 : TriggerState {
            internal StateBlock_1_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000008}, arg2: false);
                    context.State = new StateBlock_1(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000007}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000008}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 113, isEnable: true);
                    context.State = new StateCableOn_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[]
                    {1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000007}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000008}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 113, isEnable: true);
                    context.State = new StateCableOn_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_2 : TriggerState {
            internal StateArriveBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9009})) {
                    context.CreateMonster(arg1: new[] {2009}, arg2: false);
                    context.State = new StateArriveBlock_Delay_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_2 : TriggerState {
            internal StateArriveBlock_Delay_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlock_2_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000009}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000010}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 114, isEnable: true);
                    context.State = new StateCableOn_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_01 : TriggerState {
            internal StateBlock_2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000009}, arg2: false);
                    context.State = new StateBlock_2_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000009}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000010}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 114, isEnable: true);
                    context.State = new StateCableOn_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_02 : TriggerState {
            internal StateBlock_2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000010}, arg2: false);
                    context.State = new StateBlock_2(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[] {1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000009}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000010}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 114, isEnable: true);
                    context.State = new StateCableOn_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[] {1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000009}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000010}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 114, isEnable: true);
                    context.State = new StateCableOn_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_3 : TriggerState {
            internal StateArriveBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9010})) {
                    context.CreateMonster(arg1: new[] {2010}, arg2: false);
                    context.State = new StateArriveBlock_Delay_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_3 : TriggerState {
            internal StateArriveBlock_Delay_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateBlock_3_01(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000011}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000012}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000321}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 115, isEnable: true);
                    context.State = new StateCableOn_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_01 : TriggerState {
            internal StateBlock_3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(arg1: new[] {1000011}, arg2: false);
                    context.State = new StateBlock_3_02(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000011}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000012}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000321}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 115, isEnable: true);
                    context.State = new StateCableOn_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_02 : TriggerState {
            internal StateBlock_3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(arg1: new[] {1000012}, arg2: false);
                    context.State = new StateBlock_3(context);
                    return;
                }

                if (context.MonsterDead(arg1: new[]
                    {1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000011}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000012}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000321}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 115, isEnable: true);
                    context.State = new StateCableOn_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new[]
                    {1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(arg1: new[] {1000011}, arg2: false);
                    context.DestroyMonster(arg1: new[] {1000012}, arg2: false);
                    context.SetInteractObject(arg1: new[] {12000321}, arg2: 1);
                    context.CreateMonster(arg1: new[] {1117}, arg2: false);
                    context.CreateMonster(arg1: new[] {1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510},
                        arg2: false);
                    context.CreateMonster(arg1: new[] {1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnPointId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 115, isEnable: true);
                    context.State = new StateCableOn_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_19 : TriggerState {
            internal StateCableOn_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000319}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000319}, arg2: 0);
                    context.SetMesh(
                        arg1: new[]
                            {1210001, 1210002, 1210003, 1210004, 1210005, 1210006, 1210007, 1210008, 1210009, 1210010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_20 : TriggerState {
            internal StateCableOn_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000320}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000320}, arg2: 0);
                    context.SetMesh(
                        arg1: new[]
                            {1310001, 1310002, 1310003, 1310004, 1310005, 1310006, 1310007, 1310008, 1310009, 1310010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOn_21 : TriggerState {
            internal StateCableOn_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000321}, arg2: 0)) {
                    context.SetInteractObject(arg1: new[] {12000321}, arg2: 0);
                    context.SetMesh(
                        arg1: new[]
                            {1410001, 1410002, 1410003, 1410004, 1410005, 1410006, 1410007, 1410008, 1410009, 1410010},
                        arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                    context.State = new StateCableDelay_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19 : TriggerState {
            internal StateCableDelay_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__0$", arg3: 3000);
                    context.State = new StateCableDelay_19_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20 : TriggerState {
            internal StateCableDelay_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__1$", arg3: 3000);
                    context.State = new StateCableDelay_20_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21 : TriggerState {
            internal StateCableDelay_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__2$", arg3: 3000);
                    context.State = new StateCableDelay_21_2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_2 : TriggerState {
            internal StateCableDelay_19_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__3$", arg3: 1000);
                    context.State = new StateCableDelay_19_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_2 : TriggerState {
            internal StateCableDelay_20_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__4$", arg3: 1000);
                    context.State = new StateCableDelay_20_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_2 : TriggerState {
            internal StateCableDelay_21_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__5$", arg3: 1000);
                    context.State = new StateCableDelay_21_3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_3 : TriggerState {
            internal StateCableDelay_19_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__6$", arg3: 1000);
                    context.State = new StateCableDelay_19_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_3 : TriggerState {
            internal StateCableDelay_20_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__7$", arg3: 1000);
                    context.State = new StateCableDelay_20_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_3 : TriggerState {
            internal StateCableDelay_21_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__8$", arg3: 1000);
                    context.State = new StateCableDelay_21_4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_4 : TriggerState {
            internal StateCableDelay_19_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__9$", arg3: 1000);
                    context.State = new StateCableDelay_19_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_4 : TriggerState {
            internal StateCableDelay_20_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__10$", arg3: 1000);
                    context.State = new StateCableDelay_20_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_4 : TriggerState {
            internal StateCableDelay_21_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, arg2: "$02020310_BF__FIELD_4__11$", arg3: 1000);
                    context.State = new StateCableDelay_21_5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_5 : TriggerState {
            internal StateCableDelay_19_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious",
                        script: "$02020310_BF__FIELD_4__12$", duration: 5000);
                    context.SetBreakable(arg1: new[] {1019}, arg2: true);
                    context.State = new StateCableOff_19(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_5 : TriggerState {
            internal StateCableDelay_20_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious",
                        script: "$02020310_BF__FIELD_4__13$", duration: 5000);
                    context.SetBreakable(arg1: new[] {1020}, arg2: true);
                    context.State = new StateCableOff_20(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_5 : TriggerState {
            internal StateCableDelay_21_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: "talk", npcId: 11004582, illust: "Eone_serious",
                        script: "$02020310_BF__FIELD_4__14$", duration: 5000);
                    context.SetBreakable(arg1: new[] {1021}, arg2: true);
                    context.State = new StateCableOff_21(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_19 : TriggerState {
            internal StateCableOff_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_20 : TriggerState {
            internal StateCableOff_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCableOff_21 : TriggerState {
            internal StateCableOff_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    context.State = new StateEnd_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd_04 : TriggerState {
            internal StateEnd_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}