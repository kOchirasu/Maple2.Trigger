using System;

namespace Maple2.Trigger._63000018_cs {
    public static class _chat03 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {301, 302}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: "9900")) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.WaitTick(waitTick: 20000)) {
                    context.State = new StateChat01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChat01 : TriggerState {
            internal StateChat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$63000018_CS__CHAT03__0$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$63000018_CS__CHAT03__1$", arg4: 4, arg5: 4);
                context.SetConversation(arg1: 1, arg2: 301, arg3: "$63000018_CS__CHAT03__2$", arg4: 4, arg5: 8);
                context.SetConversation(arg1: 1, arg2: 302, arg3: "$63000018_CS__CHAT03__3$", arg4: 4, arg5: 12);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 16000)) {
                    context.State = new StateDelay02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "9900")) {
                    context.State = new StateDelay01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}