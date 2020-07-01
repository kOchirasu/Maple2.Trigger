namespace Maple2.Trigger._63000050_cs {
    public static class _tria_seige_ready {
        public class Statestart : TriggerState {
            internal Statestart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {20002263}, arg3: new byte[] {3})) {
                    return new State트라이아침공전시작(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {20002263}, arg3: new byte[] {2})) {
                    return new State트라이아방공호로(context);
                }

                if (context.QuestUserDetected(arg1: new[] {1000}, arg2: new[] {20002263}, arg3: new byte[] {1})) {
                    return new State트라이아침공전시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아침공전시작 : TriggerState {
            internal State트라이아침공전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000068, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아방공호로 : TriggerState {
            internal State트라이아방공호로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(arg1: 52000069, arg2: 1);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}