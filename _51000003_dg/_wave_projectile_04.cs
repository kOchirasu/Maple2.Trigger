namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile_04 {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {421, 422, 423, 424, 425, 426, 427, 428, 429, 430});
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    context.State = new StateRound_01_Ready(context);
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
                context.CreateMonster(arg1: new[] {216}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
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
                context.CreateMonster(arg1: new[] {217}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
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
                context.CreateMonster(arg1: new[] {218}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
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
                context.CreateMonster(arg1: new[] {219}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
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

        private class StateRound_01_Random_05 : TriggerState {
            internal StateRound_01_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {220}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
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

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}