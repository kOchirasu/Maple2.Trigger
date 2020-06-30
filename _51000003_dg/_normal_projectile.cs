using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _normal_projectile {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateRound_check(context);

        private class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 351, 352, 353, 354, 355, 356, 357, 358,
                    359, 360, 361, 362
                });
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_01", value: 1)) {
                    context.State = new StateRound_01(context);
                    return;
                }

                if (context.UserValue(key: "Round_02", value: 1)) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Round_04", value: 1)) {
                    context.State = new StateRound_04(context);
                    return;
                }

                if (context.UserValue(key: "Round_05", value: 1)) {
                    // context.State = new StateRound_05(context);
                    return;
                }

                if (context.UserValue(key: "Round_06", value: 1)) {
                    // context.State = new StateRound_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_01 : TriggerState {
            internal StateRound_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {354}, arg2: true, arg3: 700);
                context.CreateMonster(arg1: new int[] {355}, arg2: true, arg3: 1400);
                context.CreateMonster(arg1: new int[] {362}, arg2: true, arg3: 2100);
                context.CreateMonster(arg1: new int[] {361}, arg2: true, arg3: 0);
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_02", value: 1)) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02 : TriggerState {
            internal StateRound_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {352}, arg2: true, arg3: 2000);
                context.CreateMonster(arg1: new int[] {360}, arg2: true, arg3: 1000);
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_03", value: 1)) {
                    context.State = new StateRound_03(context);
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {359}, arg2: true, arg3: 0);
                context.CreateMonster(arg1: new int[] {351}, arg2: true, arg3: 1500);
            }

            public override void Execute() {
                if (context.UserValue(key: "Round_04", value: 1)) {
                    context.State = new StateRound_04(context);
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

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {353}, arg2: true, arg3: 1000);
                context.CreateMonster(arg1: new int[] {358}, arg2: true, arg3: 2000);
            }

            public override void Execute() {
                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.DestroyMonster(arg1: new int[] {
                    301, 302, 303, 304, 305, 306, 307, 308, 309, 310, 311, 312, 351, 352, 353, 354, 355, 356, 357, 358,
                    359, 360, 361, 362
                });
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}