namespace Maple2.Trigger._82000000_survival {
    public static class _01_survival {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new[] {3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 20001, arg2: false);
                context.SetLocalCamera(cameraId: 100, enable: false);
                context.SightRange(enable: true, range: 3, rangeZ: 300, border: 75);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateWait_Talk01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: true);
                context.SetTimer(arg1: "1", arg2: 59, arg3: true, arg4: true, arg5: -80);
                context.WriteLog(arg1: "Survival", arg3: "Waiting_Start");
            }
        }

        private class StateWait_Talk01 : TriggerState {
            internal StateWait_Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__0$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait_Talk02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateChangeBGM(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk02 : TriggerState {
            internal StateWait_Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__1$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait_Talk03(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateChangeBGM(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk03 : TriggerState {
            internal StateWait_Talk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__2$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateWait_Talk01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateChangeBGM(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChangeBGM : TriggerState {
            internal StateChangeBGM(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "BattleField_Event");
                context.SetSound(arg1: 20000, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateStartGameExplain(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartGameExplain : TriggerState {
            internal StateStartGameExplain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000,
                    script: "$82000000_survival__01_SURVIVAL__3$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateGameExplain01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameExplain01 : TriggerState {
            internal StateGameExplain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 6000,
                    script: "$82000000_survival__01_SURVIVAL__4$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateGameExplain02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameExplain02 : TriggerState {
            internal StateGameExplain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__5$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateGameExplain03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameExplain03 : TriggerState {
            internal StateGameExplain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__6$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateGameExplain04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameExplain04 : TriggerState {
            internal StateGameExplain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000,
                    script: "$82000000_survival__01_SURVIVAL__7$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateCheckPCLocation(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckPCLocation : TriggerState {
            internal StateCheckPCLocation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9001})) {
                    context.State = new StateStartPoint01_North(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9002})) {
                    context.State = new StateStartPoint02_South(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9003})) {
                    context.State = new StateStartPoint03_East(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9004})) {
                    context.State = new StateStartPoint04_West(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9005})) {
                    context.State = new StateStartPoint05_NorthWest(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9006})) {
                    context.State = new StateStartPoint06_NorthEast(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9007})) {
                    context.State = new StateStartPoint07_SouthWest(context);
                    return;
                }

                if (context.UserDetected(arg1: new[] {9008})) {
                    context.State = new StateStartPoint08_SouthEast(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartPoint01_North : TriggerState {
            internal StateStartPoint01_North(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 1);
            }
        }

        private class StateStartPoint02_South : TriggerState {
            internal StateStartPoint02_South(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 2);
            }
        }

        private class StateStartPoint03_East : TriggerState {
            internal StateStartPoint03_East(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 3);
            }
        }

        private class StateStartPoint04_West : TriggerState {
            internal StateStartPoint04_West(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 4);
            }
        }

        private class StateStartPoint05_NorthWest : TriggerState {
            internal StateStartPoint05_NorthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 5);
            }
        }

        private class StateStartPoint06_NorthEast : TriggerState {
            internal StateStartPoint06_NorthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 6);
            }
        }

        private class StateStartPoint07_SouthWest : TriggerState {
            internal StateStartPoint07_SouthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 7);
            }
        }

        private class StateStartPoint08_SouthEast : TriggerState {
            internal StateStartPoint08_SouthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 8);
            }
        }

        private class StatePVPReady : TriggerState {
            internal StatePVPReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__8$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateCheckTheNumberOfPlayers(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers : TriggerState {
            internal StateCheckTheNumberOfPlayers(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 9000) >= 20) {
                    context.State = new StateMatchingSuccessDelay(context);
                    return;
                }

                if (context.GetUserCount(boxId: 9000) < 20) {
                    context.State = new StateMatchingFailDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMatchingSuccessDelay : TriggerState {
            internal StateMatchingSuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7, key: "HidePartyUI", value: 1);
                context.PlaySystemSoundInBox(arg2: "GuildBattle_Enter");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMatchingSuccess(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMatchingSuccess : TriggerState {
            internal StateMatchingSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__9$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateRideRiseUp(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRideRiseUp : TriggerState {
            internal StateRideRiseUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "StartPatrol", value: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new StateCountdown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCountdown : TriggerState {
            internal StateCountdown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: "MapleSurvival");
                context.ShowCountUI(text: "$82000000_survival__01_SURVIVAL__10$", stage: 0, count: 3);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StateAreaOpen(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAreaOpen : TriggerState {
            internal StateAreaOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(
                    groupId: new[] {
                        196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214,
                        215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233,
                        234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252,
                        253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271,
                        272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290,
                        291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309,
                        310, 311, 312, 313, 314, 315, 316, 317, 318
                    }, isStart: true);
                context.SetUserValue(triggerId: 5, key: "RareBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOnCount", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 10, key: "BattleRidingOnCount", value: 1);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetUserValue(triggerId: 4, key: "InvincibleOff", value: 1);
                context.AddBuff(arg1: new[] {9000}, arg2: 71000053, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: false);
                context.SetMesh(arg1: new[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 1f);
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 20001, arg2: true);
                context.WriteLog(arg1: "Survival", arg3: "Start");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateGameStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameStart : TriggerState {
            internal StateGameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "StormStart", value: 1);
                context.WriteLog(arg1: "Survival", arg3: "StormStart");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (!context.IsPlayingMapleSurvival()) {
                    context.State = new StateGameEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMatchingFailDelay : TriggerState {
            internal StateMatchingFailDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "guildBattle_MatchingFail");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateMatchingFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateMatchingFail : TriggerState {
            internal StateMatchingFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__11$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGameCancel(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameCancel : TriggerState {
            internal StateGameCancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000,
                    script: "$82000000_survival__01_SURVIVAL__12$");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateReadyToKickOut(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReadyToKickOut : TriggerState {
            internal StateReadyToKickOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "$82000000_survival__01_SURVIVAL__13$", arg3: 4000,
                    arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameEnd : TriggerState {
            internal StateGameEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9000}, arg2: 70001101, arg3: 1, arg4: false, arg5: false);
                context.SightRange(enable: false, range: 3);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {9000})) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "RareBoxOff", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOff", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOff", value: 1);
                context.SetUserValue(triggerId: 10, key: "BattleRidingOff", value: 1);
                context.DestroyMonster(arg1: new[] {-1});
                context.MoveUser(arg1: 0, arg2: 0);
                context.StartCombineSpawn(
                    groupId: new[] {
                        196, 197, 198, 199, 200, 201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214,
                        215, 216, 217, 218, 219, 220, 221, 222, 223, 224, 225, 226, 227, 228, 229, 230, 231, 232, 233,
                        234, 235, 236, 237, 238, 239, 240, 241, 242, 243, 244, 245, 246, 247, 248, 249, 250, 251, 252,
                        253, 254, 255, 256, 257, 258, 259, 260, 261, 262, 263, 264, 265, 266, 267, 268, 269, 270, 271,
                        272, 273, 274, 275, 276, 277, 278, 279, 280, 281, 282, 283, 284, 285, 286, 287, 288, 289, 290,
                        291, 292, 293, 294, 295, 296, 297, 298, 299, 300, 301, 302, 303, 304, 305, 306, 307, 308, 309,
                        310, 311, 312, 313, 314, 315, 316, 317, 318
                    }, isStart: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}