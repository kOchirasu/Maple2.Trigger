namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_702 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{702}, questIds: new []{30000375}, questStates: new byte[]{1})) {
                    return new State702잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702잡담_01 : TriggerState {
            internal State702잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 103, msg: "$63000076_CS__63000076_CHAT_702__0$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State702잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702잡담_02 : TriggerState {
            internal State702잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 101, msg: "$63000076_CS__63000076_CHAT_702__1$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State702잡담_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State702잡담_03 : TriggerState {
            internal State702잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 102, msg: "$63000076_CS__63000076_CHAT_702__2$", duration: 3000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 3000)) {
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
