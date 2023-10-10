namespace Maple2.Trigger._02000443_bf {
    public static class _ai {
        public class StateIsDungeonRoomReady : TriggerState {
            internal StateIsDungeonRoomReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.IsDungeonRoom()) {
                    return new StateIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateMonsterDestroy(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMonsterDestroy : TriggerState {
            internal StateMonsterDestroy(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{210, 101, 102});
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{701}, skillId: 49200003, level: 1, arg4: false, arg5: false);
                context.RemoveBuff(boxId: 701, skillId: 99910120);
                context.SetEffect(triggerIds: new []{7001}, visible: true);
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.CameraSelectPath(pathIds: new []{8101, 8102, 8103}, returnView: false);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(spawnId: 202, sequenceName: "Stun_A", duration: 9000000f);
                context.MoveNpc(spawnId: 103, patrolName: "MS2PatrolData_2008");
                context.MoveNpc(spawnId: 104, patrolName: "MS2PatrolData_2007");
                context.SetConversation(type: 1, spawnId: 103, script: "$02000443_BF__AI__0$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000443_BF__AI__1$", arg4: 2, arg5: 1);
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
                context.SetConversation(type: 1, spawnId: 202, script: "$02000443_BF__AI__2$", arg4: 2, arg5: 0);
                context.SetConversation(type: 1, spawnId: 104, script: "$02000443_BF__AI__3$", arg4: 2, arg5: 2);
                context.SetConversation(type: 1, spawnId: 103, script: "$02000443_BF__AI__4$", arg4: 2, arg5: 3);
                context.SetConversation(type: 1, spawnId: 202, script: "$02000443_BF__AI__5$", arg4: 2, arg5: 6);
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
                context.SetOnetimeEffect(id: 1, enabled: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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
                context.SetLocalCamera(cameraId: 8001, enabled: false);
                context.SetLocalCamera(cameraId: 8002, enabled: false);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetOnetimeEffect(id: 1, enabled: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
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

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDungeonEnd : TriggerState {
            internal StateDungeonEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: false);
                context.SetMesh(triggerIds: new []{1001, 1002}, visible: false);
                context.SetPortal(portalId: 1, visible: true, enabled: true, minimapVisible: true);
                context.SetAchievement(triggerId: 701, type: "trigger", code: "clearalbanos");
                context.SetAchievement(triggerId: 701, type: "trigger", code: "ClearOceanKing");
                context.DungeonClear();
            }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{701}, questIds: new []{50001518}, questStates: new byte[]{1})) {
                    // return new StateQuestEnd_warp(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
