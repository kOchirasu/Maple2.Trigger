namespace Maple2.Trigger._63000050_cs {
    public static class _tria_seige_ready {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{20002263}, questStates: new byte[]{3})) {
                    return new State트라이아침공전시작(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{20002263}, questStates: new byte[]{2})) {
                    return new State트라이아방공호로(context);
                }

                if (context.QuestUserDetected(boxIds: new []{1000}, questIds: new []{20002263}, questStates: new byte[]{1})) {
                    return new State트라이아침공전시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아침공전시작 : TriggerState {
            internal State트라이아침공전시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000068, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }

        private class State트라이아방공호로 : TriggerState {
            internal State트라이아방공호로(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.MoveUser(mapId: 52000069, portalId: 1);
            }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
