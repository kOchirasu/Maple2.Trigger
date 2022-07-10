using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100302_qd {
    public static class _field_4 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000519, 12000520, 12000521}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    return new StateArriveBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    return new StateArriveBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900005, key: "Block", value: 0);
                    return new StateArriveBlock_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_1 : TriggerState {
            internal StateArriveBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9008})) {
                    context.CreateMonster(spawnIds: new []{2008}, arg2: false);
                    return new StateArriveBlock_Delay_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_1 : TriggerState {
            internal StateArriveBlock_Delay_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlock_1_01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000007}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000008}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000519}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 113, isEnable: true);
                    return new StateCableOn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_01 : TriggerState {
            internal StateBlock_1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(spawnIds: new []{1000007}, arg2: false);
                    return new StateBlock_1_02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000007}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000008}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000519}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 113, isEnable: true);
                    return new StateCableOn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1_02 : TriggerState {
            internal StateBlock_1_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(spawnIds: new []{1000008}, arg2: false);
                    return new StateBlock_1(context);
                }

                if (context.MonsterDead(spawnIds: new []{1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000007}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000008}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000519}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 113, isEnable: true);
                    return new StateCableOn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1114, 1401, 1402, 1407, 1408, 1409, 1410, 1411, 1412, 1413, 1414, 1415})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000007}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000008}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000519}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 109, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 113, isEnable: true);
                    return new StateCableOn_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_2 : TriggerState {
            internal StateArriveBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9009})) {
                    context.CreateMonster(spawnIds: new []{2009}, arg2: false);
                    return new StateArriveBlock_Delay_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_2 : TriggerState {
            internal StateArriveBlock_Delay_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlock_2_01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000009}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000010}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000520}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 114, isEnable: true);
                    return new StateCableOn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_01 : TriggerState {
            internal StateBlock_2_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(spawnIds: new []{1000009}, arg2: false);
                    return new StateBlock_2_02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000009}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000010}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000520}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 114, isEnable: true);
                    return new StateCableOn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2_02 : TriggerState {
            internal StateBlock_2_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(spawnIds: new []{1000010}, arg2: false);
                    return new StateBlock_2(context);
                }

                if (context.MonsterDead(spawnIds: new []{1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000009}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000010}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000520}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 114, isEnable: true);
                    return new StateCableOn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1115, 1403, 1404, 1424, 1425, 1426, 1427, 1428, 1429, 1430})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000009}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000010}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000520}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 110, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 111, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 114, isEnable: true);
                    return new StateCableOn_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_3 : TriggerState {
            internal StateArriveBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9010})) {
                    context.CreateMonster(spawnIds: new []{2010}, arg2: false);
                    return new StateArriveBlock_Delay_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArriveBlock_Delay_3 : TriggerState {
            internal StateArriveBlock_Delay_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateBlock_3_01(context);
                }

                if (context.MonsterDead(spawnIds: new []{1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000011}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000012}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000521}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 115, isEnable: true);
                    return new StateCableOn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_01 : TriggerState {
            internal StateBlock_3_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5167)) {
                    context.CreateMonster(spawnIds: new []{1000011}, arg2: false);
                    return new StateBlock_3_02(context);
                }

                if (context.MonsterDead(spawnIds: new []{1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000011}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000012}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000521}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 115, isEnable: true);
                    return new StateCableOn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3_02 : TriggerState {
            internal StateBlock_3_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4067)) {
                    context.CreateMonster(spawnIds: new []{1000012}, arg2: false);
                    return new StateBlock_3(context);
                }

                if (context.MonsterDead(spawnIds: new []{1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000011}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000012}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000521}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 115, isEnable: true);
                    return new StateCableOn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1116, 1405, 1406, 1416, 1417, 1418, 1419, 1420, 1421, 1422, 1423})) {
                    context.SetAiExtraData(key: "BossDie", value: 2);
                    context.DestroyMonster(spawnIds: new []{1000011}, arg2: false);
                    context.DestroyMonster(spawnIds: new []{1000012}, arg2: false);
                    context.SetInteractObject(interactIds: new []{12000521}, state: 1);
                    context.CreateMonster(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 112, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 115, isEnable: true);
                    return new StateCableOn_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_19 : TriggerState {
            internal StateCableOn_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000519}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000519}, state: 0);
                    context.SetMesh(triggerIds: new []{1210001, 1210002, 1210003, 1210004, 1210005, 1210006, 1210007, 1210008, 1210009, 1210010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_20 : TriggerState {
            internal StateCableOn_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000520}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000520}, state: 0);
                    context.SetMesh(triggerIds: new []{1310001, 1310002, 1310003, 1310004, 1310005, 1310006, 1310007, 1310008, 1310009, 1310010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_21 : TriggerState {
            internal StateCableOn_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000521}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000521}, state: 0);
                    context.SetMesh(triggerIds: new []{1410001, 1410002, 1410003, 1410004, 1410005, 1410006, 1410007, 1410008, 1410009, 1410010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19 : TriggerState {
            internal StateCableDelay_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__0$", duration: 3000);
                    return new StateCableDelay_19_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20 : TriggerState {
            internal StateCableDelay_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__1$", duration: 3000);
                    return new StateCableDelay_20_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21 : TriggerState {
            internal StateCableDelay_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__2$", duration: 3000);
                    return new StateCableDelay_21_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_2 : TriggerState {
            internal StateCableDelay_19_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__3$", duration: 1000);
                    return new StateCableDelay_19_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_2 : TriggerState {
            internal StateCableDelay_20_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__4$", duration: 1000);
                    return new StateCableDelay_20_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_2 : TriggerState {
            internal StateCableDelay_21_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__5$", duration: 1000);
                    return new StateCableDelay_21_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_3 : TriggerState {
            internal StateCableDelay_19_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__6$", duration: 1000);
                    return new StateCableDelay_19_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_3 : TriggerState {
            internal StateCableDelay_20_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__7$", duration: 1000);
                    return new StateCableDelay_20_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_3 : TriggerState {
            internal StateCableDelay_21_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__8$", duration: 1000);
                    return new StateCableDelay_21_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_4 : TriggerState {
            internal StateCableDelay_19_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__9$", duration: 1000);
                    return new StateCableDelay_19_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_4 : TriggerState {
            internal StateCableDelay_20_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__10$", duration: 1000);
                    return new StateCableDelay_20_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_4 : TriggerState {
            internal StateCableDelay_21_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$52100302_QD__FIELD_4__11$", duration: 1000);
                    return new StateCableDelay_21_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_19_5 : TriggerState {
            internal StateCableDelay_19_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_4__12$", duration: 5000);
                    context.SetBreakable(triggerIds: new []{1019}, enabled: true);
                    return new StateCableOff_19(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_20_5 : TriggerState {
            internal StateCableDelay_20_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_4__13$", duration: 5000);
                    context.SetBreakable(triggerIds: new []{1020}, enabled: true);
                    return new StateCableOff_20(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_21_5 : TriggerState {
            internal StateCableDelay_21_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_4__14$", duration: 5000);
                    context.SetBreakable(triggerIds: new []{1021}, enabled: true);
                    return new StateCableOff_21(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_19 : TriggerState {
            internal StateCableOff_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_20 : TriggerState {
            internal StateCableOff_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_21 : TriggerState {
            internal StateCableOff_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 1);
                    return new StateEnd_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_04 : TriggerState {
            internal StateEnd_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
