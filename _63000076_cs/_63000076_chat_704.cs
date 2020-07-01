namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_704 {
        public class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {704})) {
                    return new State704잡담_01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State704잡담_01 : TriggerState {
            internal State704잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 107, msg: "$63000076_CS__63000076_CHAT_704__0$", duration: 2000, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2000)) {
                    return new State704잡담_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State704잡담_02 : TriggerState {
            internal State704잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointId: 105, msg: "$63000076_CS__63000076_CHAT_704__1$", duration: 2500, delayTick: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}