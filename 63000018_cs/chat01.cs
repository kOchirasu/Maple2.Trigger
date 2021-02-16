namespace Maple2.Trigger._63000018_cs {
    public static class _chat01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new[] {101, 102}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateChat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChat01 : TriggerState {
            internal StateChat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, script: "$63000018_CS__CHAT01__0$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, script: "$63000018_CS__CHAT01__1$", arg4: 4, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 101, script: "$63000018_CS__CHAT01__2$", arg4: 4, arg5: 8);
                context.SetConversation(arg1: 1, arg2: 102, script: "$63000018_CS__CHAT01__3$", arg4: 4, arg5: 12);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {9900})) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 20000)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}