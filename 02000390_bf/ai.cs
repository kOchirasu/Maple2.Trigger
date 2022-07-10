namespace Maple2.Trigger._02000390_bf {
    public static class _ai {
        public class StateIsDungeonRoomReady : TriggerState {
            internal StateIsDungeonRoomReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateIdle(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 99910120, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(boxId: 701, skillId: 99910120);
                    return new StateReady(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateBuff_01(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBuff_01 : TriggerState {
            internal StateBuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 99910120, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(boxId: 701, skillId: 99910120);
                    return new StateReady(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateIdle(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestIdle : TriggerState {
            internal StateQuestIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 99910120, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateEnding(context);
                }

                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001517}, questStates: new byte[]{2})) {
                    return new StateEnding(context);
                }

                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(boxId: 701, skillId: 99910120);
                    return new StateReady(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuestIdle_buff_01(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestIdle_buff_01 : TriggerState {
            internal StateQuestIdle_buff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 99910120, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateEnding(context);
                }

                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(boxId: 701, skillId: 99910120);
                    return new StateReady(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StateQuestIdle(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnId: 11001, isEnable: false);
                context.EnableSpawnPointPc(spawnId: 11002, isEnable: true);
                context.RemoveBuff(boxId: 701, skillId: 99910120);
                context.SetMesh(triggerIds: new []{1001, 1002, 1004, 1005, 1006}, visible: false);
                context.SetLocalCamera(cameraId: 8002, enable: true);
                context.SetConversation(type: 1, spawnId: 102, script: "$02000390_BF__AI__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 101, script: "$02000390_BF__AI__1$", arg4: 2, arg5: 2);
                context.DestroyMonster(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                if (context.MonsterDead(spawnIds: new []{201, 210})) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 701, skillId: 99910120);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(spawnIds: new []{201, 210, 101, 102});
                context.CreateMonster(spawnIds: new []{202, 103, 104}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_02 : TriggerState {
            internal StateEnding_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateEnding_04(context));
                context.DestroyMonster(spawnIds: new []{501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
                context.CameraSelectPath(pathIds: new []{8101, 8102, 8103}, returnView: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Stun_A", duration: 9000000f);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2008");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2007");
                context.SetConversation(type: 1, spawnId: 103, script: "$02000390_BF__AI__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000390_BF__AI__3$", arg4: 2, arg5: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateEnding_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_03 : TriggerState {
            internal StateEnding_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 202, script: "$02000390_BF__AI__4$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000390_BF__AI__5$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 103, script: "$02000390_BF__AI__6$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000390_BF__AI__7$", arg4: 2, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateEnding_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_04 : TriggerState {
            internal StateEnding_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding_04_b(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_04_b : TriggerState {
            internal StateEnding_04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateEnding_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_05 : TriggerState {
            internal StateEnding_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetLocalCamera(cameraId: 8001, enable: false);
                context.SetLocalCamera(cameraId: 8002, enable: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateIsDungeonRoom(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIsDungeonRoom : TriggerState {
            internal StateIsDungeonRoom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateDungeonEnd(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StateQuestEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonEnd : TriggerState {
            internal StateDungeonEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{1004, 1005, 1006}, visible: false);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "clearalbanos");
                context.SetAchievement(triggerId: 701, type: "trigger", code: "ClearOceanKing");
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateQuestEnd_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd : TriggerState {
            internal StateQuestEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(boxId: 701, skillId: 99910120);
                context.SetMesh(triggerIds: new []{1004, 1005, 1006}, visible: false);
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: false);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "clearalbanos");
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    return new StateQuestEnd_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd_warp : TriggerState {
            internal StateQuestEnd_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestEnd_warp_End(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveUser(mapId: 52000097, portalId: 0);
            }
        }

        private class StateQuestEnd_warp_End : TriggerState {
            internal StateQuestEnd_warp_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
