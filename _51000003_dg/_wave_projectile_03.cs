using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile_03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateRound_check(context);

        private class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {421, 422, 423, 424, 425, 426, 427, 428, 429, 430});
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_01", value: 1)) {
                    context.State = new StateRound_01_Ready(context);
                    return;
                }

                if (context.UserValue(key: "Round_02", value: 1)) {
                    // context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    context.State = new StateRound_03_Ready(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 1)) {
                    context.State = new StateRound_04_Ready(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 1)) {
                    context.State = new StateRound_05_Ready(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 1)) {
                    context.State = new StateRound_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Ready : TriggerState {
            internal StateRound_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateRound_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Ready : TriggerState {
            internal StateRound_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    // context.State = new StateRound_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Ready : TriggerState {
            internal StateRound_03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateRound_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Ready : TriggerState {
            internal StateRound_04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateRound_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Ready : TriggerState {
            internal StateRound_05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    context.State = new StateRound_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_04(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {211}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {212}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {213}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {214}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_05 : TriggerState {
            internal StateRound_01_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {215}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_01", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03 : TriggerState {
            internal StateRound_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_01 : TriggerState {
            internal StateRound_03_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {408}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_02 : TriggerState {
            internal StateRound_03_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {406}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_03 : TriggerState {
            internal StateRound_03_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {403}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_04 : TriggerState {
            internal StateRound_03_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {405}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04 : TriggerState {
            internal StateRound_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_01 : TriggerState {
            internal StateRound_04_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {408}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_02 : TriggerState {
            internal StateRound_04_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {406}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_03 : TriggerState {
            internal StateRound_04_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {403}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_04 : TriggerState {
            internal StateRound_04_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {405}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05 : TriggerState {
            internal StateRound_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_01 : TriggerState {
            internal StateRound_05_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {408}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_02 : TriggerState {
            internal StateRound_05_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {406}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_03 : TriggerState {
            internal StateRound_05_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {403}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_04 : TriggerState {
            internal StateRound_05_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {405}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06 : TriggerState {
            internal StateRound_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_06_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_06_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_06_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_06_Random_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_01 : TriggerState {
            internal StateRound_06_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {421}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {422}, arg2: true, arg3: 2000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_06(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_02 : TriggerState {
            internal StateRound_06_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {423}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {424}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new int[] {425}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_06(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_03 : TriggerState {
            internal StateRound_06_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {426}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {427}, arg2: true, arg3: 2000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_06(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_04 : TriggerState {
            internal StateRound_06_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {428}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {429}, arg2: true, arg3: 2000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_06(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 0)) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}