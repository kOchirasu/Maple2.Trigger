namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_707 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{707})) {
                    return new State707잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State707잡담_01 : TriggerState {
            internal State707잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 119, msg: "$63000076_CS__63000076_CHAT_707__0$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State707잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State707잡담_02 : TriggerState {
            internal State707잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 119, msg: "$63000076_CS__63000076_CHAT_707__1$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
