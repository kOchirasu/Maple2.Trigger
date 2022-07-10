namespace Maple2.Trigger._02000312_bf {
    public static class _filter_10 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "1stTreeRemove", value: 0);
                context.SetUserValue(key: "2ndTreeRemove", value: 0);
                context.SetUserValue(key: "3rdTreeRemove", value: 0);
                context.SetUserValue(key: "4thTreeRemove", value: 0);
                context.SetUserValue(key: "5thTreeRemove", value: 0);
                context.SetUserValue(key: "6thTreeRemove", value: 0);
                context.SetUserValue(key: "7thTreeRemove", value: 0);
                context.SetUserValue(key: "8thTreeRemove", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckStart : TriggerState {
            internal StateCheckStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateCheck01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck01 : TriggerState {
            internal StateCheck01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "1stTreeRemove") == 1) {
                    return new StateCheck02(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck02 : TriggerState {
            internal StateCheck02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "2ndTreeRemove") == 1) {
                    return new StateCheck03(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck03 : TriggerState {
            internal StateCheck03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "3rdTreeRemove") == 1) {
                    return new StateCheck04(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck04 : TriggerState {
            internal StateCheck04(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "4thTreeRemove") == 1) {
                    return new StateCheck05(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck05 : TriggerState {
            internal StateCheck05(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "5thTreeRemove") == 1) {
                    return new StateCheck06(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck06 : TriggerState {
            internal StateCheck06(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "6thTreeRemove") == 1) {
                    return new StateCheck07(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck07 : TriggerState {
            internal StateCheck07(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "7thTreeRemove") == 1) {
                    return new StateCheck08(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheck08 : TriggerState {
            internal StateCheck08(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "8thTreeRemove") == 1) {
                    return new StateBoardApp(context);
                }

                if (context.WaitTick(waitTick: 2000)) {
                    return new StateCheckStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBoardApp : TriggerState {
            internal StateBoardApp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(triggerId: 1, key: "BoardApp", value: 1);
                context.SetUserValue(triggerId: 11, key: "MobWaveStop", value: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
