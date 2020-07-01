namespace Maple2.Trigger._02000420_bf {
    public static class _left201 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {201})) {
                    context.State = new State왼쪽지점견제(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽지점견제 : TriggerState {
            internal State왼쪽지점견제(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "LeftPositionCheck", value: 1);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {201})) {
                    context.State = new State왼쪽지점견제풀기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State왼쪽지점견제풀기 : TriggerState {
            internal State왼쪽지점견제풀기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetAiExtraData(key: "LeftPositionCheck", value: 0);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 500)) {
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}