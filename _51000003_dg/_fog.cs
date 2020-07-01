namespace Maple2.Trigger._51000003_dg {
    public static class _fog {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: false);
                context.SetEffect(arg1: new[] {7002}, arg2: false);
                context.SetEffect(arg1: new[] {7003}, arg2: false);
                context.SetEffect(arg1: new[] {7004}, arg2: false);
                context.SetEffect(arg1: new[] {7005}, arg2: false);
                context.SetEffect(arg1: new[] {7010}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    // context.State = new StateRound_01(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    context.State = new StateRound_02_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    context.State = new StateRound_03_Ready(context);
                    return;
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    context.State = new StateRound_04_Ready(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Ready : TriggerState {
            internal StateRound_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new StateRound_02_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Ready : TriggerState {
            internal StateRound_03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new StateRound_03_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Ready : TriggerState {
            internal StateRound_04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new StateRound_04_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Ready : TriggerState {
            internal StateRound_05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new StateRound_05_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Ready : TriggerState {
            internal StateRound_06_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    context.State = new StateRound_06_Start(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Start : TriggerState {
            internal StateRound_02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7001}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_02") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Start : TriggerState {
            internal StateRound_03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_03") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Start : TriggerState {
            internal StateRound_04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7002}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_04") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Start : TriggerState {
            internal StateRound_05_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7003}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_05") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Start : TriggerState {
            internal StateRound_06_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {7005}, arg2: true);
            }

            public override void Execute() {
                if (context.GetUserValue(key: "Round_06") == 0) {
                    context.State = new StateRound_check(context);
                    return;
                }

                if (context.WaitTick(waitTick: 30000)) {
                    context.State = new StateRound_check(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}