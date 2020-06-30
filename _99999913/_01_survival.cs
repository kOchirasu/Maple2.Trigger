using System;

namespace Maple2.Trigger._99999913 {
    public static class _01_survival {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateSetting(context);

        private class StateSetting : TriggerState {
            internal StateSetting(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: false);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetMesh(arg1: new int[] {3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new int[] {11000037}, arg2: 1);
                context.SetInteractObject(arg1: new int[] {11000039}, arg2: 1);
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 20001, arg2: false);
                context.SightRange(enable: true, range: 3);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9000")) {
                    context.State = new StateWait01(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetEffect(arg1: new int[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: true);
            }
        }

        private class StateWait01 : TriggerState {
            internal StateWait01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 60, arg3: true, arg4: true, arg5: -80);
                context.SetEventUI(arg1: 1, arg2: @"잠시 기다려주세요.\n잠시 후 경기 시작점이 결정됩니다.", arg3: new int[] {4000},
                    arg4: "0");
                context.WriteLog(arg1: "Survival", arg3: "Waiting_Start");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait02(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateCheckTheNumberOfPlayers(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWait02 : TriggerState {
            internal StateWait02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateWait01(context);
                    return;
                }

                if (context.TimeExpired(arg1: "1")) {
                    context.State = new StateCheckTheNumberOfPlayers(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCheckTheNumberOfPlayers : TriggerState {
            internal StateCheckTheNumberOfPlayers(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.CountUsers(arg1: 9000, arg2: 20, arg3: "Less")) {
                    context.State = new StateGameCancel01(context);
                    return;
                }

                if (context.CountUsers(arg1: 9000, arg2: 20, arg3: "GreaterEqual")) {
                    context.State = new StateStartPositionRandomPick(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateStartPositionRandomPick : TriggerState {
            internal StateStartPositionRandomPick(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ResetTimer(arg1: "1");
                context.SetEventUI(arg1: 1, arg2: "시작점으로 이동합니다.", arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap01_North(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap02_South(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap03_East(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap04_West(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap05_NorthWest(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap06_NorthEast(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap07_SouthWest(context);
                    return;
                }

                if (context.RandomCondition(arg1: 12.5f)) {
                    context.State = new StatePCRemap08_SouthEast(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePCRemap01_North : TriggerState {
            internal StatePCRemap01_North(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 101, arg3: 9000);
                context.WriteLog(arg1: "Survival", arg3: "Waiting_PositionPick");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 1);
            }
        }

        private class StatePCRemap02_South : TriggerState {
            internal StatePCRemap02_South(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 102, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 2);
            }
        }

        private class StatePCRemap03_East : TriggerState {
            internal StatePCRemap03_East(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 103, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 3);
            }
        }

        private class StatePCRemap04_West : TriggerState {
            internal StatePCRemap04_West(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 104, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 4);
            }
        }

        private class StatePCRemap05_NorthWest : TriggerState {
            internal StatePCRemap05_NorthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 105, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 5);
            }
        }

        private class StatePCRemap06_NorthEast : TriggerState {
            internal StatePCRemap06_NorthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 106, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 6);
            }
        }

        private class StatePCRemap07_SouthWest : TriggerState {
            internal StatePCRemap07_SouthWest(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 107, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 7);
            }
        }

        private class StatePCRemap08_SouthEast : TriggerState {
            internal StatePCRemap08_SouthEast(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 82000001, arg2: 108, arg3: 9000);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new StatePVPReady(context);
                    return;
                }
            }

            public override void OnExit() {
                context.SetUserValue(triggerID: 2, key: "SetRide", value: 8);
            }
        }

        private class StatePVPReady : TriggerState {
            internal StatePVPReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: @"space 키를 누르면  수레에 탈 수 있습니다.\nspace 키를 다시 누르면 수레에서 내립니다.",
                    arg3: new int[] {3000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StatePVPStart(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StatePVPStart : TriggerState {
            internal StatePVPStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetEventUI(arg1: 1, arg2: @"경기를 곧 시작합니다!\n경기 시작과 함께 수레가 출발합니다!", arg3: new int[] {4000},
                    arg4: "0");
                context.CreateFieldGame(type: "MapleSurvive");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateCountdown(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateCountdown : TriggerState {
            internal StateCountdown(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowCountUI(text: "경기 시작!", count: 3);
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
                context.SetUserValue(triggerID: 5, key: "RareBoxOnCount", value: 1);
                context.SetUserValue(triggerID: 2, key: "StartPatrol", value: 1);
                context.SetSound(arg1: 20000, arg2: true);
                context.PlaySystemSoundInBox(arg2: "System_ShowGuideSummary_01");
                context.SetUserValue(triggerID: 4, key: "InvincibleOff", value: 1);
                context.AddBuff(arg1: new int[] {9000}, arg2: 71000053, arg3: 1, arg4: false, arg5: false);
                context.SetEffect(arg1: new int[] {4000, 4100, 4200, 4300, 4400, 4500, 4600, 4700, 4800}, arg2: false);
                context.SetMesh(arg1: new int[] {3000, 3001, 3002, 3003, 3004, 3005, 3006, 3007}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3100, 3101, 3102, 3103, 3104, 3105, 3106, 3107}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3200, 3201, 3202, 3203, 3204, 3205, 3206, 3207}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3300, 3301, 3302, 3303, 3304, 3305, 3306, 3307}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3400, 3401, 3402, 3403, 3404, 3405, 3406, 3407}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3500, 3501, 3502, 3503, 3504, 3505, 3506, 3507}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3600, 3601, 3602, 3603, 3604, 3605, 3606, 3607}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3700, 3701, 3702, 3703, 3704, 3705, 3706, 3707}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
                context.SetMesh(arg1: new int[] {3800, 3801, 3802, 3803, 3804, 3805, 3806, 3807}, arg2: false,
                    arg3: 1000, arg4: 0, arg5: 2f);
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
                context.SetSound(arg1: 20000, arg2: false);
                context.SetSound(arg1: 20001, arg2: true);
                context.SetUserValue(triggerID: 3, key: "StormStart", value: 1);
                context.WriteLog(arg1: "Survival", arg3: "StormStart");
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9000")) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000037}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {11000039}, arg2: 0);
                context.SetUserValue(triggerID: 5, key: "RareBoxOff", value: 1);
                context.WriteLog(arg1: "Survival", arg3: "Trigger_End");
                context.DestroyMonster(arg1: new int[] {-1});
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class StateGameCancel01 : TriggerState {
            internal StateGameCancel01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "참가자 부족으로 인해 경기를 취소합니다.", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateGameCancel02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameCancel02 : TriggerState {
            internal StateGameCancel02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEventUI(arg1: 1, arg2: "잠시 후 원래 있던 곳으로 돌아갑니다.", arg3: new int[] {4000}, arg4: "0");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    context.State = new StateGameCancel03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGameCancel03 : TriggerState {
            internal StateGameCancel03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new int[] {11000037}, arg2: 0);
                context.SetInteractObject(arg1: new int[] {11000039}, arg2: 0);
                context.DestroyMonster(arg1: new int[] {-1});
                context.MoveUser(arg1: 0, arg2: 0);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}