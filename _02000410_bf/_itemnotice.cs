namespace Maple2.Trigger._02000410_bf {
    public static class _itemnotice {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserCount(boxId: 750) == 1) {
                    context.State = new State전투시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State전투시작 : TriggerState {
            internal State전투시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "ItemNotice01") == 1) {
                    context.State = new State필수아이템01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State필수아이템01 : TriggerState {
            internal State필수아이템01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041008, textId: 20041008);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State다음대기(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041008);
            }
        }

        private class State다음대기 : TriggerState {
            internal State다음대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.GetUserValue(key: "ItemNotice02") == 1) {
                    context.State = new State필수아이템02(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State필수아이템02 : TriggerState {
            internal State필수아이템02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 20041009, textId: 20041009);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 8000)) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 20041009);
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