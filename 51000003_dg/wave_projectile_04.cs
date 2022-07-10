namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile_04 {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{421, 422, 423, 424, 425, 426, 427, 428, 429, 430});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Ready : TriggerState {
            internal StateRound_01_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateRound_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_01_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_01_Random_02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_01_Random_03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_01_Random_04(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_01_Random_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{216}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{217}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{218}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{219}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_05 : TriggerState {
            internal StateRound_01_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{220}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
