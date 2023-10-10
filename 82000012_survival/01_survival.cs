using Maple2.Trigger.Enum;

namespace Maple2.Trigger._82000012_survival {
    public static class _01_survival {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{11000037, 11000039}, state: 1);
                context.SetSound(triggerId: 20000, enabled: false);
                context.SetSound(triggerId: 20001, enabled: false);
                context.SetLocalCamera(cameraId: 100, enabled: false);
                context.SightRange(enabled: true, range: 3);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateWait_Talk01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: true);
            }
        }

        private class StateWait_Talk01 : TriggerState {
            internal StateWait_Talk01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 90, autoRemove: true, display: true, vOffset: -80);
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__0$");
                context.WriteLog(logName: "Survival", @event: "Waiting_Start");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk02 : TriggerState {
            internal StateWait_Talk02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__1$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk03(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk03 : TriggerState {
            internal StateWait_Talk03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__2$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk04(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk04 : TriggerState {
            internal StateWait_Talk04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__3$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk05(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk05 : TriggerState {
            internal StateWait_Talk05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__4$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk06(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait_Talk06 : TriggerState {
            internal StateWait_Talk06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__5$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateWait_Talk01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers_1st(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers_1st : TriggerState {
            internal StateCheckTheNumberOfPlayers_1st(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) >= 25) {
                    return new StateMatchingSuccessDelay(context);
                }

                if (context.GetUserCount(boxId: 9000) < 25) {
                    return new StateMatchingFailDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMatchingSuccessDelay : TriggerState {
            internal StateMatchingSuccessDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 7, key: "HidePartyUI", value: 1);
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
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__17$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateReadyToMoveStartPosition(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReadyToMoveStartPosition : TriggerState {
            internal StateReadyToMoveStartPosition(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 3000, script: "$82000012_survival__01_SURVIVAL__11$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateStartPositionRandomPick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPositionRandomPick : TriggerState {
            internal StateStartPositionRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap01_North(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap02_South(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap03_East(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap04_West(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap05_NorthWest(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap06_NorthEast(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap07_SouthWest(context);
                }

                if (context.RandomCondition(rate: 12.5f)) {
                    return new StatePCRemap08_SouthEast(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePCRemap01_North : TriggerState {
            internal StatePCRemap01_North(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 101, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 1);
            }
        }

        private class StatePCRemap02_South : TriggerState {
            internal StatePCRemap02_South(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 102, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 2);
            }
        }

        private class StatePCRemap03_East : TriggerState {
            internal StatePCRemap03_East(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 103, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 3);
            }
        }

        private class StatePCRemap04_West : TriggerState {
            internal StatePCRemap04_West(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 104, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 4);
            }
        }

        private class StatePCRemap05_NorthWest : TriggerState {
            internal StatePCRemap05_NorthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 105, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 5);
            }
        }

        private class StatePCRemap06_NorthEast : TriggerState {
            internal StatePCRemap06_NorthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 106, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 6);
            }
        }

        private class StatePCRemap07_SouthWest : TriggerState {
            internal StatePCRemap07_SouthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 107, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 7);
            }
        }

        private class StatePCRemap08_SouthEast : TriggerState {
            internal StatePCRemap08_SouthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "BattleField_Event");
                context.SetSound(triggerId: 20000, enabled: true);
                context.MoveUser(mapId: 82000012, portalId: 108, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new StateStartGameExplain(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetUserValue(triggerId: 2, key: "SetRide", value: 8);
            }
        }

        private class StateStartGameExplain : TriggerState {
            internal StateStartGameExplain(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 6000, script: "$82000012_survival__01_SURVIVAL__6$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateGameExplain01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain01 : TriggerState {
            internal StateGameExplain01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 6000, script: "$82000012_survival__01_SURVIVAL__7$");
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
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 3500, script: "$82000012_survival__01_SURVIVAL__8$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateGameExplain03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain03 : TriggerState {
            internal StateGameExplain03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 3500, script: "$82000012_survival__01_SURVIVAL__9$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3500)) {
                    return new StateGameExplain04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain04 : TriggerState {
            internal StateGameExplain04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000, script: "$82000012_survival__01_SURVIVAL__10$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameExplain05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameExplain05 : TriggerState {
            internal StateGameExplain05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 5000, script: "$82000012_survival__01_SURVIVAL__12$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePVPReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePVPReady : TriggerState {
            internal StatePVPReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__13$");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateCheckTheNumberOfPlayers_2nd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers_2nd : TriggerState {
            internal StateCheckTheNumberOfPlayers_2nd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) >= 20) {
                    return new StateRideRiseUp(context);
                }

                if (context.GetUserCount(boxId: 9000) < 20) {
                    return new StateMatchingFailDelay(context);
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
                context.CreateFieldGame(type: FieldGame.MapleSurvival);
                context.ShowCountUI(text: "$82000012_survival__01_SURVIVAL__14$", stage: 0, count: 3);
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
                context.StartCombineSpawn(groupId: new []{37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159}, isStart: true);
                context.SetUserValue(triggerId: 5, key: "RareBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 8, key: "RareMobOnCount", value: 1);
                context.SetUserValue(triggerId: 9, key: "NormaBoxOnCount", value: 1);
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
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__15$");
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
                context.SideNpcTalk(npcId: 23500110, illust: "Mushking_normal", duration: 4000, script: "$82000012_survival__01_SURVIVAL__16$");
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
                context.SetEventUI(arg1: 1, script: "$82000012_survival__01_SURVIVAL__18$", duration: 4000, boxId: 0);
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
                context.SetInteractObject(interactIds: new []{11000037, 11000039}, state: 0);
                context.DestroyMonster(spawnIds: new []{-1});
                context.MoveUser(mapId: 0, portalId: 0);
                context.StartCombineSpawn(groupId: new []{37, 38, 39, 40, 41, 42, 43, 44, 45, 46, 47, 48, 49, 50, 51, 52, 53, 54, 55, 56, 57, 58, 59, 60, 61, 62, 63, 64, 65, 66, 67, 68, 69, 70, 71, 72, 73, 74, 75, 76, 77, 78, 79, 80, 81, 82, 83, 84, 85, 86, 87, 88, 89, 90, 91, 92, 93, 94, 95, 96, 97, 98, 99, 100, 101, 102, 103, 104, 105, 106, 107, 108, 109, 110, 111, 112, 113, 114, 115, 116, 117, 118, 119, 120, 121, 122, 123, 124, 125, 126, 127, 128, 129, 130, 131, 132, 133, 134, 135, 136, 137, 138, 139, 140, 141, 142, 143, 144, 145, 146, 147, 148, 149, 150, 151, 152, 153, 154, 155, 156, 157, 158, 159}, isStart: false);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
