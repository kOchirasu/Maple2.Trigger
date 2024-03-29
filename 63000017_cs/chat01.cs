namespace Maple2.Trigger._63000017_cs {
    public static class _chat01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.CreateMonster(spawnIds: new []{101, 102, 103}, arg2: false);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay01 : TriggerState {
            internal StateDelay01(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateChat01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChat01 : TriggerState {
            internal StateChat01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000017_CS__CHAT01__0$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000017_CS__CHAT01__1$", arg4: 4, arg5: 5);
                context.SetConversation(type: 1, spawnId: 101, script: "$63000017_CS__CHAT01__2$", arg4: 4, arg5: 10);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000017_CS__CHAT01__3$", arg4: 4, arg5: 16);
                context.SetConversation(type: 1, spawnId: 103, script: "$63000017_CS__CHAT01__4$", arg4: 4, arg5: 20);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 25000)) {
                    return new StateDelay02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay02 : TriggerState {
            internal StateDelay02(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 4000)) {
                    return new StateChat02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateChat02 : TriggerState {
            internal StateChat02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetConversation(type: 1, spawnId: 101, script: "$63000017_CS__CHAT01__5$", arg4: 4, arg5: 0);
                context.SetConversation(type: 1, spawnId: 102, script: "$63000017_CS__CHAT01__6$", arg4: 4, arg5: 6);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 10000)) {
                    return new StateDelay03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay03 : TriggerState {
            internal StateDelay03(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{9900})) {
                    return new StateQuit(context);
                }

                if (context.WaitTick(waitTick: 5000)) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateQuit : TriggerState {
            internal StateQuit(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9900})) {
                    return new StateDelay01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
