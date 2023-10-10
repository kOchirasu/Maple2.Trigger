namespace Maple2.Trigger._66200001_gd {
    public static class _08_cheerupskill {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.GetUserValue(key: "CheerUpTimer") == 1) {
                    return new StateCheerUpTimer_20(context);
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
