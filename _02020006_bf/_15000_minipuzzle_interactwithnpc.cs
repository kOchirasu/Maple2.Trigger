using System;

namespace Maple2.Trigger._02020006_bf {
    public static class _15000_minipuzzle_interactwithnpc {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "10");
                context.EnableLocalCamera(isEnable: false);
                context.SetUserValue(key: "StandAsideTypeA", value: 0);
                context.SetUserValue(key: "StandAsideTypeB", value: 0);
                context.SetMesh(arg1: new int[] {15101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {15102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 15100, arg2: false, arg3: "Idle_A");
                context.SetInteractObject(arg1: new int[] {12000250}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000078}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000093}, arg2: 2);
                context.DestroyMonster(arg1: new int[] {15401, 15402, 15501, 15502});
                context.SetEffect(arg1: new int[] {15300}, arg2: false);
                context.SetEffect(arg1: new int[] {15301}, arg2: false);
                context.SetEffect(arg1: new int[] {15302}, arg2: false);
                context.SetEffect(arg1: new int[] {15303}, arg2: false);
                context.SetEffect(arg1: new int[] {15304}, arg2: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "TimeEventOn", value: 1)) {
                    context.State = new StateSettingDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateSettingDelay : TriggerState {
            internal StateSettingDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.EnableLocalCamera(isEnable: true);
                    context.State = new StateInteractWithNpc_NpcTypeRandomPick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeRandomPick : TriggerState {
            internal StateInteractWithNpc_NpcTypeRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {15101}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {15002}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetActor(arg1: 15100, arg2: true, arg3: "Idle_A");
                context.SetUserValue(triggerID: 15001, key: "PortalOn", value: 1);
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateInteractWithNpc_NpcTypeA_Setting(context);
                    return;
                }

                if (context.RandomCondition(arg1: 50f)) {
                    context.State = new StateInteractWithNpc_NpcTypeB_Setting(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_Setting : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000078}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000078}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.State = new StateInteractWithNpc_NpcTypeA_NpcSpawn(context);
                    return;
                }

                if (context.UserValue(key: "TimeEventOn", value: 0)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_NpcSpawn : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_NpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000078}, arg2: 2);
                context.CreateMonster(arg1: new int[] {15401}, arg2: true);
                context.SetUserValue(triggerID: 1000051, key: "NPCTalk", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "StandAsideTypeA", value: 1)) {
                    context.SetUserValue(triggerID: 1000051, key: "NPCTalk", value: 0);
                    context.State = new StateInteractWithNpc_NpcTypeA_NpcChange(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateInteractWithNpc_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_NpcChange : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_NpcChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {15300}, arg2: false);
                context.DestroyMonster(arg1: new int[] {15401});
                context.CreateMonster(arg1: new int[] {15402}, arg2: true);
                context.SetUserValue(triggerID: 15001, key: "PortalOn", value: 2);
                context.SetMesh(arg1: new int[] {15101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {15102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(arg1: new int[] {150001}, arg2: 71001052, arg3: 1, arg4: false, arg5: false);
                context.SetTimer(arg1: "10", arg2: 60, arg3: true, arg4: false, arg5: 0);
                context.SetUserValue(triggerID: 151001, key: "NPCKill", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateInteractWithNpc_NpcTypeA_StandAside(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeA_StandAside : TriggerState {
            internal StateInteractWithNpc_NpcTypeA_StandAside(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {15303}, arg2: true);
                context.MoveNpc(arg1: 15402, arg2: "MS2PatrolData_15600");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateInteractWithNpc_Success(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_Setting : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_Setting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000093}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000093}, arg2: 0)) {
                    context.SetTimer(arg1: "1", arg2: 120, arg3: true, arg4: false, arg5: 0);
                    context.State = new StateInteractWithNpc_NpcTypeB_NpcSpawn(context);
                    return;
                }

                if (context.UserValue(key: "TimeEventOn", value: 0)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_NpcSpawn : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_NpcSpawn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000093}, arg2: 2);
                context.CreateMonster(arg1: new int[] {15501}, arg2: true);
                context.SetUserValue(triggerID: 1000052, key: "NPCTalk", value: 1);
            }

            public override void Execute() {
                if (context.UserValue(key: "StandAsideTypeB", value: 1)) {
                    context.SetUserValue(triggerID: 1000052, key: "NPCTalk", value: 0);
                    context.State = new StateInteractWithNpc_NpcTypeB_NpcChange(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateInteractWithNpc_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_NpcChange : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_NpcChange(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {15300}, arg2: false);
                context.DestroyMonster(arg1: new int[] {15501});
                context.CreateMonster(arg1: new int[] {15502}, arg2: true);
                context.SetUserValue(triggerID: 15001, key: "PortalOn", value: 2);
                context.SetMesh(arg1: new int[] {15101}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {15102}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.AddBuff(arg1: new int[] {150001}, arg2: 71001052, arg3: 1, arg4: false, arg5: false);
                context.SetTimer(arg1: "10", arg2: 60, arg3: true, arg4: false, arg5: 0);
                context.SetUserValue(triggerID: 151001, key: "NPCKill", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StateInteractWithNpc_NpcTypeB_StandAside(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_NpcTypeB_StandAside : TriggerState {
            internal StateInteractWithNpc_NpcTypeB_StandAside(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {15304}, arg2: true);
                context.MoveNpc(arg1: 15502, arg2: "MS2PatrolData_15600");
            }

            public override void Execute() {
                if (true) {
                    context.State = new StateInteractWithNpc_Success(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Success : TriggerState {
            internal StateInteractWithNpc_Success(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 15000, key: "TimeEventOn", value: 0);
                context.SetActor(arg1: 15100, arg2: false, arg3: "Idle_A");
                context.SetEffect(arg1: new int[] {15300}, arg2: true);
                context.SetInteractObject(arg1: new int[] {12000250}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000250}, arg2: 0)) {
                    context.State = new StateInteractWithNpc_SuccessDelay(context);
                    return;
                }

                if (context.TimeExpired(arg1: "10")) {
                    context.State = new StateInteractWithNpc_Fail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_SuccessDelay : TriggerState {
            internal StateInteractWithNpc_SuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateInteractWithNpc_Quit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Fail : TriggerState {
            internal StateInteractWithNpc_Fail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000250}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000078}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000093}, arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateInteractWithNpc_Quit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateInteractWithNpc_Quit : TriggerState {
            internal StateInteractWithNpc_Quit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.ResetTimer(arg1: "10");
                context.SetUserValue(triggerID: 15001, key: "PortalOn", value: 0);
                context.DestroyMonster(arg1: new int[] {15401, 15402, 15501, 15502});
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}