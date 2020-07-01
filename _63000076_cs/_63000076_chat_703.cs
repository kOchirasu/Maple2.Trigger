namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_703 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new[] {703}, arg2: new[] {30000375},
                    arg3: new byte[] {1})) {
                    context.State = new State703잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_01 : TriggerState {
            internal State703잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 109, msg: "$63000076_CS__63000076_CHAT_703__0$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State703잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_02 : TriggerState {
            internal State703잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 113, msg: "$63000076_CS__63000076_CHAT_703__1$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State703잡담_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_03 : TriggerState {
            internal State703잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 109, msg: "$63000076_CS__63000076_CHAT_703__2$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State703잡담_04(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_04 : TriggerState {
            internal State703잡담_04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 110, msg: "$63000076_CS__63000076_CHAT_703__3$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    context.State = new State703잡담_05(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_05 : TriggerState {
            internal State703잡담_05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 112, msg: "$63000076_CS__63000076_CHAT_703__3$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State703잡담_06(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State703잡담_06 : TriggerState {
            internal State703잡담_06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 111, msg: "$63000076_CS__63000076_CHAT_703__5$", duration: 2000,
                    delayTick: 0);
                context.AddBalloonTalk(spawnPointId: 114, msg: "$63000076_CS__63000076_CHAT_703__5$", duration: 2000,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}