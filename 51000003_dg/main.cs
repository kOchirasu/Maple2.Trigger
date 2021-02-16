namespace Maple2.Trigger._51000003_dg {
    public static class _main {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7999}, arg2: false);
                context.SetPortal(portalId: 8, visible: false, enabled: false, minimapVisible: false);
                context.SetMesh(arg1: new[] {6001, 6002, 6003, 6004, 6005, 6006, 6007, 6008, 6009, 6010, 6011, 6012, 6013, 6014, 6015, 6016, 6017, 6018, 6019, 6020, 6021, 6022, 6023, 6024, 6025, 6026, 6027, 6028, 6029, 6030, 6031, 6032, 6033, 6034, 6035, 6036, 6037, 6038, 6039, 6040, 6041, 6042, 6043, 6044, 6045, 6046, 6047, 6048, 6049, 6050, 6051, 6052, 6053, 6054, 6055, 6056, 6057, 6058, 6059, 6060, 6061, 6062, 6063, 6064, 6065, 6066, 6067, 6068, 6069, 6070, 6071, 6072, 6073, 6074, 6075, 6076, 6077, 6078, 6079, 6080, 6081, 6082, 6083, 6084, 6085, 6086, 6087, 6088, 6089, 6090, 6091, 6092, 6093, 6094, 6095, 6096, 6097, 6098, 6099, 6100, 6201, 6202, 6203, 6204, 6205, 6206, 6207, 6208, 6209, 6210, 6211, 6212, 6213, 6214, 6215, 6216, 6217, 6218, 6219, 6220, 6221, 6222, 6223, 6224, 6225, 6226, 6227, 6228, 6229, 6230, 6231, 6232, 6233, 6234, 6235, 6236, 6237, 6238, 6239, 6240, 6241, 6242, 6243, 6244, 6245, 6246, 6247, 6248, 6249, 6250, 6251, 6252, 6253, 6254, 6255, 6256, 6257, 6258, 6259, 6260, 6261, 6262, 6263, 6264, 6265, 6266, 6267, 6268, 6269, 6270, 6271, 6272, 6273, 6274, 6275, 6276, 6277, 6278, 6279, 6280, 6281, 6282, 6283, 6284, 6285, 6286, 6287, 6288, 6289, 6290, 6291, 6292, 6293, 6294, 6295, 6296, 6297, 6298, 6299, 6300}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 701) == 1) {
                    return new StateTutorial(context);
                }

                return null;
            }

            public override void OnExit() {
                context.CreateMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509}, arg2: true, arg3: 0);
            }
        }

        private class StateTutorial : TriggerState {
            internal StateTutorial(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7998}, arg2: true);
                context.SetCinematicUI(type: 1);
                context.SetCinematicUI(type: 3);
                context.CameraSelectPath(pathIds: new[] {8100, 8101, 8104, 8106, 8103, 8105, 8107, 8108}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    return new StateTutorial_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTutorial_01 : TriggerState {
            internal StateTutorial_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetSkip(state: new StateTutorial_02(context));
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 9500)) {
                    return new StateTutorial_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateTutorial_02 : TriggerState {
            internal StateTutorial_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 51000003, arg2: 1, arg3: 701);
                context.SetEffect(arg1: new[] {7998}, arg2: false);
                context.CameraSelectPath(pathIds: new[] {8005, 8001, 8002}, arg2: false);
                context.SetUserValue(triggerId: 991109, key: "Tutorial", value: 0);
                context.SetCinematicUI(type: 0);
                context.SetCinematicUI(type: 2);
                context.SetCinematicUI(type: 7);
                context.ArcadeBoomBoomOceanStartGame(lifeCount: 20);
                context.ShowCountUI(text: "$51000003_DG__MAIN__0$", stage: 0, count: 5);
                context.SetUserValue(triggerId: 991103, key: "Fail", value: 1);
                context.AddBuff(arg1: new[] {701}, arg2: 70000087, arg3: 1, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.DestroyMonster(arg1: new[] {501, 502, 503, 504, 505, 506, 507, 508, 509});
            }
        }

        private class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_Monkey_01");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_start");
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "arcade_startcheck");
                context.SetMesh(arg1: new[] {6101, 6102, 6103, 6104, 6105, 6106, 6107, 6108, 6109, 6110, 6111, 6112, 6113, 6114, 6115, 6116, 6117, 6118, 6119, 6120, 6121, 6122, 6123, 6124, 6125, 6126, 6127, 6128, 6129, 6130, 6131, 6132, 6133, 6134, 6135, 6136, 6137, 6138, 6139, 6140, 6141, 6142, 6143, 6144, 6145, 6146, 6147, 6148, 6149, 6150, 6151, 6152, 6153, 6154, 6155, 6156, 6157, 6158, 6159, 6160, 6161, 6162, 6163, 6164, 6165, 6166, 6167, 6168, 6169, 6170, 6171, 6172, 6173, 6174, 6175, 6176, 6177, 6178, 6179, 6180, 6181, 6182, 6183, 6184, 6185, 6186, 6187, 6188, 6189, 6190, 6191, 6192, 6193, 6194, 6195, 6196, 6197, 6198, 6199, 6200}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.RemoveBuff(arg1: 49179004, arg2: 0);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49210001, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49210011, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49210021, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49210031, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49200021, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49200001, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49190012, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 49190022, score: -500);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 70000080, score: 1000);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 70000081, score: 1000);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 70000082, score: 1000);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 70000083, score: 1000);
                context.ArcadeBoomBoomOceanSetSkillScore(id: 70000085, score: 1000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStep_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_01 : TriggerState {
            internal StateStep_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991107, key: "Round_01", value: 1);
                context.ArcadeBoomBoomOceanStartRound(round: 1, roundDuration: 1500, timeScoreRate: 1033);
                context.PlaySystemSoundInBox(arg2: "System_Fruit_Throw_Loop_01");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_02(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_02 : TriggerState {
            internal StateStep_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991107, key: "Round_02", value: 1);
                context.ArcadeBoomBoomOceanClearRound(round: 1);
                context.ArcadeBoomBoomOceanStartRound(round: 2, roundDuration: 20000, timeScoreRate: 1033);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_03(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_03 : TriggerState {
            internal StateStep_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 991111, key: "Round_01", value: 1);
                context.SetUserValue(triggerId: 991107, key: "Round_03", value: 1);
                context.ArcadeBoomBoomOceanClearRound(round: 2);
                context.ArcadeBoomBoomOceanStartRound(round: 3, roundDuration: 20000, timeScoreRate: 1033);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_04(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_1min");
            }
        }

        private class StateStep_04 : TriggerState {
            internal StateStep_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CameraSelectPath(pathIds: new[] {8002, 8003}, arg2: false);
                context.SetEffect(arg1: new[] {7999}, arg2: true);
                context.SetUserValue(triggerId: 991120, key: "Round_01", value: 1);
                context.SetUserValue(triggerId: 991107, key: "Round_04", value: 1);
                context.ArcadeBoomBoomOceanClearRound(round: 3);
                context.ArcadeBoomBoomOceanStartRound(round: 4, roundDuration: 20000, timeScoreRate: 1550);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_05(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {7999}, arg2: false);
            }
        }

        private class StateStep_05 : TriggerState {
            internal StateStep_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 4);
                context.ArcadeBoomBoomOceanStartRound(round: 5, roundDuration: 20000, timeScoreRate: 1550);
                context.SetUserValue(triggerId: 991104, key: "Round_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_06(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_06 : TriggerState {
            internal StateStep_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 5);
                context.ArcadeBoomBoomOceanStartRound(round: 6, roundDuration: 20000, timeScoreRate: 1550);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_07(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_07 : TriggerState {
            internal StateStep_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 6);
                context.ArcadeBoomBoomOceanStartRound(round: 7, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerId: 991105, key: "Round_00", value: 1);
                context.SetUserValue(triggerId: 991102, key: "Treasure_box", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_08(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_08 : TriggerState {
            internal StateStep_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 7);
                context.ArcadeBoomBoomOceanStartRound(round: 8, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerId: 991121, key: "Round_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_09(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_09 : TriggerState {
            internal StateStep_09(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 8);
                context.ArcadeBoomBoomOceanStartRound(round: 9, roundDuration: 20000, timeScoreRate: 2067);
                context.SetUserValue(triggerId: 991122, key: "Round_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_10(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_3min");
            }
        }

        private class StateStep_10 : TriggerState {
            internal StateStep_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 9);
                context.ArcadeBoomBoomOceanStartRound(round: 10, roundDuration: 20000, timeScoreRate: 2583);
                context.SetEffect(arg1: new[] {7999}, arg2: true);
                context.CameraSelectPath(pathIds: new[] {8003, 8004}, arg2: false);
                context.SetUserValue(triggerId: 991106, key: "Round_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_11 : TriggerState {
            internal StateStep_11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 10);
                context.ArcadeBoomBoomOceanStartRound(round: 11, roundDuration: 20000, timeScoreRate: 2583);
                context.SetUserValue(triggerId: 991106, key: "Round_02", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_12(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_12 : TriggerState {
            internal StateStep_12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 11);
                context.ArcadeBoomBoomOceanStartRound(round: 12, roundDuration: 20000, timeScoreRate: 2583);
                context.SetUserValue(triggerId: 991106, key: "Round_03", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_13(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_13 : TriggerState {
            internal StateStep_13(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 12);
                context.ArcadeBoomBoomOceanStartRound(round: 13, roundDuration: 20000, timeScoreRate: 3100);
                context.SetUserValue(triggerId: 991106, key: "Round_04", value: 1);
                context.SetUserValue(triggerId: 991105, key: "Round_01", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_14(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_14 : TriggerState {
            internal StateStep_14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 13);
                context.ArcadeBoomBoomOceanStartRound(round: 14, roundDuration: 20000, timeScoreRate: 3100);
                context.SetUserValue(triggerId: 991123, key: "Round_01", value: 1);
                context.SetUserValue(triggerId: 991108, key: "Round_03", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_15(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_15 : TriggerState {
            internal StateStep_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 14);
                context.ArcadeBoomBoomOceanStartRound(round: 15, roundDuration: 20000, timeScoreRate: 3100);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_16(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_5min");
            }
        }

        private class StateStep_16 : TriggerState {
            internal StateStep_16(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 15);
                context.ArcadeBoomBoomOceanStartRound(round: 16, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerId: 991123, key: "Round_02", value: 1);
                context.SetUserValue(triggerId: 991105, key: "Round_02", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_17(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_17 : TriggerState {
            internal StateStep_17(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 16);
                context.ArcadeBoomBoomOceanStartRound(round: 17, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerId: 991106, key: "Round_05", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_18(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_18 : TriggerState {
            internal StateStep_18(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 17);
                context.ArcadeBoomBoomOceanStartRound(round: 18, roundDuration: 20000, timeScoreRate: 1350);
                context.SetUserValue(triggerId: 991123, key: "Round_03", value: 1);
                context.SetUserValue(triggerId: 991122, key: "Round_02", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_19(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_19 : TriggerState {
            internal StateStep_19(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 18);
                context.ArcadeBoomBoomOceanStartRound(round: 19, roundDuration: 20000, timeScoreRate: 1125);
                context.SetUserValue(triggerId: 991107, key: "Round_06", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_20(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_20 : TriggerState {
            internal StateStep_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 19);
                context.ArcadeBoomBoomOceanStartRound(round: 20, roundDuration: 20000, timeScoreRate: 1125);
                context.SetUserValue(triggerId: 991123, key: "Round_04", value: 1);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_21(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_21 : TriggerState {
            internal StateStep_21(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 20);
                context.ArcadeBoomBoomOceanStartRound(round: 21, roundDuration: 20000, timeScoreRate: 1125);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_22(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_22 : TriggerState {
            internal StateStep_22(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 21);
                context.ArcadeBoomBoomOceanStartRound(round: 22, roundDuration: 20000, timeScoreRate: 900);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_23(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_23 : TriggerState {
            internal StateStep_23(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 22);
                context.ArcadeBoomBoomOceanStartRound(round: 23, roundDuration: 20000, timeScoreRate: 900);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_24(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_24 : TriggerState {
            internal StateStep_24(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 23);
                context.ArcadeBoomBoomOceanStartRound(round: 24, roundDuration: 20000, timeScoreRate: 900);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    return new StateStep_25(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_25 : TriggerState {
            internal StateStep_25(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanClearRound(round: 24);
                context.ArcadeBoomBoomOceanStartRound(round: 25, roundDuration: 20000, timeScoreRate: 562);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 120000)) {
                    return new StateStep_26(context);
                }

                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStep_26 : TriggerState {
            internal StateStep_26(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanEndGame();
                context.SetAchievement(arg1: 701, arg2: "trigger", arg3: "boomocean_10min");
            }

            public override TriggerState Execute() {
                if (context.GetUserCount(boxId: 705) == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ArcadeBoomBoomOceanEndGame();
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}