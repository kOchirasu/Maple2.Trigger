namespace Maple2.Trigger._02020031_bf {
    public static class _15000_minipuzzle_interactwithnpc {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
                context.EnableLocalCamera(isEnable: false);
                context.SetUserValue(key: "StandAsideTypeA", value: 0);
                context.SetUserValue(key: "StandAsideTypeB", value: 0);
                context.SetMesh(triggerIds: new []{15101, 15102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 15100, visible: false, initialSequence: "Idle_A");
                context.SetInteractObject(interactIds: new []{12000252, 12000078, 12000093}, state: 2);
                context.DestroyMonster(spawnIds: new []{15401, 15402, 15501, 15502});
                context.SetEffect(triggerIds: new []{15300, 15301, 15302, 15303, 15304}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "TimeEventOn") == 1) {
                    return new StateSettingDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.EnableLocalCamera(isEnable: true);
                    return new StateInteractWithNpc_NpcTypeRandomPick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeRandomPick : TriggerState {
            internal StateInteractWithNpc_NpcTypeRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{15101, 15002}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(triggerId: 15100, visible: true, initialSequence: "Idle_A");
                context.SetUserValue(triggerId: 15001, key: "PortalOn", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 50f)) {
                    return new StateInteractWithNpc_NpcTypeA_Setting(context);
                }

                if (context.RandomCondition(rate: 50f)) {
                    return new StateInteractWithNpc_NpcTypeB_Setting(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_Setting : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000078}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000078}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, clearAtZero: true, display: false, arg5: 0);
                    return new StateInteractWithNpc_NpcTypeA_NpcSpawn(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_NpcSpawn : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_NpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000078}, state: 2);
                context.CreateMonster(spawnIds: new []{15401}, arg2: true);
                context.SetUserValue(triggerId: 1000051, key: "NPCTalk", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StandAsideTypeA") == 1) {
                    context.SetUserValue(triggerId: 1000051, key: "NPCTalk", value: 0);
                    return new StateInteractWithNpc_NpcTypeA_NpcChange(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateInteractWithNpc_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_NpcChange : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_NpcChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{15300}, visible: false);
                context.DestroyMonster(spawnIds: new []{15401});
                context.CreateMonster(spawnIds: new []{15402}, arg2: true);
                context.SetUserValue(triggerId: 15001, key: "PortalOn", value: 2);
                context.SetMesh(triggerIds: new []{15101, 15102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(boxIds: new []{150001}, skillId: 71001052, level: 1, arg4: false, arg5: false);
                context.SetTimer(timerId: "10", seconds: 60, clearAtZero: true, display: false, arg5: 0);
                context.SetUserValue(triggerId: 151001, key: "NPCKill", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateInteractWithNpc_NpcTypeA_StandAside(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_StandAside : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_StandAside(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{15303}, visible: true);
                context.MoveNpc(spawnId: 15402, patrolName: "MS2PatrolData_15600");
            }

            public override TriggerState? Execute() {
                return new StateInteractWithNpc_Success(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_Setting : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000093}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000093}, arg2: 0)) {
                    context.SetTimer(timerId: "1", seconds: 120, clearAtZero: true, display: false, arg5: 0);
                    return new StateInteractWithNpc_NpcTypeB_NpcSpawn(context);
                }

                if (context.GetUserValue(key: "TimeEventOn") == 0) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_NpcSpawn : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_NpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000093}, state: 2);
                context.CreateMonster(spawnIds: new []{15501}, arg2: true);
                context.SetUserValue(triggerId: 1000052, key: "NPCTalk", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "StandAsideTypeB") == 1) {
                    context.SetUserValue(triggerId: 1000052, key: "NPCTalk", value: 0);
                    return new StateInteractWithNpc_NpcTypeB_NpcChange(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateInteractWithNpc_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_NpcChange : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_NpcChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{15300}, visible: false);
                context.DestroyMonster(spawnIds: new []{15501});
                context.CreateMonster(spawnIds: new []{15502}, arg2: true);
                context.SetUserValue(triggerId: 15001, key: "PortalOn", value: 2);
                context.SetMesh(triggerIds: new []{15101, 15102}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(boxIds: new []{150001}, skillId: 71001052, level: 1, arg4: false, arg5: false);
                context.SetTimer(timerId: "10", seconds: 60, clearAtZero: true, display: false, arg5: 0);
                context.SetUserValue(triggerId: 151001, key: "NPCKill", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateInteractWithNpc_NpcTypeB_StandAside(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_StandAside : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_StandAside(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{15304}, visible: true);
                context.MoveNpc(spawnId: 15502, patrolName: "MS2PatrolData_15600");
            }

            public override TriggerState? Execute() {
                return new StateInteractWithNpc_Success(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Success : TriggerState {
            internal StateInteractWithNpc_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 15000, key: "TimeEventOn", value: 0);
                context.SetActor(triggerId: 15100, visible: false, initialSequence: "Idle_A");
                context.SetEffect(triggerIds: new []{15300}, visible: true);
                context.SetInteractObject(interactIds: new []{12000252}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000252}, arg2: 0)) {
                    return new StateInteractWithNpc_SuccessDelay(context);
                }

                if (context.TimeExpired(timerId: "10")) {
                    return new StateInteractWithNpc_Fail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_SuccessDelay : TriggerState {
            internal StateInteractWithNpc_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateInteractWithNpc_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Fail : TriggerState {
            internal StateInteractWithNpc_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000251, 12000078, 12000093}, state: 2);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateInteractWithNpc_Quit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Quit : TriggerState {
            internal StateInteractWithNpc_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.ResetTimer(timerId: "10");
                context.SetUserValue(triggerId: 15001, key: "PortalOn", value: 0);
                context.DestroyMonster(spawnIds: new []{15401, 15402, 15501, 15502});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
