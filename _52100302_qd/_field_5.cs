using System;

namespace Maple2.Trigger._52100302_qd {
    public static class _field_5 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {12000322}, arg2: 2);
                context.SetInteractObject(arg1: new int[] {12000600}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {12000601}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {12000602}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {12000603}, arg2: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Block", value: 1)) {
                    context.SetUserValue(triggerID: 900006, key: "Block", value: 0);
                    context.State = new StateArcheon_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Ready : TriggerState {
            internal StateArcheon_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[]
                    {1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513})) {
                    context.SideNpcTalk(type: "talk", npcID: 11004607, illust: "Neirin_normal",
                        script: "$52100302_QD__FIELD_5__0$", duration: 5000);
                    context.SetInteractObject(arg1: new int[] {12000600}, arg2: 1);
                    context.EnableSpawnPointPc(spawnPointID: 113, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 114, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 115, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 116, isEnable: true);
                    context.State = new StateArcheon_On(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {12000600}, arg2: 0)) {
                    context.State = new StateArcheon_Move1_0(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Move1_0 : TriggerState {
            internal StateArcheon_Move1_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetPortal(arg1: 10001, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 10003, arg2: false, arg3: true, arg4: false);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_01", patrolIndex: 1,
                        additionalEffectID: 73000005);
                    context.CreateMonster(
                        arg1: new int[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010},
                        agr2: false);
                    context.CreateMonster(
                        arg1: new int[] {10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020},
                        agr2: false);
                    context.CreateMonster(
                        arg1: new int[] {10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029}, agr2: false);
                    context.State = new StateArcheon_Arrive(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Arrive : TriggerState {
            internal StateArcheon_Arrive(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: "talk", npcID: 11004582, illust: "Eone_serious",
                    script: "$52100302_QD__FIELD_5__1$", duration: 6500);
            }

            public override void Execute() {
                if (context.MonsterDead(arg1: new int[] {
                    10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014,
                    10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028,
                    10029
                })) {
                    context.SideNpcTalk(type: "talk", npcID: 11004582, illust: "Eone_serious",
                        script: "$52100302_QD__FIELD_5__2$", duration: 5000);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_05", patrolIndex: 5,
                        additionalEffectID: 73000005);
                    context.EnableSpawnPointPc(spawnPointID: 116, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointID: 117, isEnable: true);
                    context.SetPortal(arg1: 10000, arg2: true, arg3: true, arg4: true);
                    context.State = new StateArcheon_Move2_1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Move2_1 : TriggerState {
            internal StateArcheon_Move2_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(arg1: 10005, arg2: true, arg3: true, arg4: true);
                    context.SetPortal(arg1: 10007, arg2: false, arg3: true, arg4: false);
                    context.State = new StateArcheon_Leave(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Leave : TriggerState {
            internal StateArcheon_Leave(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9100")) {
                    context.State = new StateArcheon_OffDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_OffDelay : TriggerState {
            internal StateArcheon_OffDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new StateArcheon_Off(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Off : TriggerState {
            internal StateArcheon_Off(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {9100}, arg2: 73000009, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State마를레네_연출(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출 : TriggerState {
            internal State마를레네_연출(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetProductionUI(arg1: 1);
                context.CreateMonster(arg1: new int[] {999}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {4001}, arg2: 0);
                context.MoveUser(arg1: 52100302, arg2: 6001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네_연출_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출_02 : TriggerState {
            internal State마를레네_연출_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false,
                    path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(arg1: new int[] {4002}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네_연출_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출_03 : TriggerState {
            internal State마를레네_연출_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetProductionUI(arg1: 3);
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcID: 11004680, illustID: "Eone_normal", align: "right",
                    msg: "$52100302_QD__FIELD_5__3$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new State마를레네_연출_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출_04 : TriggerState {
            internal State마를레네_연출_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {4003}, arg2: 0);
                context.SetNpcEmotionLoop(arg1: 999, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcID: 11004680, illustID: "Eone_normal", align: "right",
                    msg: "$52100302_QD__FIELD_5__4$", duration: 4000);
                context.AddCinematicTalk(npcID: 11004680, illustID: "Eone_normal", align: "right",
                    msg: "$52100302_QD__FIELD_5__5$", duration: 4000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네_연출_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출_05 : TriggerState {
            internal State마를레네_연출_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State마를레네_연출_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State마를레네_연출_06 : TriggerState {
            internal State마를레네_연출_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.AddBuff(arg1: new int[] {9100}, arg2: 73000009, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}