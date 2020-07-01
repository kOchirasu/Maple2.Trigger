namespace Maple2.Trigger._99999911 {
    public static class _wave_projectile {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    // context.State = new StateRound_03(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    // context.State = new StateRound_04(context);
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_01_Random_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_05 : TriggerState {
            internal StateRound_01_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_06 : TriggerState {
            internal StateRound_01_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {402}, arg2: true);
                context.SetTimer(arg1: "4", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "4")) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    context.State = new StateRound_check(context);
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

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_02_Random_05(context);
                    return;
                }

                if (context.RandomCondition(arg1: 1f)) {
                    context.State = new StateRound_02_Random_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_01 : TriggerState {
            internal StateRound_02_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {201}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {202}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_02 : TriggerState {
            internal StateRound_02_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {202}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {201}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_03 : TriggerState {
            internal StateRound_02_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {203}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {204}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_04 : TriggerState {
            internal StateRound_02_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {204}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {203}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_05 : TriggerState {
            internal StateRound_02_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {401}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {401}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_06 : TriggerState {
            internal StateRound_02_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {402}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new[] {402}, arg2: true, arg3: 2);
                context.SetTimer(arg1: "6", arg2: 6);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "6")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}