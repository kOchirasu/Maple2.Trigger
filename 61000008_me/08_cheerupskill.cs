namespace Maple2.Trigger._61000008_me {
    public static class _08_cheerupskill {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
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
                context.SetTimer(arg1: "1", arg2: 30, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
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
                context.SetTimer(arg1: "1", arg2: 20, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
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
                context.SetTimer(arg1: "1", arg2: 15, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
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
                context.SetTimer(arg1: "1", arg2: 10, arg3: true, arg4: false);
            }

            public override TriggerState Execute() {
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
                context.AddBuff(arg1: new[] {9001}, arg2: 70000086, arg3: 1, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
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
                context.ResetTimer(arg1: "1");
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}