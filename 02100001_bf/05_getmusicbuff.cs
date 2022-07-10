namespace Maple2.Trigger._02100001_bf {
    public static class _05_getmusicbuff {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GiveBuffSlowly", value: 0);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateGiveBuff01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGiveBuff01 : TriggerState {
            internal StateGiveBuff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 71000030, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateGiveBuff01(context);
                }

                if (context.GetUserValue(key: "GiveBuffSlowly") == 1) {
                    return new StateGiveBuff02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateGiveBuff02 : TriggerState {
            internal StateGiveBuff02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9901}, skillId: 71000030, level: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9901})) {
                    return new StateGiveBuff02(context);
                }

                if (context.GetUserValue(key: "GiveBuffSlowly") == 2) {
                    return new StateQuit(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(boxIds: new []{9900}, skillId: 71000034, level: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
