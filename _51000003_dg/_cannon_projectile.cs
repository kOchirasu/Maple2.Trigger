namespace Maple2.Trigger._51000003_dg {
    public static class _cannon_projectile {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115, 116, 117, 118});
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    return new StateRound_01(context);
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02(context);
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03(context);
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04(context);
                }

                if (context.GetUserValue(key: "Round_05") == 1) {
                    return new StateRound_05(context);
                }

                if (context.GetUserValue(key: "Round_06") == 1) {
                    return new StateRound_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {113}, arg2: true, arg3: 600);
                context.CreateMonster(arg1: new[] {118}, arg2: true, arg3: 1500);
            }

            public override TriggerState Execute() {
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {114}, arg2: true, arg3: 700);
                context.CreateMonster(arg1: new[] {117}, arg2: true, arg3: 1100);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03(context);
                }

                if (context.GetUserValue(key: "Reset") == 1) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_03 : TriggerState {
            internal StateRound_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {112}, arg2: true, arg3: 800);
                context.CreateMonster(arg1: new[] {116}, arg2: true, arg3: 1300);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04(context);
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {111}, arg2: true, arg3: 300);
                context.CreateMonster(arg1: new[] {115}, arg2: true, arg3: 900);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_05") == 1) {
                    return new StateRound_05(context);
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

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {111, 112, 113, 114, 115, 116, 117, 118});
                context.CreateMonster(arg1: new[] {101}, arg2: true, arg3: 1000);
                context.CreateMonster(arg1: new[] {102}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new[] {103}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {104}, arg2: true, arg3: 4000);
                context.CreateMonster(arg1: new[] {105}, arg2: true, arg3: 5000);
                context.CreateMonster(arg1: new[] {106}, arg2: true, arg3: 6000);
                context.CreateMonster(arg1: new[] {107}, arg2: true, arg3: 7000);
                context.CreateMonster(arg1: new[] {108}, arg2: true, arg3: 0);
            }

            public override TriggerState Execute() {
                if (context.GetUserValue(key: "Round_06") == 1) {
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {121}, arg2: true, arg3: 1000);
                context.CreateMonster(arg1: new[] {122}, arg2: true, arg3: 3000);
                context.CreateMonster(arg1: new[] {123}, arg2: true, arg3: 5000);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    // return new StateRound_06_02(context);
                    return null;
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

            public override void OnEnter() {
                context.DestroyMonster(arg1: new[] {101, 102, 103, 104, 105, 106, 107, 108, 111, 112, 113, 114, 115, 116, 117, 118});
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}