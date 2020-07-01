namespace Maple2.Trigger._52000056_qd {
    public static class _guide {
        public class State가이드 : TriggerState {
            internal State가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010001, textId: 10010001);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {103, 104, 105, 106})) {
                    context.State = new State종료(context);
                    return;
                }

                if (context.WaitTick(waitTick: 3000)) {
                    context.State = new State가이드(context);
                    return;
                }
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010001);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}