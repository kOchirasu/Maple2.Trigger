using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52010065_qd {
    public static class _52010065_main {
        public class StatePC체크 : TriggerState {
            internal StatePC체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount() > 0) {
                    context.VisibleMyPc(visible: false);
                    return new StateSetup_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup_01 : TriggerState {
            internal StateSetup_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.VisibleMyPc(visible: true);
                context.SetCinematicUI(type: 1);
                context.SetVisibleUI(uiNames: new []{"UpperHudDialog", "MessengerBrowser", "ExpBar", "GroupMessengerBrowser", "QuestGuideDialog", "MinimapDialog", "AdPushDialog", "SnowmanEventDialog"}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateSetup_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSetup_02 : TriggerState {
            internal StateSetup_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8001}, returnView: false);
                context.SetVisibleUI(uiNames: new []{"MessengerBrowser", "GroupMessengerBrowser"}, visible: false);
                context.AddBuff(boxIds: new []{701}, skillId: 99910320, level: 1, arg4: false, arg5: true);
                context.AddBuff(boxIds: new []{701}, skillId: 99910320, level: 1, arg4: false, arg5: false);
                context.CreateMonster(spawnIds: new []{101}, arg2: false);
                context.SetMesh(triggerIds: new []{4001, 4002, 4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025, 4026}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{91000076}, questStates: new byte[]{3})) {
                    return new StateQuest완료_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{91000076}, questStates: new byte[]{2})) {
                    return new State검마Spawn_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{91000076}, questStates: new byte[]{1})) {
                    return new State검마Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Spawn_01 : TriggerState {
            internal State검마Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State검마Spawn_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Spawn_02 : TriggerState {
            internal State검마Spawn_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마Spawn_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Spawn_03 : TriggerState {
            internal State검마Spawn_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8003}, returnView: false);
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State벨라Spawn_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State벨라Spawn_01 : TriggerState {
            internal State벨라Spawn_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{102}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State저멀리발록_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저멀리발록_01 : TriggerState {
            internal State저멀리발록_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 3, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State저멀리발록_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State저멀리발록_02 : TriggerState {
            internal State저멀리발록_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
                context.SetSceneSkip(state: new State스킵1_01(context), arg2: "nextState");
                context.SetCinematicUI(type: 3);
                context.SetOnetimeEffect(id: 3, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State발록검마인사_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_01 : TriggerState {
            internal State발록검마인사_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003819, script: "$52010065_QD__52010065_main__0$", duration: 3000, illustId: "balrog_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State발록검마인사_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_02 : TriggerState {
            internal State발록검마인사_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001811, script: "$52010065_QD__52010065_main__1$", duration: 3000, illustId: "BlackWizard_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State발록검마인사_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발록검마인사_03 : TriggerState {
            internal State발록검마인사_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003819, script: "$52010065_QD__52010065_main__2$", duration: 3000, illustId: "balrog_normal", align: Align.Center);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new State다리끊기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_01 : TriggerState {
            internal State다리끊기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8005}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State다리끊기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_02 : TriggerState {
            internal State다리끊기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4003, 4006, 4010}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_03 : TriggerState {
            internal State다리끊기_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4004, 4005, 4014}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_04 : TriggerState {
            internal State다리끊기_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4007, 4013, 4018}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_05 : TriggerState {
            internal State다리끊기_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4009, 4015, 4022}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_06 : TriggerState {
            internal State다리끊기_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4008, 4012, 4017}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_07 : TriggerState {
            internal State다리끊기_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4011, 4016, 4023}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_08 : TriggerState {
            internal State다리끊기_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4019, 4021, 4024}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 50)) {
                    return new State다리끊기_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다리끊기_09 : TriggerState {
            internal State다리끊기_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4020, 4025}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State비웃는검마_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_01 : TriggerState {
            internal State비웃는검마_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8002}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비웃는검마_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_02 : TriggerState {
            internal State비웃는검마_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001811, script: "$52010065_QD__52010065_main__3$", duration: 3000, illustId: "BlackWizard_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State비웃는검마_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비웃는검마_03 : TriggerState {
            internal State비웃는검마_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11003820, script: "$52010065_QD__52010065_main__4$", duration: 3000, illustId: "Bella_normal", align: Align.Left);
                context.AddCinematicTalk(npcId: 11001811, script: "$52010065_QD__52010065_main__5$", duration: 3000, illustId: "BlackWizard_normal", align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State용암건너기_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State스킵1_01 : TriggerState {
            internal State스킵1_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{4003, 4004, 4005, 4006, 4007, 4008, 4009, 4010, 4011, 4012, 4013, 4014, 4015, 4016, 4017, 4018, 4019, 4020, 4021, 4022, 4023, 4024, 4025}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                return new State용암건너기_01(context);
            }

            public override void OnExit() { }
        }

        private class State용암건너기_01 : TriggerState {
            internal State용암건너기_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.CameraReset(interpolationTime: 1.0f);
                context.SetMesh(triggerIds: new []{4026}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State용암건너기_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State용암건너기_02 : TriggerState {
            internal State용암건너기_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25210651, textId: 25210651);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{702})) {
                    return new State용암건너기완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State용암건너기완료_01 : TriggerState {
            internal State용암건너기완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State용암건너기완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State용암건너기완료_02 : TriggerState {
            internal State용암건너기완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010065, portalId: 11);
                context.DestroyMonster(spawnIds: new []{102});
                context.CreateMonster(spawnIds: new []{103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuest완료_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료_01 : TriggerState {
            internal StateQuest완료_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 4, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.HideGuideSummary(entityId: 25210651);
                context.CreateMonster(spawnIds: new []{104}, arg2: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{91000076}, questStates: new byte[]{3})) {
                    return new StateQuest완료_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuest완료_02 : TriggerState {
            internal StateQuest완료_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State검마Exit_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_01 : TriggerState {
            internal State검마Exit_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006}, returnView: false);
                context.VisibleMyPc(visible: false);
                context.DestroyMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{106}, arg2: false);
                context.DestroyMonster(spawnIds: new []{104});
                context.CreateMonster(spawnIds: new []{105}, arg2: false);
                context.MoveNpc(spawnId: 105, patrolName: "MS2PatrolData_2001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State검마Exit_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_02 : TriggerState {
            internal State검마Exit_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 5, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip(state: new State마무리(context), arg2: "exit");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State검마Exit_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_03 : TriggerState {
            internal State검마Exit_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 106, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마Exit_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_04 : TriggerState {
            internal State검마Exit_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8006, 8007}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State검마Exit_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_05 : TriggerState {
            internal State검마Exit_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new []{8007, 8008}, returnView: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State검마Exit_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State검마Exit_06 : TriggerState {
            internal State검마Exit_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 11001811, script: "$52010065_QD__52010065_main__6$", duration: 3000, align: Align.Right);
                context.AddCinematicTalk(npcId: 11001811, script: "$52010065_QD__52010065_main__7$", duration: 3000, align: Align.Right);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6500)) {
                    return new State마무리(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State마무리 : TriggerState {
            internal State마무리(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSceneSkip();
                context.SetOnetimeEffect(id: 6, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State강제이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State강제이동 : TriggerState {
            internal State강제이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52010061, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
