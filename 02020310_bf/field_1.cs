using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020310_bf {
    public static class _field_1 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000304, 12000305, 12000306}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_1(context);
                }

                if (context.GetUserValue(key: "Block") == 2) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_2(context);
                }

                if (context.GetUserValue(key: "Block") == 3) {
                    context.SetUserValue(triggerId: 900002, key: "Block", value: 0);
                    return new StateBlock_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_1 : TriggerState {
            internal StateBlock_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1104, 1150, 1151, 1152, 1157, 1158, 1159, 1160, 1161})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_normal", script: "$02020310_BF__FIELD_1__0$", duration: 5000);
                    context.SetInteractObject(interactIds: new []{12000304}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 30001, 30002, 30003, 30004}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 102, enabled: false);
                    context.EnableSpawnPointPc(spawnId: 103, enabled: true);
                    return new StateCableOn_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_2 : TriggerState {
            internal StateBlock_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1105, 1153, 1154, 1162, 1163, 1164, 1165, 1166})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_normal", script: "$02020310_BF__FIELD_1__1$", duration: 5000);
                    context.SetInteractObject(interactIds: new []{12000305}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 30001, 30002, 30003, 30004}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 102, enabled: false);
                    context.EnableSpawnPointPc(spawnId: 104, enabled: true);
                    return new StateCableOn_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBlock_3 : TriggerState {
            internal StateBlock_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1106, 1155, 1156, 1167, 1168, 1169, 1170, 1171, 1172})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_normal", script: "$02020310_BF__FIELD_1__2$", duration: 5000);
                    context.SetInteractObject(interactIds: new []{12000306}, state: 1);
                    context.CreateMonster(spawnIds: new []{1107, 1108, 1109, 1201, 1202, 1203, 1204, 1205, 1206, 1207, 1208, 1209, 1210, 1211, 1212, 1213, 1214, 1215, 1216, 1217, 1218, 1219, 1220, 1221, 1222, 1223, 1224, 30001, 30002, 30003, 30004}, arg2: false);
                    context.EnableSpawnPointPc(spawnId: 102, enabled: false);
                    context.EnableSpawnPointPc(spawnId: 105, enabled: true);
                    return new StateCableOn_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_04 : TriggerState {
            internal StateCableOn_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000304}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000304}, state: 0);
                    context.DestroyMonster(spawnIds: new []{30003, 30004}, arg2: false);
                    context.SetMesh(triggerIds: new []{1100101, 1100102, 1100103, 1100104, 1100105, 1100106, 1100107, 1100108, 1100109, 1100110}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_05 : TriggerState {
            internal StateCableOn_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000305}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000305}, state: 0);
                    context.DestroyMonster(spawnIds: new []{30001, 30002, 30004}, arg2: false);
                    context.SetMesh(triggerIds: new []{1100201, 1100202, 1100203, 1100204, 1100205, 1100206, 1100207, 1100208, 1100209, 1100210}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOn_06 : TriggerState {
            internal StateCableOn_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000306}, arg2: 0)) {
                    context.SetInteractObject(interactIds: new []{12000306}, state: 0);
                    context.DestroyMonster(spawnIds: new []{30001, 30002, 30003}, arg2: false);
                    context.SetMesh(triggerIds: new []{1100301, 1100302, 1100303, 1100304, 1100305, 1100306, 1100307, 1100308, 1100309, 1100310}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                    return new StateCableDelay_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04 : TriggerState {
            internal StateCableDelay_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__3$", duration: 3000);
                    return new StateCableDelay_04_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05 : TriggerState {
            internal StateCableDelay_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__4$", duration: 3000);
                    return new StateCableDelay_05_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06 : TriggerState {
            internal StateCableDelay_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__5$", duration: 3000);
                    return new StateCableDelay_06_2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_2 : TriggerState {
            internal StateCableDelay_04_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__6$", duration: 1000);
                    return new StateCableDelay_04_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_2 : TriggerState {
            internal StateCableDelay_05_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__7$", duration: 1000);
                    return new StateCableDelay_05_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06_2 : TriggerState {
            internal StateCableDelay_06_2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__8$", duration: 1000);
                    return new StateCableDelay_06_3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_3 : TriggerState {
            internal StateCableDelay_04_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__9$", duration: 1000);
                    return new StateCableDelay_04_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_3 : TriggerState {
            internal StateCableDelay_05_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__10$", duration: 1000);
                    return new StateCableDelay_05_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06_3 : TriggerState {
            internal StateCableDelay_06_3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__11$", duration: 1000);
                    return new StateCableDelay_06_4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_4 : TriggerState {
            internal StateCableDelay_04_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__12$", duration: 1000);
                    return new StateCableDelay_04_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_4 : TriggerState {
            internal StateCableDelay_05_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__13$", duration: 1000);
                    return new StateCableDelay_05_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06_4 : TriggerState {
            internal StateCableDelay_06_4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__14$", duration: 1000);
                    return new StateCableDelay_06_5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_04_5 : TriggerState {
            internal StateCableDelay_04_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1004}, enabled: true);
                    context.MoveNpc(spawnId: 30001, patrolName: "MS2PatrolData_101");
                    context.MoveNpc(spawnId: 30002, patrolName: "MS2PatrolData_102");
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__15$", duration: 5000);
                    return new StateCableOff_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_05_5 : TriggerState {
            internal StateCableDelay_05_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1005}, enabled: true);
                    context.MoveNpc(spawnId: 30003, patrolName: "MS2PatrolData_103");
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__16$", duration: 5000);
                    return new StateCableOff_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableDelay_06_5 : TriggerState {
            internal StateCableDelay_06_5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetBreakable(triggerIds: new []{1006}, enabled: true);
                    context.MoveNpc(spawnId: 30004, patrolName: "MS2PatrolData_104");
                    context.SetEventUI(arg1: 1, script: "$02020310_BF__FIELD_1__17$", duration: 5000);
                    return new StateCableOff_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_04 : TriggerState {
            internal StateCableOff_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetMesh(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMeshAnimation(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0);
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 1);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_05 : TriggerState {
            internal StateCableOff_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetMesh(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMeshAnimation(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0);
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 2);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCableOff_06 : TriggerState {
            internal StateCableOff_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.SetMesh(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                    context.SetMeshAnimation(triggerIds: new []{1100001, 1100002, 1100003, 1100004, 1100005, 1100006, 1100007, 1100008, 1100009, 1100010, 1100021, 1100022, 1100023, 1100024, 1100025, 1100026, 1100027, 1100028, 1100029, 1100030, 1100031, 1100032, 1100033, 1100034, 1100035, 1100036, 1100037, 1100038, 1100039, 1100040}, visible: true, arg3: 0, arg4: 0);
                    context.SetUserValue(triggerId: 900003, key: "Block", value: 3);
                    return new StateEnd_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd_01 : TriggerState {
            internal StateEnd_01(ITriggerContext context) : base(context) { }

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
