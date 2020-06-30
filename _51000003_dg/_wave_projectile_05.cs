using System;

namespace Maple2.Trigger._51000003_dg {
    public static class _wave_projectile_05 {
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
            }

            public override void OnExit() { }
        }

        private class StateRound_01_Random_01 : TriggerState {
            internal StateRound_01_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {296}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

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

        private class StateRound_01_Random_02 : TriggerState {
            internal StateRound_01_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {297}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

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

        private class StateRound_01_Random_03 : TriggerState {
            internal StateRound_01_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {298}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

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

        private class StateRound_01_Random_04 : TriggerState {
            internal StateRound_01_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {299}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "9", arg2: 9);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "9")) {
                    context.State = new StateRound_01(context);
                    return;
                }

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
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_01 : TriggerState {
            internal StateRound_02_Random_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {414}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    // context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_02 : TriggerState {
            internal StateRound_02_Random_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {415}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    // context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_03 : TriggerState {
            internal StateRound_02_Random_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {416}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    // context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Random_04 : TriggerState {
            internal StateRound_02_Random_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {417}, arg2: true, arg3: 0);
                context.SetTimer(arg1: "7", arg2: 7);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "7")) {
                    context.State = new StateRound_02(context);
                    return;
                }

                if (context.UserValue(key: "Round_03", value: 1)) {
                    // context.State = new StateRound_03(context);
                    return;
                }

                if (context.UserValue(key: "Reset", value: 1)) {
                    context.State = new StateEnd(context);
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