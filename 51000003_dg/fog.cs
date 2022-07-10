namespace Maple2.Trigger._51000003_dg {
    public static class _fog {
        public class StateRound_check : TriggerState {
            internal StateRound_check(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001, 7002, 7003, 7004, 7005}, visible: false);
                context.SetEffect(triggerIds: new []{7010}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_01") == 1) {
                    // return new StateRound_01(context);
                    return null;
                }

                if (context.GetUserValue(key: "Round_02") == 1) {
                    return new StateRound_02_Ready(context);
                }

                if (context.GetUserValue(key: "Round_03") == 1) {
                    return new StateRound_03_Ready(context);
                }

                if (context.GetUserValue(key: "Round_04") == 1) {
                    return new StateRound_04_Ready(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Ready : TriggerState {
            internal StateRound_02_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRound_02_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Ready : TriggerState {
            internal StateRound_03_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRound_03_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Ready : TriggerState {
            internal StateRound_04_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRound_04_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Ready : TriggerState {
            internal StateRound_05_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRound_05_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Ready : TriggerState {
            internal StateRound_06_Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateRound_06_Start(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_02_Start : TriggerState {
            internal StateRound_02_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7001}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_02") == 0) {
                    return new StateRound_check(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_03_Start : TriggerState {
            internal StateRound_03_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_03") == 0) {
                    return new StateRound_check(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_04_Start : TriggerState {
            internal StateRound_04_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7002}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_04") == 0) {
                    return new StateRound_check(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_05_Start : TriggerState {
            internal StateRound_05_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7003}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_05") == 0) {
                    return new StateRound_check(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateRound_06_Start : TriggerState {
            internal StateRound_06_Start(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{7005}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "Round_06") == 0) {
                    return new StateRound_check(context);
                }

                if (context.WaitTick(waitTick: 30000)) {
                    return new StateRound_check(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
