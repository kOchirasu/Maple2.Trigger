using System;
using System.Numerics;

namespace Maple2.Trigger._83000003_colosseum {
    public static class _main {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State대기(context);

        private class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "MainStart", value: 1)) {
                    context.SetUserValue(triggerID: 900001, key: "MainStart", value: 0);
                    context.DestroyMonster(arg1: new int[] {203});
                    context.CreateMonster(arg1: new int[] {202}, arg2: false);
                    context.State = new StateWaitRound1(context);
                    return;
                }

                if (context.UserValue(key: "MainStart", value: 2)) {
                    context.SetUserValue(triggerID: 900001, key: "MainStart", value: 0);
                    context.DestroyMonster(arg1: new int[] {203});
                    context.CreateMonster(arg1: new int[] {202}, arg2: false);
                    context.State = new StateContinuePlayDelay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound1 : TriggerState {
            internal StateWaitRound1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetUserValue(triggerID: 910001, key: "StartRound1", value: 1);
                    context.State = new StateResultRound1(context);
                    return;
                }

                if (context.UserDetected(arg1: "902")) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    context.State = new StateWaitRound1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateContinuePlayDelay : TriggerState {
            internal StateContinuePlayDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    context.State = new StateContinuePlayDelay2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateContinuePlayDelay2 : TriggerState {
            internal StateContinuePlayDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_01");
                    context.State = new StateContinuePlay(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateContinuePlay : TriggerState {
            internal StateContinuePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromDungeonRewardCount(key: "ClearRound", dungeonRewardID: 24096001);
            }

            public override void Execute() {
                if (context.UserValue(key: "ClearRound", value: 1)) {
                    context.SetUserValue(triggerID: 910002, key: "StartRound2", value: 1);
                    context.State = new StateResultRound2(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 2)) {
                    context.SetUserValue(triggerID: 910003, key: "StartRound3", value: 1);
                    context.State = new StateResultRound3(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 3)) {
                    context.SetUserValue(triggerID: 910004, key: "StartRound4", value: 1);
                    context.State = new StateResultRound4(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 4)) {
                    context.SetUserValue(triggerID: 910005, key: "StartRound5", value: 1);
                    context.State = new StateResultRound5(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 5)) {
                    context.SetUserValue(triggerID: 910006, key: "StartRound6", value: 1);
                    context.State = new StateResultRound6(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 6)) {
                    context.SetUserValue(triggerID: 910007, key: "StartRound7", value: 1);
                    context.State = new StateResultRound7(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 7)) {
                    context.SetUserValue(triggerID: 910008, key: "StartRound8", value: 1);
                    context.State = new StateResultRound8(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 8)) {
                    context.SetUserValue(triggerID: 910009, key: "StartRound9", value: 1);
                    context.State = new StateResultRound9(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 9)) {
                    context.SetUserValue(triggerID: 910010, key: "StartRound10", value: 1);
                    context.State = new StateResultRound10(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 10)) {
                    context.SetUserValue(triggerID: 910011, key: "StartRound11", value: 1);
                    context.State = new StateResultRound11(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 11)) {
                    context.SetUserValue(triggerID: 910012, key: "StartRound12", value: 1);
                    context.State = new StateResultRound12(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 12)) {
                    context.SetUserValue(triggerID: 910013, key: "StartRound13", value: 1);
                    context.State = new StateResultRound13(context);
                    return;
                }

                if (context.UserValue(key: "ClearRound", value: 13)) {
                    context.State = new StateWaitRound1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound1 : TriggerState {
            internal StateResultRound1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound1", value: 2)) {
                    context.DungeonClearRound(round: 1);
                    context.SetUserValue(triggerID: 910001, key: "StartRound1", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound1", value: 0);
                    context.State = new StateWaitRound2(context);
                    return;
                }

                if (context.UserValue(key: "StartRound1", value: 3)) {
                    context.DungeonClearRound(round: 0);
                    context.SetUserValue(triggerID: 910001, key: "StartRound1", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound1", value: 0);
                    context.State = new StateRoundFail(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound2 : TriggerState {
            internal StateWaitRound2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910002, key: "StartRound2", value: 1);
                    context.State = new StateResultRound2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound2 : TriggerState {
            internal StateResultRound2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound2", value: 2)) {
                    context.DungeonClearRound(round: 2);
                    context.SetUserValue(triggerID: 910002, key: "StartRound2", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound2", value: 0);
                    context.State = new StateWaitRound3(context);
                    return;
                }

                if (context.UserValue(key: "StartRound2", value: 3)) {
                    context.SetUserValue(triggerID: 910002, key: "StartRound2", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound2", value: 0);
                    context.State = new State1RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound3 : TriggerState {
            internal StateWaitRound3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910003, key: "StartRound3", value: 1);
                    context.State = new StateResultRound3(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound3 : TriggerState {
            internal StateResultRound3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound3", value: 2)) {
                    context.DungeonClearRound(round: 3);
                    context.SetUserValue(triggerID: 910003, key: "StartRound3", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound3", value: 0);
                    context.State = new StateWaitRound4(context);
                    return;
                }

                if (context.UserValue(key: "StartRound3", value: 3)) {
                    context.SetUserValue(triggerID: 910003, key: "StartRound3", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound3", value: 0);
                    context.State = new State2RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound4 : TriggerState {
            internal StateWaitRound4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910004, key: "StartRound4", value: 1);
                    context.State = new StateResultRound4(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound4 : TriggerState {
            internal StateResultRound4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound4", value: 2)) {
                    context.DungeonClearRound(round: 4);
                    context.SetUserValue(triggerID: 910004, key: "StartRound4", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound4", value: 0);
                    context.State = new StateWaitRound5(context);
                    return;
                }

                if (context.UserValue(key: "StartRound4", value: 3)) {
                    context.SetUserValue(triggerID: 910004, key: "StartRound4", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound4", value: 0);
                    context.State = new State3RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound5 : TriggerState {
            internal StateWaitRound5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910005, key: "StartRound5", value: 1);
                    context.State = new StateResultRound5(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound5 : TriggerState {
            internal StateResultRound5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound5", value: 2)) {
                    context.DungeonClearRound(round: 5);
                    context.SetUserValue(triggerID: 910005, key: "StartRound5", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound5", value: 0);
                    context.State = new StateWaitRound6(context);
                    return;
                }

                if (context.UserValue(key: "StartRound5", value: 3)) {
                    context.SetUserValue(triggerID: 910005, key: "StartRound5", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound5", value: 0);
                    context.State = new State4RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound6 : TriggerState {
            internal StateWaitRound6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910006, key: "StartRound6", value: 1);
                    context.State = new StateResultRound6(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound6 : TriggerState {
            internal StateResultRound6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound6", value: 2)) {
                    context.DungeonClearRound(round: 6);
                    context.SetUserValue(triggerID: 910006, key: "StartRound6", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound6", value: 0);
                    context.State = new StateWaitRound7(context);
                    return;
                }

                if (context.UserValue(key: "StartRound6", value: 3)) {
                    context.SetUserValue(triggerID: 910006, key: "StartRound6", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound6", value: 0);
                    context.State = new State5RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound7 : TriggerState {
            internal StateWaitRound7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910007, key: "StartRound7", value: 1);
                    context.State = new StateResultRound7(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound7 : TriggerState {
            internal StateResultRound7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound7", value: 2)) {
                    context.DungeonClearRound(round: 7);
                    context.SetUserValue(triggerID: 910007, key: "StartRound7", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound7", value: 0);
                    context.State = new StateWaitRound8(context);
                    return;
                }

                if (context.UserValue(key: "StartRound7", value: 3)) {
                    context.SetUserValue(triggerID: 910007, key: "StartRound7", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound7", value: 0);
                    context.State = new State6RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound8 : TriggerState {
            internal StateWaitRound8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910008, key: "StartRound8", value: 1);
                    context.State = new StateResultRound8(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound8 : TriggerState {
            internal StateResultRound8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound8", value: 2)) {
                    context.DungeonClearRound(round: 8);
                    context.SetUserValue(triggerID: 910008, key: "StartRound8", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound8", value: 0);
                    context.State = new StateWaitRound9(context);
                    return;
                }

                if (context.UserValue(key: "StartRound8", value: 3)) {
                    context.SetUserValue(triggerID: 910008, key: "StartRound8", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound8", value: 0);
                    context.State = new State7RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound9 : TriggerState {
            internal StateWaitRound9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910009, key: "StartRound9", value: 1);
                    context.State = new StateResultRound9(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound9 : TriggerState {
            internal StateResultRound9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound9", value: 2)) {
                    context.DungeonClearRound(round: 9);
                    context.SetUserValue(triggerID: 910009, key: "StartRound9", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound9", value: 0);
                    context.State = new StateWaitRound10(context);
                    return;
                }

                if (context.UserValue(key: "StartRound9", value: 3)) {
                    context.SetUserValue(triggerID: 910009, key: "StartRound9", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound9", value: 0);
                    context.State = new State8RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound10 : TriggerState {
            internal StateWaitRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910010, key: "StartRound10", value: 1);
                    context.State = new StateResultRound10(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound10 : TriggerState {
            internal StateResultRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound10", value: 2)) {
                    context.DungeonClearRound(round: 10);
                    context.SetUserValue(triggerID: 910010, key: "StartRound10", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound10", value: 0);
                    context.State = new StateWaitRound11(context);
                    return;
                }

                if (context.UserValue(key: "StartRound10", value: 3)) {
                    context.SetUserValue(triggerID: 910010, key: "StartRound10", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound10", value: 0);
                    context.State = new State9RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound11 : TriggerState {
            internal StateWaitRound11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910011, key: "StartRound11", value: 1);
                    context.State = new StateResultRound11(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound11 : TriggerState {
            internal StateResultRound11(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound11", value: 2)) {
                    context.DungeonClearRound(round: 11);
                    context.SetUserValue(triggerID: 910011, key: "StartRound11", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound11", value: 0);
                    context.State = new StateWaitRound12(context);
                    return;
                }

                if (context.UserValue(key: "StartRound11", value: 3)) {
                    context.SetUserValue(triggerID: 910011, key: "StartRound11", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound11", value: 0);
                    context.State = new State10RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound12 : TriggerState {
            internal StateWaitRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910012, key: "StartRound12", value: 1);
                    context.State = new StateResultRound12(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound12 : TriggerState {
            internal StateResultRound12(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound12", value: 2)) {
                    context.DungeonClearRound(round: 12);
                    context.SetUserValue(triggerID: 910012, key: "StartRound12", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound12", value: 0);
                    context.State = new StateWaitRound13(context);
                    return;
                }

                if (context.UserValue(key: "StartRound12", value: 3)) {
                    context.SetUserValue(triggerID: 910012, key: "StartRound12", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound12", value: 0);
                    context.State = new State11RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateWaitRound13 : TriggerState {
            internal StateWaitRound13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerID: 910013, key: "StartRound13", value: 1);
                    context.State = new StateResultRound13(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateResultRound13 : TriggerState {
            internal StateResultRound13(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "StartRound13", value: 2)) {
                    context.DungeonClearRound(round: 13);
                    context.SetUserValue(triggerID: 910013, key: "StartRound13", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound13", value: 0);
                    context.State = new StateAllRoundClear(context);
                    return;
                }

                if (context.UserValue(key: "StartRound13", value: 3)) {
                    context.SetUserValue(triggerID: 910013, key: "StartRound13", value: 0);
                    context.SetUserValue(triggerID: 900001, key: "StartRound13", value: 0);
                    context.State = new State12RoundClear(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State1RoundClear : TriggerState {
            internal State1RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State2RoundClear : TriggerState {
            internal State2RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State3RoundClear : TriggerState {
            internal State3RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State4RoundClear : TriggerState {
            internal State4RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State5RoundClear : TriggerState {
            internal State5RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State6RoundClear : TriggerState {
            internal State6RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State7RoundClear : TriggerState {
            internal State7RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State8RoundClear : TriggerState {
            internal State8RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State9RoundClear : TriggerState {
            internal State9RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State10RoundClear : TriggerState {
            internal State10RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State11RoundClear : TriggerState {
            internal State11RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State12RoundClear : TriggerState {
            internal State12RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateAllRoundClear : TriggerState {
            internal StateAllRoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRoundFail : TriggerState {
            internal StateRoundFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}