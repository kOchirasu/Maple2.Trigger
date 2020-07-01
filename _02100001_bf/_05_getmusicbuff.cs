namespace Maple2.Trigger._02100001_bf {
    public static class _05_getmusicbuff {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetUserValue(key: "GiveBuffSlowly", value: 0);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    context.State = new StateGiveBuff01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGiveBuff01 : TriggerState {
            internal StateGiveBuff01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 71000030, arg3: 1);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateGiveBuff01(context);
                    return;
                }

                if (context.GetUserValue(key: "GiveBuffSlowly") == 1) {
                    context.State = new StateGiveBuff02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateGiveBuff02 : TriggerState {
            internal StateGiveBuff02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9901}, arg2: 71000030, arg3: 1);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9901})) {
                    context.State = new StateGiveBuff02(context);
                    return;
                }

                if (context.GetUserValue(key: "GiveBuffSlowly") == 2) {
                    context.State = new StateQuit(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {9900}, arg2: 71000034, arg3: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}