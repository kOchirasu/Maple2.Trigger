namespace Maple2.Trigger._52000056_qd {
    public static class _guide {
        public class StateGuide : TriggerState {
            internal StateGuide(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.ShowGuideSummary(entityId: 10010001, textId: 10010001);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{103, 104, 105, 106})) {
                    return new StateEnd(context);
                }

                if (context.WaitTick(waitTick: 3000)) {
                    return new StateGuide(context);
                }

                return null;
            }

            public override void OnExit() {
                context.HideGuideSummary(entityId: 10010001);
            }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}
