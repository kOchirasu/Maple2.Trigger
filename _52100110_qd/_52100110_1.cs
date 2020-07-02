namespace Maple2.Trigger._52100110_qd {
    public static class _52100110_1 {
        public class State52100110_1Ready : TriggerState {
            internal State52100110_1Ready(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {1000})) {
                    return new State52100110_1화이트박스Creation(context);
                }

                if (context.UserDetected(arg1: new[] {2000})) {
                    return new State52100110_1화이트박스Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스Creation : TriggerState {
            internal State52100110_1화이트박스Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: true);
                context.SetMesh(arg1: new[] {10000}, arg2: true);
            }

            public override TriggerState Execute() {
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

            public override TriggerState Execute() {
                if (context.QuestUserDetected(arg1: new[] {2000}, arg2: new[] {50101040}, arg3: new byte[] {1})) {
                    return new State52100110_1화이트박스Remove(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State52100110_1화이트박스Remove : TriggerState {
            internal State52100110_1화이트박스Remove(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {10000}, arg2: false);
            }

            public override TriggerState Execute() {
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