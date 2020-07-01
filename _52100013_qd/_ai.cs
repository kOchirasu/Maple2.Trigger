namespace Maple2.Trigger._52100013_qd {
    public static class _ai {
        public class StateIsDungeonRoomReady : TriggerState {
            internal StateIsDungeonRoomReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new Stateidle(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StatequestIdle(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    return new Stateready(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new Statebuff_01(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Statebuff_01 : TriggerState {
            internal Statebuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    return new Stateready(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new Stateidle(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatequestIdle : TriggerState {
            internal StatequestIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {2})) {
                    return new StateQuestEnd_warp(context);
                }

                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100080}, arg3: new byte[] {2})) {
                    return new StateEnding(context);
                }

                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    return new Stateready(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StatequestIdle_buff_01(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatequestIdle_buff_01 : TriggerState {
            internal StatequestIdle_buff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {1})) {
                    return new StateEnding(context);
                }

                if (context.GetUserValue(key: "Ground") == 1) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    return new Stateready(context);
                }

                if (context.WaitTick(waitTick: 500)) {
                    return new StatequestIdle(context);
                }

                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointId: 11001, isEnable: false);
                context.EnableSpawnPointPc(spawnPointId: 11002, isEnable: true);
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetMesh(arg1: new[] {1001, 1002, 1004, 1005, 1006}, arg2: false);
                context.SetLocalCamera(cameraId: 8002, enable: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$52100013_QD__AI__7$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$52100013_QD__AI__0$", arg4: 2, arg5: 0);
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Ending") == 1) {
                    return new StateEnding(context);
                }

                if (context.MonsterDead(arg1: new[] {201, 210})) {
                    return new StateEnding(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetEffect(arg1: new[] {7001}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new[] {201, 210, 101, 102});
                context.CreateMonster(arg1: new[] {202, 103, 104}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override TriggerState Execute() {
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
                context.SetSkip(arg1: "Ending_04");
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
                context.CameraSelectPath(arg1: new[] {8101, 8102, 8103}, arg2: false);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Stun_A", arg3: 9000000f);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2008");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2007");
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", msg: "$52100013_QD__AI__1$", align: "right", duration: 2000);
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", msg: "$52100013_QD__AI__2$", align: "left", duration: 2000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateEnding_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnding_03 : TriggerState {
            internal StateEnding_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52100013_QD__AI__3$", arg4: 2, arg5: 0);
                context.AddCinematicTalk(npcId: 11003888, illustId: "Celine_normal", msg: "$52100013_QD__AI__4$", align: "left", duration: 2000);
                context.AddCinematicTalk(npcId: 11003889, illustId: "Firis_normal", msg: "$52100013_QD__AI__5$", align: "right", duration: 2000);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$52100013_QD__AI__6$", arg4: 2, arg5: 6);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
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
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.IsDungeonRoom()) {
                    return new StatedungeonEnd(context);
                }

                if (!context.IsDungeonRoom()) {
                    return new StatequestEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatedungeonEnd : TriggerState {
            internal StatedungeonEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1004, 1005, 1006}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "clearalbanos");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "ClearOceanKing");
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {2})) {
                    return new StateQuestEnd_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatequestEnd : TriggerState {
            internal StatequestEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetMesh(arg1: new[] {1004, 1005, 1006}, arg2: false);
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetMesh(arg1: new[] {1001, 1002}, arg2: false);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "clearalbanos");
            }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {701}, arg2: new[] {50100090}, arg3: new byte[] {2})) {
                    return new StateQuestEnd_warp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd_warp : TriggerState {
            internal StateQuestEnd_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateQuestEnd_warp_End(context);
                }

                return null;
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52010068, arg2: 6001);
            }
        }

        private class StateQuestEnd_warp_End : TriggerState {
            internal StateQuestEnd_warp_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}