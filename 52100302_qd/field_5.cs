using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52100302_qd {
    public static class _field_5 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {12000322}, arg2: 2);
                context.SetInteractObject(arg1: new[] {12000600, 12000601, 12000602, 12000603}, arg2: 0);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {1117, 1501, 1502, 1503, 1504, 1505, 1506, 1507, 1508, 1509, 1510, 1511, 1512, 1513})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004607, illust: "Neirin_normal", script: "$52100302_QD__FIELD_5__0$", duration: 5000);
                    context.SetInteractObject(arg1: new[] {12000600}, arg2: 1);
                    context.EnableSpawnPointPc(spawnPointId: 113, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 114, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 115, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 116, isEnable: true);
                    return new StateArcheon_On(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_On : TriggerState {
            internal StateArcheon_On(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {12000600}, arg2: 0)) {
                    return new StateArcheon_Move1_0(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Move1_0 : TriggerState {
            internal StateArcheon_Move1_0(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetPortal(portalId: 10001, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10003, visible: false, enabled: true, minimapVisible: false);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_01", patrolIndex: 1, additionalEffectId: 73000005);
                    context.CreateMonster(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029}, arg2: false);
                    return new StateArcheon_Arrive(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Arrive : TriggerState {
            internal StateArcheon_Arrive(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_5__1$", duration: 6500);
            }

            public override TriggerState Execute() {
                if (context.MonsterDead(arg1: new[] {10001, 10002, 10003, 10004, 10005, 10006, 10007, 10008, 10009, 10010, 10011, 10012, 10013, 10014, 10015, 10016, 10017, 10018, 10019, 10020, 10021, 10022, 10023, 10024, 10025, 10026, 10027, 10028, 10029})) {
                    context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004582, illust: "Eone_serious", script: "$52100302_QD__FIELD_5__2$", duration: 5000);
                    context.PatrolConditionUser(patrolName: "MS2PatrolData_05", patrolIndex: 5, additionalEffectId: 73000005);
                    context.EnableSpawnPointPc(spawnPointId: 116, isEnable: false);
                    context.EnableSpawnPointPc(spawnPointId: 117, isEnable: true);
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

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.SetPortal(portalId: 10005, visible: true, enabled: true, minimapVisible: true);
                    context.SetPortal(portalId: 10007, visible: false, enabled: true, minimapVisible: false);
                    return new StateArcheon_Leave(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_Leave : TriggerState {
            internal StateArcheon_Leave(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9100})) {
                    return new StateArcheon_OffDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateArcheon_OffDelay : TriggerState {
            internal StateArcheon_OffDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.AddBuff(arg1: new[] {9100}, arg2: 73000009, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State마를레네_Cinematic(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic : TriggerState {
            internal State마를레네_Cinematic(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetCinematicUI(type: 1);
                context.CreateMonster(arg1: new[] {999}, arg2: false);
                context.CameraSelectPath(pathIds: new[] {4001}, arg2: false);
                context.MoveUser(arg1: 52100302, arg2: 6001);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네_Cinematic_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic_02 : TriggerState {
            internal State마를레네_Cinematic_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraSelectPath(pathIds: new[] {4002}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네_Cinematic_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic_03 : TriggerState {
            internal State마를레네_Cinematic_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.MoveNpc(arg1: 999, arg2: "MS2PatrolData_3001");
                context.AddCinematicTalk(npcId: 11004680, illustId: "Eone_normal", align: Align.Right, script: "$52100302_QD__FIELD_5__3$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State마를레네_Cinematic_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic_04 : TriggerState {
            internal State마를레네_Cinematic_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {4003}, arg2: false);
                context.SetNpcEmotionLoop(arg1: 999, arg2: "Talk_A", arg3: 8000f);
                context.AddCinematicTalk(npcId: 11004680, illustId: "Eone_normal", align: Align.Right, script: "$52100302_QD__FIELD_5__4$", duration: 4000);
                context.AddCinematicTalk(npcId: 11004680, illustId: "Eone_normal", align: Align.Right, script: "$52100302_QD__FIELD_5__5$", duration: 4000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네_Cinematic_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic_05 : TriggerState {
            internal State마를레네_Cinematic_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State마를레네_Cinematic_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마를레네_Cinematic_06 : TriggerState {
            internal State마를레네_Cinematic_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.AddBuff(arg1: new[] {9100}, arg2: 73000009, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}