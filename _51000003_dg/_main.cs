using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateIdle(context);

        private class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7999}, arg2: false);
                context.SetPortal(arg1: 8, arg2: false, arg3: false, arg4: false);
                context.SetMesh(
                    arg1: new int[] {
                        6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016,
                        6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032,
                        6033, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6041, 6042, 6043, 6044, 6045, 6046, 6047, 6048,
                        6049, 6050, 6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064,
                        6065, 6066, 6067, 6068, 6069, 6070, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080,
                        6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6093, 6094, 6095, 6096,
                        6097, 6098, 6099, 6100
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetMesh(
                    arg1: new int[] {
                        6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211, 6212, 6213, 6214, 6215, 6216,
                        6217, 6218, 6219, 6220, 6221, 6222, 6223, 6224, 6225, 6226, 6227, 6228, 6229, 6230, 6231, 6232,
                        6233, 6234, 6235, 6236, 6237, 6238, 6239, 6240, 6241, 6242, 6243, 6244, 6245, 6246, 6247, 6248,
                        6249, 6250, 6251, 6252, 6253, 6254, 6255, 6256, 6257, 6258, 6259, 6260, 6261, 6262, 6263, 6264,
                        6265, 6266, 6267, 6268, 6269, 6270, 6271, 6272, 6273, 6274, 6275, 6276, 6277, 6278, 6279, 6280,
                        6281, 6282, 6283, 6284, 6285, 6286, 6287, 6288, 6289, 6290, 6291, 6292, 6293, 6294, 6295, 6296,
                        6297, 6298, 6299, 6300
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 701, arg2: 1)) {
                    context.State = new StateTutorial(context);
                    return;
                }
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: true,
                    arg3: 0);
            }
        }

        private class StateTutorial : TriggerState {
            internal StateTutorial(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {7998}, arg2: true);
                context.SetProductionUI(arg1: 1);
                context.SetProductionUI(arg1: 3);
                context.CameraSelectPath(arg1: new int[] {8100, 8101, 8104, 8106, 8103, 8105, 8107, 8108}, arg2: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new StateTutorial_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTutorial_01 : TriggerState {
            internal StateTutorial_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(arg1: "Tutorial_02");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    context.State = new StateTutorial_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateTutorial_02 : TriggerState {
            internal StateTutorial_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000003, arg2: 1, arg3: 701);
                context.SetEffect(arg1: new int[] {7998}, arg2: false);
                context.CameraSelectPath(arg1: new int[] {8005, 8001, 8002}, arg2: 0);
                context.SetUserValue(triggerID: 991109, key: "Tutorial", value: 0);
                context.SetProductionUI(arg1: 0);
                context.SetProductionUI(arg1: 2);
                context.SetProductionUI(arg1: 7);
                context.ArcadeBoomBoomOcean(type: "StartGame", lifeCount: 20);
                context.ShowCountUI(text: "$51000003_DG__MAIN__0$", stage: 0, count: 5);
                context.SetUserValue(triggerID: 991103, key: "Fail", value: 1);
                context.AddBuff(arg1: new int[] {701}, arg2: 70000087, arg3: 1, arg5: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateStart(context);
                    return;
                }
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new int[] {501, 502, 503, 504, 505, 506, 507, 508, 509});
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Monkey_01");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_start");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "arcade_startcheck");
                context.SetMesh(
                    arg1: new int[] {
                        6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116,
                        6117, 6118, 6119, 6120, 6121, 6122, 6123, 6124, 6125, 6126, 6127, 6128, 6129, 6130, 6131, 6132,
                        6133, 6134, 6135, 6136, 6137, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6145, 6146, 6147, 6148,
                        6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163, 6164,
                        6165, 6166, 6167, 6168, 6169, 6170, 6171, 6172, 6173, 6174, 6175, 6176, 6177, 6178, 6179, 6180,
                        6181, 6182, 6183, 6184, 6185, 6186, 6187, 6188, 6189, 6190, 6191, 6192, 6193, 6194, 6195, 6196,
                        6197, 6198, 6199, 6200
                    }, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(arg1: 49179004, arg2: 0);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49210001, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49210011, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49210021, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49210031, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49200021, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49200001, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49190012, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 49190022, score: -500);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 70000080, score: 1000);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 70000081, score: 1000);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 70000082, score: 1000);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 70000083, score: 1000);
                context.ArcadeBoomBoomOcean(type: "SetSkillScore", id: 70000085, score: 1000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStep_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_01 : TriggerState {
            internal StateStep_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991107, key: "Round_01", value: 1);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 1, roundDuration: 1500, timeScoreRate: 1033);
                context.PlaySystemSoundInBox(arg2: "System_Fruit_Throw_Loop_01");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_02(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_02 : TriggerState {
            internal StateStep_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991107, key: "Round_02", value: 1);
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 1);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 2, roundDuration: 20000, timeScoreRate: 1033);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_03(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_03 : TriggerState {
            internal StateStep_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerID: 991111, key: "Round_01", value: 1);
                context.SetUserValue(triggerID: 991107, key: "Round_03", value: 1);
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 2);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 3, roundDuration: 20000, timeScoreRate: 1033);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_04(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_1min");
            }
        }

        private class StateStep_04 : TriggerState {
            internal StateStep_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(arg1: new int[] {8002, 8003}, arg2: 0);
                context.SetEffect(arg1: new int[] {7999}, arg2: true);
                context.SetUserValue(triggerID: 991120, key: "Round_01", value: 1);
                context.SetUserValue(triggerID: 991107, key: "Round_04", value: 1);
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 3);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 4, roundDuration: 20000, timeScoreRate: 1550);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_05(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {7999}, arg2: false);
            }
        }

        private class StateStep_05 : TriggerState {
            internal StateStep_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 4);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 5, roundDuration: 20000, timeScoreRate: 1550);
                context.SetUserValue(triggerID: 991104, key: "Round_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_06(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_06 : TriggerState {
            internal StateStep_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 5);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 6, roundDuration: 20000, timeScoreRate: 1550);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_07(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_07 : TriggerState {
            internal StateStep_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 6);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 7, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerID: 991105, key: "Round_00", value: 1);
                context.SetUserValue(triggerID: 991102, key: "Treasure_box", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_08(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_08 : TriggerState {
            internal StateStep_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 7);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 8, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerID: 991121, key: "Round_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_09(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_09 : TriggerState {
            internal StateStep_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 8);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 9, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerID: 991122, key: "Round_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_10(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_3min");
            }
        }

        private class StateStep_10 : TriggerState {
            internal StateStep_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 9);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 10, roundDuration: 20000, timeScoreRate: 2583);
                context.SetEffect(arg1: new int[] {7999}, arg2: true);
                context.CameraSelectPath(arg1: new int[] {8003, 8004}, arg2: 0);
                context.SetUserValue(triggerID: 991106, key: "Round_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_11 : TriggerState {
            internal StateStep_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 10);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 11, roundDuration: 20000, timeScoreRate: 2583);
                context.SetUserValue(triggerID: 991106, key: "Round_02", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_12(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_12 : TriggerState {
            internal StateStep_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 11);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 12, roundDuration: 20000, timeScoreRate: 2583);
                context.SetUserValue(triggerID: 991106, key: "Round_03", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_13(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_13 : TriggerState {
            internal StateStep_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 12);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 13, roundDuration: 20000, timeScoreRate: 3100);
                context.SetUserValue(triggerID: 991106, key: "Round_04", value: 1);
                context.SetUserValue(triggerID: 991105, key: "Round_01", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_14(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_14 : TriggerState {
            internal StateStep_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 13);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 14, roundDuration: 20000, timeScoreRate: 3100);
                context.SetUserValue(triggerID: 991123, key: "Round_01", value: 1);
                context.SetUserValue(triggerID: 991108, key: "Round_03", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_15(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_15 : TriggerState {
            internal StateStep_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 14);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 15, roundDuration: 20000, timeScoreRate: 3100);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_16(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_5min");
            }
        }

        private class StateStep_16 : TriggerState {
            internal StateStep_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 15);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 16, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerID: 991123, key: "Round_02", value: 1);
                context.SetUserValue(triggerID: 991105, key: "Round_02", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_17(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_17 : TriggerState {
            internal StateStep_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 16);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 17, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerID: 991106, key: "Round_05", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_18(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_18 : TriggerState {
            internal StateStep_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 17);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 18, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerID: 991123, key: "Round_03", value: 1);
                context.SetUserValue(triggerID: 991122, key: "Round_02", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_19(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_19 : TriggerState {
            internal StateStep_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 18);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 19, roundDuration: 20000, timeScoreRate: 1125);
                context.SetUserValue(triggerID: 991107, key: "Round_06", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_20(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_20 : TriggerState {
            internal StateStep_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 19);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 20, roundDuration: 20000, timeScoreRate: 1125);
                context.SetUserValue(triggerID: 991123, key: "Round_04", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_21(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_21 : TriggerState {
            internal StateStep_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 20);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 21, roundDuration: 20000, timeScoreRate: 1125);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_22(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_22 : TriggerState {
            internal StateStep_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 21);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 22, roundDuration: 20000, timeScoreRate: 900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_23(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_23 : TriggerState {
            internal StateStep_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 22);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 23, roundDuration: 20000, timeScoreRate: 900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_24(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_24 : TriggerState {
            internal StateStep_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 23);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 24, roundDuration: 20000, timeScoreRate: 900);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateStep_25(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_25 : TriggerState {
            internal StateStep_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "ClearRound", round: 24);
                context.ArcadeBoomBoomOcean(type: "StartRound", round: 25, roundDuration: 20000, timeScoreRate: 562);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    context.State = new StateStep_26(context);
                    return;
                }

                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStep_26 : TriggerState {
            internal StateStep_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "EndGame");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_10min");
            }

            public override void Execute() {
                if (context.CountUsers(arg1: 705, arg2: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOcean(type: "EndGame");
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}