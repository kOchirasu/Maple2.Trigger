namespace Maple2.Trigger._02000142_bf {
    public static class _trigger_01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{7000}, enabled: false);
                context.SetInteractObject(interactIds: new []{10000245}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000245}, arg2: 0)) {
                    return new State이동(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State이동 : TriggerState {
            internal State이동(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(timerId: "1", seconds: 15, clearAtZero: false);
                context.SetBreakable(triggerIds: new []{7000}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() {
                context.ResetTimer(timerId: "1");
            }
        }
    }
}
