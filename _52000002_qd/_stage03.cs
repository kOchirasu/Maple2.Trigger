namespace Maple2.Trigger._52000002_qd {
    public static class _stage03 {
        public class State시작대기중 : TriggerState {
            internal State시작대기중(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {601}, arg2: false);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000612, 10000613, 10000614, 10000615, 10000616},
                    arg2: 2)) {
                    context.State = new State박스체크(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State박스체크 : TriggerState {
            internal State박스체크(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    context.State = new State안내시작(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State안내시작 : TriggerState {
            internal State안내시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 25200206, textId: 25200206);
                context.SetTimer(arg1: "10", arg2: 10);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {105})) {
                    context.State = new State종료(context);
                    return;
                }

                if (!context.UserDetected(arg1: new[] {101})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.HideGuideSummary(entityId: 25200206);
            }

            public override void Execute() {
                if (!context.UserDetected(arg1: new[] {101})) {
                    context.State = new State시작대기중(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}