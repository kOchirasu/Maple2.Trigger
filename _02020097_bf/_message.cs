using System;

namespace Maple2.Trigger._02020097_bf {
    public static class _message {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "10")) {
                    context.State = new State대기상태(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State대기상태 : TriggerState {
            internal State대기상태(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "12")) {
                    context.State = new State경비병도움안내(context);
                    return;
                }

                if (context.UserValue(key: "StairsOk2nd", value: 1)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State경비병도움안내 : TriggerState {
            internal State경비병도움안내(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 29200001, textID: 29200001);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    context.State = new State트리거종료(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityID: 29200001);
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