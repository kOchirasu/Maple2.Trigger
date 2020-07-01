namespace Maple2.Trigger._52000056_qd {
    public static class _guide {
        public class State가이드 : TriggerState {
            internal State가이드(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010001, textId: 10010001);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {103, 104, 105, 106})) {
                    return new State종료(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new State가이드(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010001);
            }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}