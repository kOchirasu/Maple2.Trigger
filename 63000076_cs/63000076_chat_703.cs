namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_703 {
        public class StateSetup : TriggerState {
            internal StateSetup(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{703}, questIds: new []{30000375}, questStates: new byte[]{1})) {
                    return new State703잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_01 : TriggerState {
            internal State703잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 109, msg: "$63000076_CS__63000076_CHAT_703__0$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State703잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_02 : TriggerState {
            internal State703잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 113, msg: "$63000076_CS__63000076_CHAT_703__1$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State703잡담_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_03 : TriggerState {
            internal State703잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 109, msg: "$63000076_CS__63000076_CHAT_703__2$", duration: 2500, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State703잡담_04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_04 : TriggerState {
            internal State703잡담_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 110, msg: "$63000076_CS__63000076_CHAT_703__3$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State703잡담_05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_05 : TriggerState {
            internal State703잡담_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 112, msg: "$63000076_CS__63000076_CHAT_703__3$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State703잡담_06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State703잡담_06 : TriggerState {
            internal State703잡담_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnId: 111, msg: "$63000076_CS__63000076_CHAT_703__5$", duration: 2000, delayTick: 0);
                context.AddBalloonTalk(spawnId: 114, msg: "$63000076_CS__63000076_CHAT_703__5$", duration: 2000, delayTick: 0);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 2000)) {
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
