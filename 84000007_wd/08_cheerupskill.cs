namespace Maple2.Trigger._84000007_wd {
    public static class _08_cheerupskill {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CheerUpTimer") == 1) {
                    return new StateCheerUpTimer_30(context);
                }

                if (context.GetUserValue(key: "CheerUpTimer") == 2) {
                    return new StateCheerUpTimer_20(context);
                }

                if (context.GetUserValue(key: "CheerUpTimer") == 3) {
                    return new StateCheerUpTimer_15(context);
                }

                if (context.GetUserValue(key: "CheerUpTimer") == 4) {
                    return new StateCheerUpTimer_10(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheerUpTimer_30 : TriggerState {
            internal StateCheerUpTimer_30(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 30, autoRemove: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 26000)) {
                    return new StateGiveCheerUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheerUpTimer_20 : TriggerState {
            internal StateCheerUpTimer_20(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 20, autoRemove: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateGiveCheerUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheerUpTimer_15 : TriggerState {
            internal StateCheerUpTimer_15(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, autoRemove: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 11000)) {
                    return new StateGiveCheerUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheerUpTimer_10 : TriggerState {
            internal StateCheerUpTimer_10(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 10, autoRemove: true, display: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 6000)) {
                    return new StateGiveCheerUp(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGiveCheerUp : TriggerState {
            internal StateGiveCheerUp(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9001}, skillId: 70000086, level: 1, arg4: false, arg5: false);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "CheerUpTimer", value: 0);
                context.ResetTimer(timerId: "1");
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
