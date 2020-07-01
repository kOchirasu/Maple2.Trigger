namespace Maple2.Trigger._02000420_bf {
    public static class _message {
        public class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Message") == 1) {
                    context.State = new State메시지출력01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력01 : TriggerState {
            internal State메시지출력01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042001, textId: 20042001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State메시지출력02대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042001);
            }
        }

        private class State메시지출력02대기 : TriggerState {
            internal State메시지출력02대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Message") == 2) {
                    context.State = new State메시지출력02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력02 : TriggerState {
            internal State메시지출력02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042002, textId: 20042002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State메시지출력03대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042002);
            }
        }

        private class State메시지출력03대기 : TriggerState {
            internal State메시지출력03대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "Message") == 3) {
                    context.State = new State메시지출력03(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State메시지출력03 : TriggerState {
            internal State메시지출력03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20042003, textId: 20042003);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20042003);
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