using System;

namespace Maple2.Trigger._52000002_qd {
    public static class _stage01 {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new State시작대기중(context);

        private class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: "102")) {
                    context.State = new State안내시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: "101")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityID: 25200204, textID: 25200204);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new int[] {10000607, 10000608, 10000609, 10000610, 10000611},
                    arg2: 0)) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: "101")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityID: 25200204);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: "101")) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}