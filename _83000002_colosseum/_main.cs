using System.Numerics;

namespace Maple2.Trigger._83000002_colosseum {
    public static class _main {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "MainStart") == 1) {
                    context.SetUserValue(triggerId: 900001, key: "MainStart", value: 0);
                    context.DestroyMonster(arg1: new[] {203});
                    context.CreateMonster(arg1: new[] {202}, arg2: false);
                    return new StateWaitRound1(context);
                }

                if (context.GetUserValue(key: "MainStart") == 2) {
                    context.SetUserValue(triggerId: 900001, key: "MainStart", value: 0);
                    context.DestroyMonster(arg1: new[] {203});
                    context.CreateMonster(arg1: new[] {202}, arg2: false);
                    return new StateContinuePlayDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound1 : TriggerState {
            internal StateWaitRound1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetUserValue(triggerId: 910001, key: "StartRound1", value: 1);
                    return new StateResultRound1(context);
                }

                if (context.UserDetected(arg1: new[] {902})) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    return new StateWaitRound1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateContinuePlayDelay : TriggerState {
            internal StateContinuePlayDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.LockMyPc(isLock: true);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserToPos(pos: new Vector3(300f, -225f, 1500f), rot: new Vector3(0f, 0f, 270f));
                    return new StateContinuePlayDelay2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateContinuePlayDelay2 : TriggerState {
            internal StateContinuePlayDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.MoveUserPath(arg1: "MS2PatrolData_01");
                    return new StateContinuePlay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateContinuePlay : TriggerState {
            internal StateContinuePlay(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValueFromDungeonRewardCount(key: "ClearRound", dungeonRewardId: 24096001);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "ClearRound") == 1) {
                    context.SetUserValue(triggerId: 910002, key: "StartRound2", value: 1);
                    return new StateResultRound2(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 2) {
                    context.SetUserValue(triggerId: 910003, key: "StartRound3", value: 1);
                    return new StateResultRound3(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 3) {
                    context.SetUserValue(triggerId: 910004, key: "StartRound4", value: 1);
                    return new StateResultRound4(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 4) {
                    context.SetUserValue(triggerId: 910005, key: "StartRound5", value: 1);
                    return new StateResultRound5(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 5) {
                    context.SetUserValue(triggerId: 910006, key: "StartRound6", value: 1);
                    return new StateResultRound6(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 6) {
                    context.SetUserValue(triggerId: 910007, key: "StartRound7", value: 1);
                    return new StateResultRound7(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 7) {
                    context.SetUserValue(triggerId: 910008, key: "StartRound8", value: 1);
                    return new StateResultRound8(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 8) {
                    context.SetUserValue(triggerId: 910009, key: "StartRound9", value: 1);
                    return new StateResultRound9(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 9) {
                    context.SetUserValue(triggerId: 910010, key: "StartRound10", value: 1);
                    return new StateResultRound10(context);
                }

                if (context.GetUserValue(key: "ClearRound") == 10) {
                    return new StateWaitRound1(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound1 : TriggerState {
            internal StateResultRound1(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound1") == 2) {
                    context.DungeonClearRound(round: 1);
                    context.SetUserValue(triggerId: 910001, key: "StartRound1", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound1", value: 0);
                    return new StateWaitRound2(context);
                }

                if (context.GetUserValue(key: "StartRound1") == 3) {
                    context.DungeonClearRound(round: 0);
                    context.SetUserValue(triggerId: 910001, key: "StartRound1", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound1", value: 0);
                    return new StateRoundFail(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound2 : TriggerState {
            internal StateWaitRound2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910002, key: "StartRound2", value: 1);
                    return new StateResultRound2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound2 : TriggerState {
            internal StateResultRound2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound2") == 2) {
                    context.DungeonClearRound(round: 2);
                    context.SetUserValue(triggerId: 910002, key: "StartRound2", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound2", value: 0);
                    return new StateWaitRound3(context);
                }

                if (context.GetUserValue(key: "StartRound2") == 3) {
                    context.SetUserValue(triggerId: 910002, key: "StartRound2", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound2", value: 0);
                    return new State1RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound3 : TriggerState {
            internal StateWaitRound3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910003, key: "StartRound3", value: 1);
                    return new StateResultRound3(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound3 : TriggerState {
            internal StateResultRound3(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound3") == 2) {
                    context.DungeonClearRound(round: 3);
                    context.SetUserValue(triggerId: 910003, key: "StartRound3", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound3", value: 0);
                    return new StateWaitRound4(context);
                }

                if (context.GetUserValue(key: "StartRound3") == 3) {
                    context.SetUserValue(triggerId: 910003, key: "StartRound3", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound3", value: 0);
                    return new State2RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound4 : TriggerState {
            internal StateWaitRound4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910004, key: "StartRound4", value: 1);
                    return new StateResultRound4(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound4 : TriggerState {
            internal StateResultRound4(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound4") == 2) {
                    context.DungeonClearRound(round: 4);
                    context.SetUserValue(triggerId: 910004, key: "StartRound4", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound4", value: 0);
                    return new StateWaitRound5(context);
                }

                if (context.GetUserValue(key: "StartRound4") == 3) {
                    context.SetUserValue(triggerId: 910004, key: "StartRound4", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound4", value: 0);
                    return new State3RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound5 : TriggerState {
            internal StateWaitRound5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910005, key: "StartRound5", value: 1);
                    return new StateResultRound5(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound5 : TriggerState {
            internal StateResultRound5(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound5") == 2) {
                    context.DungeonClearRound(round: 5);
                    context.SetUserValue(triggerId: 910005, key: "StartRound5", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound5", value: 0);
                    return new StateWaitRound6(context);
                }

                if (context.GetUserValue(key: "StartRound5") == 3) {
                    context.SetUserValue(triggerId: 910005, key: "StartRound5", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound5", value: 0);
                    return new State4RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound6 : TriggerState {
            internal StateWaitRound6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910006, key: "StartRound6", value: 1);
                    return new StateResultRound6(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound6 : TriggerState {
            internal StateResultRound6(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound6") == 2) {
                    context.DungeonClearRound(round: 6);
                    context.SetUserValue(triggerId: 910006, key: "StartRound6", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound6", value: 0);
                    return new StateWaitRound7(context);
                }

                if (context.GetUserValue(key: "StartRound6") == 3) {
                    context.SetUserValue(triggerId: 910006, key: "StartRound6", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound6", value: 0);
                    return new State5RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound7 : TriggerState {
            internal StateWaitRound7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910007, key: "StartRound7", value: 1);
                    return new StateResultRound7(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound7 : TriggerState {
            internal StateResultRound7(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound7") == 2) {
                    context.DungeonClearRound(round: 7);
                    context.SetUserValue(triggerId: 910007, key: "StartRound7", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound7", value: 0);
                    return new StateWaitRound8(context);
                }

                if (context.GetUserValue(key: "StartRound7") == 3) {
                    context.SetUserValue(triggerId: 910007, key: "StartRound7", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound7", value: 0);
                    return new State6RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound8 : TriggerState {
            internal StateWaitRound8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910008, key: "StartRound8", value: 1);
                    return new StateResultRound8(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound8 : TriggerState {
            internal StateResultRound8(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound8") == 2) {
                    context.DungeonClearRound(round: 8);
                    context.SetUserValue(triggerId: 910008, key: "StartRound8", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound8", value: 0);
                    return new StateWaitRound9(context);
                }

                if (context.GetUserValue(key: "StartRound8") == 3) {
                    context.SetUserValue(triggerId: 910008, key: "StartRound8", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound8", value: 0);
                    return new State7RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound9 : TriggerState {
            internal StateWaitRound9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910009, key: "StartRound9", value: 1);
                    return new StateResultRound9(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound9 : TriggerState {
            internal StateResultRound9(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound9") == 2) {
                    context.DungeonClearRound(round: 9);
                    context.SetUserValue(triggerId: 910009, key: "StartRound9", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound9", value: 0);
                    return new StateWaitRound10(context);
                }

                if (context.GetUserValue(key: "StartRound9") == 3) {
                    context.SetUserValue(triggerId: 910009, key: "StartRound9", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound9", value: 0);
                    return new State8RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWaitRound10 : TriggerState {
            internal StateWaitRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    context.SetUserValue(triggerId: 910010, key: "StartRound10", value: 1);
                    return new StateResultRound10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateResultRound10 : TriggerState {
            internal StateResultRound10(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "StartRound10") == 2) {
                    context.DungeonClearRound(round: 10);
                    context.SetUserValue(triggerId: 910010, key: "StartRound10", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound10", value: 0);
                    return new StateAllRoundClear(context);
                }

                if (context.GetUserValue(key: "StartRound10") == 3) {
                    context.SetUserValue(triggerId: 910010, key: "StartRound10", value: 0);
                    context.SetUserValue(triggerId: 900001, key: "StartRound10", value: 0);
                    return new State9RoundClear(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State1RoundClear : TriggerState {
            internal State1RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State2RoundClear : TriggerState {
            internal State2RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State3RoundClear : TriggerState {
            internal State3RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State4RoundClear : TriggerState {
            internal State4RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State5RoundClear : TriggerState {
            internal State5RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State6RoundClear : TriggerState {
            internal State6RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State7RoundClear : TriggerState {
            internal State7RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State8RoundClear : TriggerState {
            internal State8RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State9RoundClear : TriggerState {
            internal State9RoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear(uiType: "None");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateAllRoundClear : TriggerState {
            internal StateAllRoundClear(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonClear();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRoundFail : TriggerState {
            internal StateRoundFail(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DungeonFail();
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}