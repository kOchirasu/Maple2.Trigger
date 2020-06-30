using System;

namespace Maple2.Trigger._52100110_qd {
    public static class _52100110_1 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State52100110_1Ready(context);

        private class State52100110_1Ready : TriggerState {
            internal State52100110_1Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "1000")) {
                    context.State = new State52100110_1화이트박스생성(context);
                    return;
                }

                if (context.UserDetected(arg1: "2000")) {
                    context.State = new State52100110_1화이트박스생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스생성 : TriggerState {
            internal State52100110_1화이트박스생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new int[] {601}, arg2: true);
                context.SetMesh(arg1: new int[] {10000}, arg2: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State52100110_1퀘스트체크(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State52100110_1퀘스트체크 : TriggerState {
            internal State52100110_1퀘스트체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {2000}, arg2: new int[] {50101040},
                    arg3: new byte[] {1})) {
                    context.State = new State52100110_1화이트박스제거(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스제거 : TriggerState {
            internal State52100110_1화이트박스제거(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new int[] {10000}, arg2: false);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // context.State = new State(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}