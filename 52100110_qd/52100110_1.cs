namespace Maple2.Trigger._52100110_qd {
    public static class _52100110_1 {
        public class State52100110_1Ready : TriggerState {
            internal State52100110_1Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{1000})) {
                    return new State52100110_1화이트박스Creation(context);
                }

                if (context.UserDetected(boxIds: new []{2000})) {
                    return new State52100110_1화이트박스Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스Creation : TriggerState {
            internal State52100110_1화이트박스Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{601}, visible: true);
                context.SetMesh(triggerIds: new []{10000}, visible: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new State52100110_1Quest체크(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100110_1Quest체크 : TriggerState {
            internal State52100110_1Quest체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.QuestUserDetected(boxIds: new []{2000}, questIds: new []{50101040}, questStates: new byte[]{1})) {
                    return new State52100110_1화이트박스Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스Remove : TriggerState {
            internal State52100110_1화이트박스Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{10000}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    // return new State(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
