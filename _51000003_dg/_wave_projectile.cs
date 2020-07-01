namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[]
                    {201, 202, 203, 204, 205, 206, 207, 208, 209, 210, 211, 212, 213, 214, 215, 298, 299});
                context.DestroyMonster(arg1: new[]
                    {401, 402, 403, 404, 405, 406, 407, 408, 409, 410, 411, 412, 413, 414, 415, 416, 417});
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    context.State = new StateRound_01_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    // context.State = new StateRound_02_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    // context.State = new StateRound_03_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    // context.State = new StateRound_04_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 1) {
                    // context.State = new StateRound_05_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Ready : TriggerState {
            internal StateRound_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateRound_01(context);
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

                if (context.GetUserValue(key: "Round_02") == 1) {
                    context.State = new StateRound_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
                context.SetTimer(arg1: "5", arg2: 5);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "5")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02 : TriggerState {
            internal StateRound_02(ITriggerContext context) : base(context) { }

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
                    context.State = new StateRound_02_Random_01(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_02_Random_02(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_02_Random_03(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_02_Random_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_01 : TriggerState {
            internal StateRound_02_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {204}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_02 : TriggerState {
            internal StateRound_02_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {203}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_03 : TriggerState {
            internal StateRound_02_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {204}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_04 : TriggerState {
            internal StateRound_02_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {202}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_05 : TriggerState {
            internal StateRound_02_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {204}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_06 : TriggerState {
            internal StateRound_02_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {403}, arg2: true, arg3: 1000);
                context.SetTimer(arg1: "3", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_03_Random_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_01 : TriggerState {
            internal StateRound_03_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_02 : TriggerState {
            internal StateRound_03_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_03 : TriggerState {
            internal StateRound_03_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_04 : TriggerState {
            internal StateRound_03_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_05 : TriggerState {
            internal StateRound_03_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {411}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_06 : TriggerState {
            internal StateRound_03_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {413}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_07 : TriggerState {
            internal StateRound_03_Random_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {298}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {215}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {211}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {214}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {213}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {212}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Random_08 : TriggerState {
            internal StateRound_03_Random_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {299}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {216}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {217}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {220}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {218}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {219}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_04_Random_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_01 : TriggerState {
            internal StateRound_04_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_02 : TriggerState {
            internal StateRound_04_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_03 : TriggerState {
            internal StateRound_04_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_04 : TriggerState {
            internal StateRound_04_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_05 : TriggerState {
            internal StateRound_04_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {411}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_06 : TriggerState {
            internal StateRound_04_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {413}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_07 : TriggerState {
            internal StateRound_04_Random_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {298}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {215}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {211}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {214}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {213}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {212}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_08 : TriggerState {
            internal StateRound_04_Random_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {299}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {216}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {217}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {220}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {218}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {219}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_06(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_07(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_05_Random_08(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_01 : TriggerState {
            internal StateRound_05_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_02 : TriggerState {
            internal StateRound_05_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_03 : TriggerState {
            internal StateRound_05_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {206}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {207}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {205}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_04 : TriggerState {
            internal StateRound_05_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {209}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {210}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {208}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_05 : TriggerState {
            internal StateRound_05_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {411}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {410}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {411}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_06 : TriggerState {
            internal StateRound_05_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {413}, arg2: true, arg3: 1500);
                context.CreateMonster(arg1: new[] {412}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {413}, arg2: true, arg3: 4500);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_07 : TriggerState {
            internal StateRound_05_Random_07(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {298}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {215}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {211}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {214}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {213}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {212}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_08 : TriggerState {
            internal StateRound_05_Random_08(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {299}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {216}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {217}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {220}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {218}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {219}, arg2: true, arg3: 4000);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_05(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.GetUserValue(key: "Reset") == 1) {
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