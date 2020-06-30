using System;

namespace Maple2.Trigger._02000427_bf {
    public static class _message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State전투시작(context);

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Message", value: 1)) {
                    context.State = new State메시지출력01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력01 : TriggerState {
            internal State메시지출력01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20042001, textID: 20042001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State메시지출력02대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20042001);
            }
        }

        private class State메시지출력02대기 : TriggerState {
            internal State메시지출력02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Message", value: 2)) {
                    context.State = new State메시지출력02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력02 : TriggerState {
            internal State메시지출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20042002, textID: 20042002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State메시지출력03대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20042002);
            }
        }

        private class State메시지출력03대기 : TriggerState {
            internal State메시지출력03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserValue(key: "Message", value: 3)) {
                    context.State = new State메시지출력03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력03 : TriggerState {
            internal State메시지출력03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 20042003, textID: 20042003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 20042003);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}