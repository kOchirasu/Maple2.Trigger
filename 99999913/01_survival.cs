using Maple2.Trigger.Enum;

namespace Maple2.Trigger._99999913 {
    public static class _01_survival {
        public class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007, 3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107, 3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207, 3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307, 3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407, 3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507, 3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607, 3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707, 3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, visible: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(interactIds: new []{11000037, 11000039}, state: 1);
                context.SetSound(triggerId: 20000, arg2: false);
                context.SetSound(triggerId: 20001, arg2: false);
                context.SightRange(enable: true, range: 3);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9000})) {
                    return new StateWait01(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: true);
            }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 60, clearAtZero: true, display: true, arg5: -80);
                context.SetEventUI(arg1: 1, script: @"잠시 기다려주세요.\n잠시 후 경기 시작점이 결정됩니다.", duration: 4000, boxId: 0);
                context.WriteLog(logName: "Survival", @event: "Waiting_Start");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait02(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateWait01(context);
                }

                if (context.TimeExpired(timerId: "1")) {
                    return new StateCheckTheNumberOfPlayers(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers : TriggerState {
            internal StateCheckTheNumberOfPlayers(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserCount(boxId: 9000) < 20) {
                    return new StateGameCancel01(context);
                }

                if (context.GetUserCount(boxId: 9000) >= 20) {
                    return new StateStartPositionRandomPick(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateStartPositionRandomPick : TriggerState {
            internal StateStartPositionRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(timerId: "1");
                context.SetEventUI(arg1: 1, script: "시작점으로 이동합니다.", duration: 3000, boxId: 0);
            }

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
                context.MoveUser(mapId: 82000001, portalId: 101, boxId: 9000);
                context.WriteLog(logName: "Survival", @event: "Waiting_PositionPick");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 102, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 103, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 104, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 105, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 106, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 107, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StatePVPReady(context);
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
                context.MoveUser(mapId: 82000001, portalId: 108, boxId: 9000);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
                context.SetEventUI(arg1: 1, script: @"space 키를 누르면  수레에 탈 수 있습니다.\nspace 키를 다시 누르면 수레에서 내립니다.", duration: 3000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StatePVPStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StatePVPStart : TriggerState {
            internal StatePVPStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, script: @"경기를 곧 시작합니다!\n경기 시작과 함께 수레가 출발합니다!", duration: 4000, boxId: 0);
                context.CreateFieldGame(type: FieldGame.MapleSurvival);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateCountdown(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCountdown : TriggerState {
            internal StateCountdown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "경기 시작!", count: 3);
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
                context.SetUserValue(triggerId: 5, key: "RareBoxOnCount", value: 1);
                context.SetUserValue(triggerId: 2, key: "StartPatrol", value: 1);
                context.SetSound(triggerId: 20000, arg2: true);
                context.PlaySystemSoundInBox(sound: "System_ShowGuideSummary_01");
                context.SetUserValue(triggerId: 4, key: "InvincibleOff", value: 1);
                context.AddBuff(boxIds: new []{9000}, skillId: 71000053, level: 1, arg4: false, arg5: false);
                context.SetEffect(triggerIds: new []{4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, visible: false);
                context.SetMesh(triggerIds: new []{3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(triggerIds: new []{3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, visible: false, arg3: 1000, arg4: 0, arg5: 2f);
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
                context.SetSound(triggerId: 20000, arg2: false);
                context.SetSound(triggerId: 20001, arg2: true);
                context.SetUserValue(triggerId: 3, key: "StormStart", value: 1);
                context.WriteLog(logName: "Survival", @event: "StormStart");
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
                context.SetInteractObject(interactIds: new []{11000037, 11000039}, state: 0);
                context.SetUserValue(triggerId: 5, key: "RareBoxOff", value: 1);
                context.WriteLog(logName: "Survival", @event: "Trigger_End");
                context.DestroyMonster(spawnIds: new []{-1});
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameCancel01 : TriggerState {
            internal StateGameCancel01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "참가자 부족으로 인해 경기를 취소합니다.", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateGameCancel02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameCancel02 : TriggerState {
            internal StateGameCancel02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, script: "잠시 후 원래 있던 곳으로 돌아갑니다.", duration: 4000, boxId: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateGameCancel03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGameCancel03 : TriggerState {
            internal StateGameCancel03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{11000037, 11000039}, state: 0);
                context.DestroyMonster(spawnIds: new []{-1});
                context.MoveUser(mapId: 0, portalId: 0);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
