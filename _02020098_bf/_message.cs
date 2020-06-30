using System;

namespace Maple2.Trigger._02020098_bf {
    public static class _message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "11")) {
                    context.State = new State크리스탈활용안내메시지출력(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State크리스탈활용안내메시지출력 : TriggerState {
            internal State크리스탈활용안내메시지출력(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 29200002, textID: 29200002);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 6300)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 29200002);
            }
        }

        private class State트리거종료 : TriggerState {
            internal State트리거종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}