using System;

namespace Maple2.Trigger._63000017_cs {
    public static class _chat01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new StateWait(context);

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(arg1: new int[] {101, 102, 103}, arg2: false);
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
                if (context.WaitTick(waitTick: 15000)) {
                    context.State = new StateChat01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChat01 : TriggerState {
            internal StateChat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000017_CS__CHAT01__0$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000017_CS__CHAT01__1$", arg4: 4, arg5: 5);
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000017_CS__CHAT01__2$", arg4: 4, arg5: 10);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000017_CS__CHAT01__3$", arg4: 4, arg5: 16);
                context.SetConversation(arg1: 1, arg2: 103, arg3: "$63000017_CS__CHAT01__4$", arg4: 4, arg5: 20);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 25000)) {
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
                if (context.WaitTick(waitTick: 4000)) {
                    context.State = new StateChat02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateChat02 : TriggerState {
            internal StateChat02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(arg1: 1, arg2: 101, arg3: "$63000017_CS__CHAT01__5$", arg4: 4, arg5: 0);
                context.SetConversation(arg1: 1, arg2: 102, arg3: "$63000017_CS__CHAT01__6$", arg4: 4, arg5: 6);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    context.State = new StateDelay03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (!context.UserDetected(arg1: "9900")) {
                    context.State = new StateQuit(context);
                    return;
                }

                if (context.WaitTick(waitTick: 5000)) {
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