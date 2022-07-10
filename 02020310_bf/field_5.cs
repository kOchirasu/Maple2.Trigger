using Maple2.Trigger.Enum;

namespace Maple2.Trigger._02020310_bf {
    public static class _field_5 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000322}, state: 2);
                context.SetInteractObject(interactIds: new []{12000400, 12000401, 12000402, 12000403}, state: 0);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Block") == 1) {
                    context.SetUserValue(triggerId: 900006, key: "Block", value: 0);
                    return new StateArcheon_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Ready : TriggerState {
            internal StateArcheon_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004607, illust: "Neirin_normal", script: "$02020310_BF__FIELD_5__0$", duration: 5000);
                    context.SetInteractObject(interactIds: new []{12000400, 12000401, 12000402, 12000403}, state: 1);
                    context.EnableSpawnPointPc(spawnId: 113, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 114, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 115, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 116, isEnable: true);
                    return new StateArcheon_On(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000400, 12000401, 12000402, 12000403}, arg2: 0)) {
                    return new StateArcheon_Move1_0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Move1_0 : TriggerState {
            internal StateArcheon_Move1_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetPortal(portalId: 10001, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10002, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10003, visible: false, enabled: true, minimapVisible: false);
                    context.SetPortal(portalId: 10004, visible: false, enabled: true, minimapVisible: false);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_01", patrolIndex: 1, additionalEffectId: 73000005);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_02", patrolIndex: 2, additionalEffectId: 73000006);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_03", patrolIndex: 3, additionalEffectId: 73000007);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_04", patrolIndex: 4, additionalEffectId: 73000008);
                    context.CreateMonster(spawnIds: new []{10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028, 11029}, arg2: false);
                    return new StateArcheon_Arrive(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Arrive : TriggerState {
            internal StateArcheon_Arrive(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$02020310_BF__FIELD_5__1$", duration: 6500);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029, 11001, 11002, 11003, 11004, 11005, 11006, 11007, 11008, 11009, 11010, 11011, 11012, 11013, 11014, 11015, 11016, 11017, 11018, 11019, 11020, 11021, 11022, 11023, 11024, 11025, 11026, 11027, 11028, 11029})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$02020310_BF__FIELD_5__2$", duration: 5000);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_05", patrolIndex: 5, additionalEffectId: 73000005);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_06", patrolIndex: 6, additionalEffectId: 73000006);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_07", patrolIndex: 7, additionalEffectId: 73000007);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_08", patrolIndex: 8, additionalEffectId: 73000008);
                    context.EnableSpawnPointPc(spawnId: 116, isEnable: false);
                    context.EnableSpawnPointPc(spawnId: 117, isEnable: true);
                    context.SetPortal(portalId: 10000, visible: true, enabled: true, minimapVisible: true);
                    return new StateArcheon_Move2_1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Move2_1 : TriggerState {
            internal StateArcheon_Move2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(portalId: 10005, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10006, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10007, visible: false, enabled: true, minimapVisible: false);
                    context.SetPortal(portalId: 10008, visible: false, enabled: true, minimapVisible: false);
                    return new StateArcheon_Leave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Leave : TriggerState {
            internal StateArcheon_Leave(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9100})) {
                    return new StateArcheon_OffDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_OffDelay : TriggerState {
            internal StateArcheon_OffDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateArcheon_Off(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Off : TriggerState {
            internal StateArcheon_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9100}, skillId: 73000009, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateArcheon_OffDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
