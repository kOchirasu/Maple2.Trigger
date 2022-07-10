namespace Maple2.Trigger._52000039_qd {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: false, enabled: false, minimapVisible: false);
                context.HideGuideSummary(entityId: 20020030);
                context.HideGuideSummary(entityId: 20020031);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{3})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{2})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003054}, questStates: new byte[]{1})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{3})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{2})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003053}, questStates: new byte[]{1})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{3})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{2})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003052}, questStates: new byte[]{1})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003051}, questStates: new byte[]{3})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003051}, questStates: new byte[]{2})) {
                    return new StateNextMapPortalOpen(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{10003051}, questStates: new byte[]{1})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StatePCPatrol01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{3})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{2})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{1})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002634}, questStates: new byte[]{3})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_b_07(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002634}, questStates: new byte[]{2})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_b_07(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{1})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002633}, questStates: new byte[]{1})) {
                    return new StateReady_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002633}, questStates: new byte[]{2})) {
                    context.CreateMonster(spawnIds: new []{101}, arg2: true);
                    return new StateScene_b_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002633}, questStates: new byte[]{3})) {
                    context.CreateMonster(spawnIds: new []{101}, arg2: true);
                    return new StateScene_b_01(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002634}, questStates: new byte[]{1})) {
                    context.CreateMonster(spawnIds: new []{101}, arg2: true);
                    context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
                    context.CreateMonster(spawnIds: new []{122}, arg2: true);
                    return new StateScene_b_02(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{2})) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                if (context.UserDetected(boxIds: new []{701}, jobCode: 110)) {
                    context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                    context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    return new StateScene_c_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201, 202, 203}, arg2: false);
                context.CreateMonster(spawnIds: new []{101, 102}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{40002633}, questStates: new byte[]{1})) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelect(triggerId: 7001, enable: true);
                context.MoveNpc(spawnId: 101, patrolName: "MS2PatrolData_2001");
                context.MoveNpc(spawnId: 102, patrolName: "MS2PatrolData_2002");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateStart_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_02 : TriggerState {
            internal StateStart_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "5", seconds: 5);
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000039_QD__MAIN__0$", arg4: 5);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetCinematicUI(type: 0);
                    context.SetCinematicUI(type: 2);
                    context.CameraSelect(triggerId: 7001, enable: false);
                    return new StateStart_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStart_03 : TriggerState {
            internal StateStart_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20020030, textId: 20020030);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{201, 202, 203})) {
                    context.DestroyMonster(spawnIds: new []{102});
                    context.HideGuideSummary(entityId: 20020030);
                    return new StateScene_b_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_01 : TriggerState {
            internal StateScene_b_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAchievement(triggerId: 701, type: "trigger", code: "beyondroid2");
                context.CreateMonster(spawnIds: new []{112}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002634}, questStates: new byte[]{1})) {
                    context.DestroyMonster(spawnIds: new []{112});
                    context.CreateMonster(spawnIds: new []{122}, arg2: true);
                    return new StateScene_b_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_02 : TriggerState {
            internal StateScene_b_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2004");
                context.SetConversation(type: 1, spawnId: 122, script: "$52000039_QD__MAIN__1$", arg4: 3, arg5: 0);
                context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                context.SetMesh(triggerIds: new []{6001}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.NpcDetected(boxId: 703, spawnIds: new []{122})) {
                    context.SetCinematicUI(type: 1);
                    context.SetCinematicUI(type: 3);
                    context.CameraSelect(triggerId: 7002, enable: true);
                    context.MoveUser(mapId: 52000039, portalId: 3);
                    context.SetMesh(triggerIds: new []{6010}, visible: false);
                    return new StateScene_b_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_03 : TriggerState {
            internal StateScene_b_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2006");
                context.SetConversation(type: 2, spawnId: 11001546, script: "$52000039_QD__MAIN__2$", arg4: 3);
                context.SetActor(triggerId: 3010, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_b_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_04 : TriggerState {
            internal StateScene_b_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 7003, enable: true);
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2008");
                context.SetConversation(type: 1, spawnId: 122, script: "$52000039_QD__MAIN__3$", arg4: 3);
                context.SetActor(triggerId: 3010, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_b_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_05 : TriggerState {
            internal StateScene_b_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3010, visible: true, initialSequence: "Attack_01_D");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 650)) {
                    return new StateScene_b_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_06 : TriggerState {
            internal StateScene_b_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 4);
                context.MoveNpc(spawnId: 122, patrolName: "MS2PatrolData_2010");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                    context.CreateMonster(spawnIds: new []{210}, arg2: true);
                    return new StateScene_b_07(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_07 : TriggerState {
            internal StateScene_b_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20020031, textId: 20020031);
                context.CameraSelect(triggerId: 7003, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }

            public override TriggerState? Execute() {
                if (context.MonsterDead(spawnIds: new []{210})) {
                    context.HideGuideSummary(entityId: 20020031);
                    context.SetAchievement(triggerId: 701, type: "trigger", code: "beyondguard");
                    context.DestroyMonster(spawnIds: new []{101, 122});
                    return new StateScene_b_08(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_08 : TriggerState {
            internal StateScene_b_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{111, 132}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 300)) {
                    return new StateScene_b_09(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_09 : TriggerState {
            internal StateScene_b_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 132, script: "$52000039_QD__MAIN__4$", arg4: 3);
                context.SetNpcEmotionLoop(spawnId: 132, sequenceName: "Sit_Down_A", duration: 3000f);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Sit_Down_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateScene_b_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_b_10 : TriggerState {
            internal StateScene_b_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 132, script: "$52000039_QD__MAIN__5$", arg4: 3);
                context.SetNpcEmotionLoop(spawnId: 132, sequenceName: "Stun_A", duration: 3000f);
                context.SetNpcEmotionLoop(spawnId: 111, sequenceName: "Stun_A", duration: 3000f);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{40002635}, questStates: new byte[]{1})) {
                    return new StateScene_c_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_c_01 : TriggerState {
            internal StateScene_c_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 132, script: "$52000039_QD__MAIN__6$", arg4: 3);
                context.MoveNpc(spawnId: 132, patrolName: "MS2PatrolData_2012");
                context.MoveNpc(spawnId: 111, patrolName: "MS2PatrolData_2011");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateScene_c_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateScene_c_02 : TriggerState {
            internal StateScene_c_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
                context.DestroyMonster(spawnIds: new []{132, 111});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateNextMapPortalOpen : TriggerState {
            internal StateNextMapPortalOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 3001, visible: true, initialSequence: "sf_fi_funct_door_A01_Opened");
                context.SetMesh(triggerIds: new []{6001, 6010}, visible: false);
                context.SetActor(triggerId: 3010, visible: false, initialSequence: "Idle_A");
                context.SetPortal(portalId: 2, visible: true, enabled: true, minimapVisible: true);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPatrol01 : TriggerState {
            internal StatePCPatrol01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCPatrol02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPatrol02 : TriggerState {
            internal StatePCPatrol02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 500, enable: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StatePCPatrol03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCPatrol03 : TriggerState {
            internal StatePCPatrol03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.MoveUserPath(patrolName: "MS2PatrolData_1000");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateLookAround01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround01 : TriggerState {
            internal StateLookAround01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionSequence(sequenceNames: new []{"Bore_C"});
                context.SetConversation(type: 1, spawnId: 0, script: "$52000039_QD__MAIN__7$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLookAround02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround02 : TriggerState {
            internal StateLookAround02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 501, enable: true);
                context.SetConversation(type: 1, spawnId: 0, script: "$52000039_QD__MAIN__8$", arg4: 2, arg5: 0);
                context.MoveUserPath(patrolName: "MS2PatrolData_1001");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateLookAround03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateLookAround03 : TriggerState {
            internal StateLookAround03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUserPath(patrolName: "MS2PatrolData_1002");
                context.SetConversation(type: 1, spawnId: 0, script: "$52000039_QD__MAIN__9$", arg4: 2, arg5: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1600)) {
                    return new StatePCFainted01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCFainted01 : TriggerState {
            internal StatePCFainted01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelect(triggerId: 502, enable: true);
                context.SetPcEmotionSequence(sequenceNames: new []{"Down2_A,Down_Idle_A"});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2667)) {
                    return new StatePCTeleport01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport01 : TriggerState {
            internal StatePCTeleport01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetPcEmotionLoop(sequenceName: "Down_Idle_A", duration: 10000f);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.SetCinematicUI(type: 4);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePCTeleport02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCTeleport02 : TriggerState {
            internal StatePCTeleport02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000045, portalId: 2, boxId: 701);
                context.CameraSelect(triggerId: 502, enable: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() {
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
            }
        }
    }
}
