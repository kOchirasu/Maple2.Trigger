using System;

namespace Maple2.Trigger._63000050_cs {
    public static class _tria_seige_ready {
        public static readonly Func<ITriggerContext, TriggerState> Start = context => new Statestart(context);

        private class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {20002263},
                    arg3: new byte[] {3})) {
                    context.State = new State트라이아침공전시작(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {20002263},
                    arg3: new byte[] {2})) {
                    context.State = new State트라이아방공호로(context);
                    return;
                }

                if (context.QuestUserDetected(arg1: new int[] {1000}, arg2: new int[] {20002263},
                    arg3: new byte[] {1})) {
                    context.State = new State트라이아침공전시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State트라이아침공전시작 : TriggerState {
            internal State트라이아침공전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000068, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }

        private class State트라이아방공호로 : TriggerState {
            internal State트라이아방공호로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000069, arg2: 1);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}