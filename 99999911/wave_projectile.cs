namespace Maple2.Trigger._99999911 {
    public static class _wave_projectile {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    // return new StateRound_03(context);
                    return null;
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    // return new StateRound_04(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_01(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_02(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_03(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_04(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_05(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_01_Random_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_05 : TriggerState {
            internal StateRound_01_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_06 : TriggerState {
            internal StateRound_01_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{402}, arg2: true);
                context.SetTimer(timerId: "4", seconds: 4);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "4")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_01") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02 : TriggerState {
            internal StateRound_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_01(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_02(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_03(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_04(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_05(context);
                }

                if (context.RandomCondition(rate: 1)) {
                    return new StateRound_02_Random_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_01 : TriggerState {
            internal StateRound_02_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{201}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{202}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_02 : TriggerState {
            internal StateRound_02_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{202}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{201}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_03 : TriggerState {
            internal StateRound_02_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{203}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{204}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_04 : TriggerState {
            internal StateRound_02_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{204}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{203}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_05 : TriggerState {
            internal StateRound_02_Random_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{401}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_06 : TriggerState {
            internal StateRound_02_Random_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{402}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{402}, arg2: true, arg3: 2);
                context.SetTimer(timerId: "6", seconds: 6);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "6")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
