using System;

namespace Maple2.Trigger._63000076_cs {
    public static class _63000076_chat_707 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State준비(context);

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new int[] {707})) {
                    context.State = new State707잡담_01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State707잡담_01 : TriggerState {
            internal State707잡담_01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 119, msg: "$63000076_CS__63000076_CHAT_707__0$", duration: 2500,
                    delayTick: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 2500)) {
                    context.State = new State707잡담_02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State707잡담_02 : TriggerState {
            internal State707잡담_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBalloonTalk(spawnPointID: 119, msg: "$63000076_CS__63000076_CHAT_707__1$", duration: 2500,
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