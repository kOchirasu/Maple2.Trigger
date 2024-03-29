using Maple2.Trigger.Enum;

namespace Maple2.Trigger._82000003_survival {
    public static class _01_survival {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 20001, enabled: false);
                context.SetLocalCamera(cameraId: 100, enabled: false);
                context.SightRange(enabled: true, range: 3, rangeZ: 300f, border: 75);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateWait_Talk01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: true);
                context.SetTimer(timerId: "1", seconds: 59, autoRemove: true, display: true, vOffset: -80);
                context.WriteLog(logName: "Survival", @event: "Waiting_Start");
            }
        }

        private class StateWait_Talk01 : TriggerState {
            internal StateWait_Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__0$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateChangeBGM(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk02 : TriggerState {
            internal StateWait_Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__1$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk03(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateChangeBGM(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk03 : TriggerState {
            internal StateWait_Talk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__2$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateChangeBGM(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChangeBGM : TriggerState {
            internal StateChangeBGM(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartGameExplain : TriggerState {
            internal StateStartGameExplain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__3$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameExplain01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain01 : TriggerState {
            internal StateGameExplain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 6000, script: "$82000002_survival__01_SURVIVAL__4$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateGameExplain02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain02 : TriggerState {
            internal StateGameExplain02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 3000, script: "$82000002_survival__01_SURVIVAL__5$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGameExplain03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain03 : TriggerState {
            internal StateGameExplain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 3000, script: "$82000002_survival__01_SURVIVAL__6$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGameExplain04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain04 : TriggerState {
            internal StateGameExplain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__7$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateGameExplain05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain05 : TriggerState {
            internal StateGameExplain05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__14$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateCheckPCLocation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckPCLocation : TriggerState {
            internal StateCheckPCLocation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9001})) {
                    return new StateStartPoint01_North(context);
                }

                if (context.UserDetected(boxIds: new []{9002})) {
                    return new StateStartPoint02_South(context);
                }

                if (context.UserDetected(boxIds: new []{9003})) {
                    return new StateStartPoint03_East(context);
                }

                if (context.UserDetected(boxIds: new []{9004})) {
                    return new StateStartPoint04_West(context);
                }

                if (context.UserDetected(boxIds: new []{9005})) {
                    return new StateStartPoint05_NorthWest(context);
                }

                if (context.UserDetected(boxIds: new []{9006})) {
                    return new StateStartPoint06_NorthEast(context);
                }

                if (context.UserDetected(boxIds: new []{9007})) {
                    return new StateStartPoint07_SouthWest(context);
                }

                if (context.UserDetected(boxIds: new []{9008})) {
                    return new StateStartPoint08_SouthEast(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPoint01_North : TriggerState {
            internal StateStartPoint01_North(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 1);
            }
        }

        private class StateStartPoint02_South : TriggerState {
            internal StateStartPoint02_South(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 2);
            }
        }

        private class StateStartPoint03_East : TriggerState {
            internal StateStartPoint03_East(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 3);
            }
        }

        private class StateStartPoint04_West : TriggerState {
            internal StateStartPoint04_West(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 4);
            }
        }

        private class StateStartPoint05_NorthWest : TriggerState {
            internal StateStartPoint05_NorthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 5);
            }
        }

        private class StateStartPoint06_NorthEast : TriggerState {
            internal StateStartPoint06_NorthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 6);
            }
        }

        private class StateStartPoint07_SouthWest : TriggerState {
            internal StateStartPoint07_SouthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 7);
            }
        }

        private class StateStartPoint08_SouthEast : TriggerState {
            internal StateStartPoint08_SouthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 8);
            }
        }

        private class StatePVPReady : TriggerState {
            internal StatePVPReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCheckTheNumberOfPlayers(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers : TriggerState {
            internal StateCheckTheNumberOfPlayers(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) >= 20) {
                    return new StateMatchingSuccessDelay(context);
                }

                if (context.GetUserCount(boxId: 9000) < 20) {
                    return new StateMatchingFailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMatchingSuccessDelay : TriggerState {
            internal StateMatchingSuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "GuildBattle_Enter");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMatchingSuccess(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMatchingSuccess : TriggerState {
            internal StateMatchingSuccess(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__9$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateRideRiseUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRideRiseUp : TriggerState {
            internal StateRideRiseUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 2, key: "StartPatrol", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCountdown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCountdown : TriggerState {
            internal StateCountdown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateFieldGame(type: FieldGame.MapleSurvivalTeam);
                context.ShowCountUI(text: "$82000002_survival__01_SURVIVAL__10$", stage: 0, count: 3);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateAreaOpen(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAreaOpen : TriggerState {
            internal StateAreaOpen(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.StartCombineSpawn(groupId: new []{355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, isStart: true);
                context.SetUserValue(triggerId: 5, key: "RareBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOnCount", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 16, key: "ExtraEventCheck", value: 1);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetUserValue(triggerId: 4, key: "InvincibleOff", value: 1);
                context.AddBuff(boxIds: new []{9000}, skillId: 71000053, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetMesh(triggerIds: new []{3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, visible: false, arg3: 1000, arg4: 0, arg5: 1f);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 20001, enabled: true);
                context.WriteLog(logName: "Survival", @event: "Start");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 30000)) {
                    return new StateGameStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameStart : TriggerState {
            internal StateGameStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 3, key: "StormStart", value: 1);
                context.WriteLog(logName: "Survival", @event: "StormStart");
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuit(context);
                }

                if (!context.IsPlayingMapleSurvival()) {
                    return new StateGameEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMatchingFailDelay : TriggerState {
            internal StateMatchingFailDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "guildBattle_MatchingFail");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateMatchingFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMatchingFail : TriggerState {
            internal StateMatchingFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__11$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameCancel(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameCancel : TriggerState {
            internal StateGameCancel(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000002_survival__01_SURVIVAL__12$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateReadyToKickOut(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToKickOut : TriggerState {
            internal StateReadyToKickOut(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "$82000002_survival__01_SURVIVAL__13$", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameEnd : TriggerState {
            internal StateGameEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9000}, skillId: 70001101, level: 1, arg4: false, arg5: false);
                context.SightRange(enabled: false, range: 3);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9000})) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 5, key: "RareBoxOff", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOff", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOff", value: 1);
                context.SetUserValue(triggerId: 16, key: "ExtraEventOff", value: 1);
                context.DestroyMonster(spawnIds: new []{-1});
                context.MoveUser(mapId: 0, portalId: 0);
                context.StartCombineSpawn(groupId: new []{355, 356, 357, 358, 359, 360, 361, 362, 363, 364, 365, 366, 367, 368, 369, 370, 371, 372, 373, 374, 375, 376, 377, 378, 379, 380, 381, 382, 383, 384, 385, 386, 387, 388, 389, 390, 391, 392, 393, 394, 395, 396, 397, 398, 399, 400, 401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417, 418, 419, 420, 421, 422, 423, 424, 425, 426, 427, 428, 429, 430, 431, 432, 433, 434, 435, 436, 437, 438, 439, 440, 441, 442, 443, 444, 445, 446, 447, 448, 449, 450, 451, 452, 453, 454, 455, 456, 457, 458, 459, 460, 461, 462, 463, 464, 465, 466, 467, 468, 469, 470, 471, 472, 473, 474, 475, 476, 477}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
