using Maple2.Trigger.Enum;

namespace Maple2.Trigger._52000192_qd {
    public static class _52000192 {
        public class StateWait_01 : TriggerState {
            internal StateWait_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: false, path: @"BG/Common/Eff_Com_Vibrate_Short.xml");
                context.SetEffect(triggerIds: new []{6001, 6002, 6003, 6004}, visible: false);
                context.SetInteractObject(interactIds: new []{10001453, 10001454, 10001455, 10001456}, state: 2);
                context.SetPortal(portalId: 5003, visible: false, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003423}, questStates: new byte[]{1})) {
                    return new StateWait_01_02(context);
                }

                if (!context.QuestUserDetected(boxIds: new []{2001}, questIds: new []{10003423}, questStates: new byte[]{1})) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_02 : TriggerState {
            internal StateWait_01_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait_01_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_01_03 : TriggerState {
            internal StateWait_01_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.MoveUser(mapId: 52000192, portalId: 5001);
                context.CameraSelectPath(pathIds: new []{4001}, returnView: false);
                context.CreateMonster(spawnIds: new []{101});
                context.CreateMonster(spawnIds: new []{102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불난통로_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불난통로_01 : TriggerState {
            internal State불난통로_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.SetSceneSkip(state: new StateSkip_1(context), arg2: "nextState");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State불난통로_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불난통로_02 : TriggerState {
            internal State불난통로_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000192_QD__52000192__0$", align: Align.Left, illustId: "Ereb_surprise", duration: 4000);
                context.CameraSelectPath(pathIds: new []{4002, 4003}, returnView: false);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 5000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불난통로_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불난통로_03 : TriggerState {
            internal State불난통로_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 0, script: "$52000192_QD__52000192__1$", duration: 3000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State불난통로_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불난통로_04 : TriggerState {
            internal State불난통로_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddCinematicTalk(npcId: 0, script: "$52000192_QD__52000192__2$", duration: 5000);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000192_QD__52000192__3$", align: Align.Left, illustId: "Baron_normal", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new State불끄기Prepare(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Prepare : TriggerState {
            internal State불끄기Prepare(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetSceneSkip();
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State불끄기Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateSkip_1 : TriggerState {
            internal StateSkip_1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_CameraMasking_FastFadeIn.xml");
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State불끄기Prepare_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불끄기Prepare_02 : TriggerState {
            internal State불끄기Prepare_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{101, 102});
                context.CreateMonster(spawnIds: new []{103});
                context.CreateMonster(spawnIds: new []{104});
                context.SetEffect(triggerIds: new []{6001}, visible: true);
                context.SetInteractObject(interactIds: new []{10001453}, state: 1);
                context.MoveUser(mapId: 52000192, portalId: 5002);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불꺼라불꺼(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼 : TriggerState {
            internal State불꺼라불꺼(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 2, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000192_QD__52000192__4$", duration: 3000);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001453}, arg2: 0)) {
                    return new State불꺼라불꺼_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02 : TriggerState {
            internal State불꺼라불꺼_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__5$", duration: 4000);
                context.SetEffect(triggerIds: new []{6021}, visible: false);
                context.SetEffect(triggerIds: new []{6005, 6006, 6007, 6008}, visible: true);
                context.CreateMonster(spawnIds: new []{201});
                context.CreateMonster(spawnIds: new []{202});
                context.CreateMonster(spawnIds: new []{203});
                context.CreateMonster(spawnIds: new []{204});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State불꺼라불꺼_02_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02_02 : TriggerState {
            internal State불꺼라불꺼_02_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 3);
                context.AddCinematicTalk(npcId: 11004787, script: "$52000192_QD__52000192__6$", illustId: "Baron_normal", align: Align.Left, duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new State불꺼라불꺼_02_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_02_01 : TriggerState {
            internal State불꺼라불꺼_02_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203, 204})) {
                    return new State불꺼라불꺼_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_03 : TriggerState {
            internal State불꺼라불꺼_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__7$", duration: 4000);
                context.SetEffect(triggerIds: new []{6001}, visible: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3001");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new State불꺼라불꺼_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_04 : TriggerState {
            internal State불꺼라불꺼_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6002}, visible: true);
                context.SetInteractObject(interactIds: new []{10001454}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001454}, arg2: 0)) {
                    return new State불꺼라불꺼_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_05 : TriggerState {
            internal State불꺼라불꺼_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__8$", duration: 4000);
                context.SetEffect(triggerIds: new []{6022}, visible: false);
                context.SetEffect(triggerIds: new []{6009, 6010, 6011, 6012}, visible: true);
                context.CreateMonster(spawnIds: new []{205});
                context.CreateMonster(spawnIds: new []{206});
                context.CreateMonster(spawnIds: new []{207});
                context.CreateMonster(spawnIds: new []{208});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{205, 206, 207, 208})) {
                    return new State불꺼라불꺼_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_06 : TriggerState {
            internal State불꺼라불꺼_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__9$", duration: 4000);
                context.SetEffect(triggerIds: new []{6002}, visible: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3003");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3004");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State불꺼라불꺼_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_07 : TriggerState {
            internal State불꺼라불꺼_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: true);
                context.SetInteractObject(interactIds: new []{10001455}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001455}, arg2: 0)) {
                    return new State불꺼라불꺼_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_08 : TriggerState {
            internal State불꺼라불꺼_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__10$", duration: 4000);
                context.SetEffect(triggerIds: new []{6023}, visible: false);
                context.SetEffect(triggerIds: new []{6013, 6014, 6015, 6016}, visible: true);
                context.CreateMonster(spawnIds: new []{209});
                context.CreateMonster(spawnIds: new []{210});
                context.CreateMonster(spawnIds: new []{211});
                context.CreateMonster(spawnIds: new []{212});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{209, 210, 211, 212})) {
                    return new State불꺼라불꺼_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_09 : TriggerState {
            internal State불꺼라불꺼_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6003}, visible: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3005");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3006");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State불꺼라불꺼_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_10 : TriggerState {
            internal State불꺼라불꺼_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{6004}, visible: true);
                context.SetInteractObject(interactIds: new []{10001456}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001456}, arg2: 0)) {
                    return new State불꺼라불꺼_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_11 : TriggerState {
            internal State불꺼라불꺼_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(type: SideNpcTalkType.Talk, npcId: 11004787, illust: "Baron_normal", script: "$52000192_QD__52000192__11$", duration: 3000);
                context.SetEffect(triggerIds: new []{6024}, visible: false);
                context.SetEffect(triggerIds: new []{6017, 6018, 6019, 6020}, visible: true);
                context.CreateMonster(spawnIds: new []{213});
                context.CreateMonster(spawnIds: new []{214});
                context.CreateMonster(spawnIds: new []{215});
                context.CreateMonster(spawnIds: new []{216});
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{213, 214, 215, 216})) {
                    return new State불꺼라불꺼_12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State불꺼라불꺼_12 : TriggerState {
            internal State불꺼라불꺼_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 104, msg: "$52000192_QD__52000192__12$", duration: 3000);
                context.SetEffect(triggerIds: new []{6004}, visible: false);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_3007");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_3008");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new State다왔다(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State다왔다 : TriggerState {
            internal State다왔다(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 101, enabled: true, path: @"BG/Common/Eff_Com_Vibrate.xml");
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetPcEmotionLoop(sequenceName: "Attack_Idle_A", duration: 6000f);
                context.AddCinematicTalk(npcId: 0, script: "$52000192_QD__52000192__13$", duration: 3000);
                context.AddCinematicTalk(npcId: 11004785, script: "$52000192_QD__52000192__14$", illustId: "Ereb_surprise", duration: 4000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new State밖으로(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State밖으로 : TriggerState {
            internal State밖으로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 2001, type: "trigger", code: "EscapePrisonTower");
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetPortal(portalId: 5003, visible: true, enabled: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 02000119, portalId: 20);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
