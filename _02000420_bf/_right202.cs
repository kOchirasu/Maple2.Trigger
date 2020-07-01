namespace Maple2.Trigger._02000420_bf {
    public static class _right202 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {202})) {
                    return new State오른쪽지점견제(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오른쪽지점견제 : TriggerState {
            internal State오른쪽지점견제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "RightPositionCheck", value: 1);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {202})) {
                    return new State오른쪽지점견제풀기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오른쪽지점견제풀기 : TriggerState {
            internal State오른쪽지점견제풀기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "RightPositionCheck", value: 0);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    return new State시작(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}