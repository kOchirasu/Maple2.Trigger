namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_708 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {708})) {
                    context.State = new State708잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State708잡담_01 : TriggerState {
            internal State708잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 108, msg: "$63000076_CS__63000076_CHAT_708__0$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State708잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State708잡담_02 : TriggerState {
            internal State708잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 115, msg: "$63000076_CS__63000076_CHAT_708__1$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State708잡담_03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State708잡담_03 : TriggerState {
            internal State708잡담_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 108, msg: "$63000076_CS__63000076_CHAT_708__2$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
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