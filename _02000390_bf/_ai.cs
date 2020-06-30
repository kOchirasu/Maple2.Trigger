using System;

namespace Maple2.Trigger._02000390_bf {
    public static class _ai {
        public static readonly Func<ITriggerContext, TriggerState> Start = context =>
            new StateIsDungeonRoomReady(context);

        private class StateIsDungeonRoomReady : TriggerState {
            internal StateIsDungeonRoomReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StatequestIdle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateidle : TriggerState {
            internal Stateidle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Ground", value: 1)) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    context.State = new Stateready(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Statebuff_01(context);
                    return;
                }

                if (context.UserValue(key: "Ending", value: 1)) {
                    context.State = new StateEnding(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Statebuff_01 : TriggerState {
            internal Statebuff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.UserValue(key: "Ground", value: 1)) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    context.State = new Stateready(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new Stateidle(context);
                    return;
                }

                if (context.UserValue(key: "Ending", value: 1)) {
                    context.State = new StateEnding(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatequestIdle : TriggerState {
            internal StatequestIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new StateEnding(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {50001517},
                    arg3: new byte[] {2})) {
                    context.State = new StateEnding(context);
                    return;
                }

                if (context.UserValue(key: "Ground", value: 1)) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    context.State = new Stateready(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatequestIdle_buff_01(context);
                    return;
                }

                if (context.UserValue(key: "Ending", value: 1)) {
                    context.State = new StateEnding(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatequestIdle_buff_01 : TriggerState {
            internal StatequestIdle_buff_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new int[] {701}, arg2: 99910120, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new StateEnding(context);
                    return;
                }

                if (context.UserValue(key: "Ground", value: 1)) {
                    context.RemoveBuff(arg1: 701, arg2: 99910120);
                    context.State = new Stateready(context);
                    return;
                }

                if (context.WaitTick(waitTick: 500)) {
                    context.State = new StatequestIdle(context);
                    return;
                }

                if (context.UserValue(key: "Ending", value: 1)) {
                    context.State = new StateEnding(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class Stateready : TriggerState {
            internal Stateready(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.EnableSpawnPointPc(spawnPointID: 11001, isEnable: false);
                context.EnableSpawnPointPc(spawnPointID: 11002, isEnable: true);
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetMesh(arg1: new int[] {1001, 1002}, arg2: false);
                context.SetMesh(arg1: new int[] {1004, 1005, 1006}, arg2: false);
                context.SetLocalCamera(cameraId: 8002, enable: true);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$02000390_BF__AI__0$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$02000390_BF__AI__1$", arg4: 2, arg5: 2);
                context.DestroyMonster(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
            }

            public override void Execute() {
                if (context.UserValue(key: "Ending", value: 1)) {
                    context.State = new StateEnding(context);
                    return;
                }

                if (context.MonsterDead(arg1: new int[] {201, 210})) {
                    context.State = new StateEnding(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnding : TriggerState {
            internal StateEnding(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetEffect(arg1: new int[] {7001}, arg2: true);
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.DestroyMonster(arg1: new int[] {201, 210, 101, 102});
                context.CreateMonster(arg1: new int[] {202, 103, 104}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEnding_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnding_02 : TriggerState {
            internal StateEnding_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "Ending_04");
                context.DestroyMonster(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509, 510});
                context.CameraSelectPath(arg1: new int[] {8101, 8102, 8103}, arg2: 0);
                context.SetOnetimeEffect(id: 1, enable: false, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
                context.SetNpcEmotionLoop(arg1: 202, arg2: "Stun_A", arg3: 9000000f);
                context.MoveNpc(arg1: 103, arg2: "MS2PatrolData_2008");
                context.MoveNpc(arg1: 104, arg2: "MS2PatrolData_2007");
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000390_BF__AI__2$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000390_BF__AI__3$", arg4: 2, arg5: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateEnding_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnding_03 : TriggerState {
            internal StateEnding_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000390_BF__AI__4$", arg4: 2, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 104, arg3: "$02000390_BF__AI__5$", arg4: 2, arg5: 2);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$02000390_BF__AI__6$", arg4: 2, arg5: 3);
                context.SetConversation(arg1: 1, arg2: 202, arg3: "$02000390_BF__AI__7$", arg4: 2, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateEnding_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnding_04 : TriggerState {
            internal StateEnding_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetOnetimeEffect(id: 1, enable: true, path: @"BG/Common/ScreenMask/Eff_fadein_1sec.xml");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateEnding_04_b(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnding_04_b : TriggerState {
            internal StateEnding_04_b(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraReset(interpolationTime: 0.0f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateEnding_05(context);
                    return;
                }
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

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateIsDungeonRoom(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateIsDungeonRoom : TriggerState {
            internal StateIsDungeonRoom(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.IsDungeonRoom()) {
                    context.State = new StatedungeonEnd(context);
                    return;
                }

                if (!context.IsDungeonRoom()) {
                    context.State = new StatequestEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatedungeonEnd : TriggerState {
            internal StatedungeonEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {1004, 1005, 1006}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetMesh(arg1: new int[] {1001, 1002}, arg2: false);
                context.SetPortal(arg1: 1, arg2: true, arg3: true, arg4: true);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "clearalbanos");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "ClearOceanKing");
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestEnd_warp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatequestEnd : TriggerState {
            internal StatequestEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.RemoveBuff(arg1: 701, arg2: 99910120);
                context.SetMesh(arg1: new int[] {1004, 1005, 1006}, arg2: false);
                context.SetEffect(arg1: new int[] {7001}, arg2: false);
                context.SetMesh(arg1: new int[] {1001, 1002}, arg2: false);
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "clearalbanos");
            }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {701}, arg2: new int[] {50001518},
                    arg3: new byte[] {1})) {
                    context.State = new StateQuestEnd_warp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuestEnd_warp : TriggerState {
            internal StateQuestEnd_warp(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateQuestEnd_warp_End(context);
                    return;
                }
            }

            public override void OnExit() {
                context.MoveUser(arg1: 52000097, arg2: 0);
            }
        }

        private class StateQuestEnd_warp_End : TriggerState {
            internal StateQuestEnd_warp_End(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}