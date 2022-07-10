namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile_02 {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(spawnIds: new []{421, 422, 423, 424, 425, 426, 427, 428, 429, 430});
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_00") == 1) {
                    return new StateRound_00_Ready(context);
                }

                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01_Ready(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03_Ready(context);
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04_Ready(context);
                }

                if (context.GetUserValue(key: "Round_05") == 1) {
                    return new StateRound_05_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_00_Ready : TriggerState {
            internal StateRound_00_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateRound_00(context);
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

        private class StateRound_03_Ready : TriggerState {
            internal StateRound_03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    // return new StateRound_03(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Ready : TriggerState {
            internal StateRound_04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateRound_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Ready : TriggerState {
            internal StateRound_05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 9000)) {
                    return new StateRound_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_00 : TriggerState {
            internal StateRound_00(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_00_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_00_Random_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_00_Random_01 : TriggerState {
            internal StateRound_00_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{403}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_00(context);
                }

                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_00_Random_02 : TriggerState {
            internal StateRound_00_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{404}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_00(context);
                }

                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
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

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{401}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
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
                context.CreateMonster(spawnIds: new []{402}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
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
                context.CreateMonster(spawnIds: new []{403}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
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
                context.CreateMonster(spawnIds: new []{404}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02 : TriggerState {
            internal StateRound_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_02_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_02_Random_02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_02_Random_03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_02_Random_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_01 : TriggerState {
            internal StateRound_02_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{405, 406}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_02 : TriggerState {
            internal StateRound_02_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{407, 408}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_03 : TriggerState {
            internal StateRound_02_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{410, 411}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_04 : TriggerState {
            internal StateRound_02_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{412, 413}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04 : TriggerState {
            internal StateRound_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_04_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_04_Random_02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_04_Random_03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_04_Random_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_01 : TriggerState {
            internal StateRound_04_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{408}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_02 : TriggerState {
            internal StateRound_04_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{406}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_03 : TriggerState {
            internal StateRound_04_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{403}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Random_04 : TriggerState {
            internal StateRound_04_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{405}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_04") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05 : TriggerState {
            internal StateRound_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_05_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_05_Random_02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_05_Random_03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_05_Random_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_01 : TriggerState {
            internal StateRound_05_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{408}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_05(context);
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_02 : TriggerState {
            internal StateRound_05_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{406}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_05(context);
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_03 : TriggerState {
            internal StateRound_05_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{403}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_05(context);
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Random_04 : TriggerState {
            internal StateRound_05_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{405}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "9", seconds: 9);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "9")) {
                    return new StateRound_05(context);
                }

                if (context.GetUserValue(key: "Round_05") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06 : TriggerState {
            internal StateRound_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_06_Random_01(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_06_Random_02(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_06_Random_03(context);
                }

                if (context.RandomCondition(rate: 1f)) {
                    return new StateRound_06_Random_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_01 : TriggerState {
            internal StateRound_06_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{421}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{422}, arg2: true, arg3: 2000);
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateRound_06(context);
                }

                if (context.GetUserValue(key: "Round_06") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_02 : TriggerState {
            internal StateRound_06_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{423}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{424}, arg2: true, arg3: 2000);
                context.CreateMonster(spawnIds: new []{425}, arg2: true, arg3: 0);
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateRound_06(context);
                }

                if (context.GetUserValue(key: "Round_06") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_03 : TriggerState {
            internal StateRound_06_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{426}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{427}, arg2: true, arg3: 2000);
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateRound_06(context);
                }

                if (context.GetUserValue(key: "Round_06") == 0) {
                    return new StateRound_check(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Random_04 : TriggerState {
            internal StateRound_06_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{428}, arg2: true, arg3: 0);
                context.CreateMonster(spawnIds: new []{429}, arg2: true, arg3: 2000);
                context.SetTimer(timerId: "7", seconds: 7);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "7")) {
                    return new StateRound_06(context);
                }

                if (context.GetUserValue(key: "Round_06") == 0) {
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
