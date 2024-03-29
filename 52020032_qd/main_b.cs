using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52020032_qd {
    public static class _main_b {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(triggerId: 8002, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8003, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8004, visible: false, initialSequence: "Idle_A");
                context.SetEffect(triggerIds: new []{5001, 5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200165}, questStates: new byte[]{1})) {
                    return new StateNpc_Set(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200165}, questStates: new byte[]{2})) {
                    return new StateNpc_Set(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200165}, questStates: new byte[]{3})) {
                    return new StateNpc_All_Del(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{1})) {
                    return new StateEvent_A_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{2})) {
                    return new StateNpc_Set(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{3})) {
                    return new StateNpc_Set(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200150}, questStates: new byte[]{2})) {
                    return new StateEvent_A_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200150}, questStates: new byte[]{3})) {
                    return new StateEvent_A_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200155}, questStates: new byte[]{1})) {
                    return new StateEvent_A_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200155}, questStates: new byte[]{2})) {
                    return new StateEvent_A_Ready(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200155}, questStates: new byte[]{3})) {
                    return new StateEvent_A_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_Ready : TriggerState {
            internal StateEvent_A_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: true);
                context.SetActor(triggerId: 8002, visible: true, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8003, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{1})) {
                    return new StateEvent_C_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200150}, questStates: new byte[]{3})) {
                    return new StateEvent_A_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200155}, questStates: new byte[]{1})) {
                    return new StateEvent_B_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_A_01 : TriggerState {
            internal StateEvent_A_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 8003, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8004, visible: true, initialSequence: "Dead_A");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200155}, questStates: new byte[]{1})) {
                    return new StateEvent_B_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{1})) {
                    return new StateEvent_C_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_01 : TriggerState {
            internal StateEvent_B_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_WhiteFlash.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 700)) {
                    return new StateEvent_B_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_B_02 : TriggerState {
            internal StateEvent_B_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020016, portalId: 0);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{60200160}, questStates: new byte[]{1})) {
                    return new StateEvent_C_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_01 : TriggerState {
            internal StateEvent_C_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
                context.SetActor(triggerId: 8002, visible: true, initialSequence: "Idle_A");
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new StateEvent_C_Skip_01(context), arg2: "Exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new StateEvent_C_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_02 : TriggerState {
            internal StateEvent_C_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52020032, portalId: 6001);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 200)) {
                    return new StateEvent_C_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_03 : TriggerState {
            internal StateEvent_C_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 90000f);
                context.AddCinematicTalk(npcId: 11003620, script: "그럼 편안한 죽음 되시길.", duration: 2800, illustId: "Michael_normal", align: Align.Center);
                context.DestroyMonster(spawnIds: new []{401});
                context.SetActor(triggerId: 8002, visible: false, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_04 : TriggerState {
            internal StateEvent_C_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddBalloonTalk(spawnId: 0, msg: "......", duration: 1800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_05 : TriggerState {
            internal StateEvent_C_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_06 : TriggerState {
            internal StateEvent_C_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, script: "$npcName:11003620$놈!", duration: 2800, illustId: "Turka_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_07 : TriggerState {
            internal StateEvent_C_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002}, visible: true);
                context.CreateMonster(spawnIds: new []{501}, arg2: true);
                context.AddCinematicTalk(npcId: 11003622, script: "감히 날 배신하다니!", duration: 2800, illustId: "Turka_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_08 : TriggerState {
            internal StateEvent_C_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.AddCinematicTalk(npcId: 11003622, script: "배신의 대가는 톡톡히 치르게 해주겠다.", duration: 0, illustId: "Turka_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_09 : TriggerState {
            internal StateEvent_C_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, script: ".......", duration: 1800, illustId: "0", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_10 : TriggerState {
            internal StateEvent_C_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003622, script: "이렇게 된 이상 그 계획을 빨리 진행해야겠군.", duration: 2800, illustId: "0", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_11 : TriggerState {
            internal StateEvent_C_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 501, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateEvent_C_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_12 : TriggerState {
            internal StateEvent_C_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5003}, visible: true);
                context.DestroyMonster(spawnIds: new []{501});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEvent_C_13(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_13 : TriggerState {
            internal StateEvent_C_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_14 : TriggerState {
            internal StateEvent_C_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 0, msg: "......", duration: 2800, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEvent_C_15(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_15 : TriggerState {
            internal StateEvent_C_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(triggerId: 8003, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8004, visible: false, initialSequence: "Idle_A");
                context.CreateMonster(spawnIds: new []{402}, arg2: true);
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 3000f);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Eavesdrop");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Skip_01 : TriggerState {
            internal StateEvent_C_Skip_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_Skip_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Skip_02 : TriggerState {
            internal StateEvent_C_Skip_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 3000f);
                context.DestroyMonster(spawnIds: new []{401, 501});
                context.CreateMonster(spawnIds: new []{402}, arg2: true);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetActor(triggerId: 8002, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8003, visible: false, initialSequence: "Idle_A");
                context.SetActor(triggerId: 8004, visible: false, initialSequence: "Idle_A");
                context.SetEffect(triggerIds: new []{5002, 5003}, visible: false);
                context.CameraReset(interpolationTime: 2.0f);
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "Eavesdrop");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEvent_C_Exit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEvent_C_Exit : TriggerState {
            internal StateEvent_C_Exit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_Set : TriggerState {
            internal StateNpc_Set(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{402}, arg2: true);
                context.DestroyMonster(spawnIds: new []{401, 501});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNpc_All_Del : TriggerState {
            internal StateNpc_All_Del(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{401, 402, 501});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
