namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_705 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {705})) {
                    context.State = new State705잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State705잡담_01 : TriggerState {
            internal State705잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 116, msg: "$63000076_CS__63000076_CHAT_705__0$", duration: 2500, delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State705잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State705잡담_02 : TriggerState {
            internal State705잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 117, msg: "$63000076_CS__63000076_CHAT_705__1$", duration: 2500, delayTick: 0);
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