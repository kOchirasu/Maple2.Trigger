namespace Maple2.Trigger._02000049_bf {
    public static class _trigger_04 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10000270}, state: 1);
                context.SetEffect(triggerIds: new []{101}, visible: false);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000270}, arg2: 0)) {
                    return new State비내림(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State비내림 : TriggerState {
            internal State비내림(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(triggerIds: new []{101}, visible: true);
                context.SetTimer(timerId: "1", seconds: 10);
            }

            public override TriggerState? Execute() {
                if (context.TimeExpired(timerId: "1")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
