namespace Maple2.Trigger._02000022_bf {
    public static class _ia_101 {
        public class StateWaitStart : TriggerState {
            internal StateWaitStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 101, visible: false, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                return new StateInteractObject(context);
            }

            public override void OnExit() { }
        }

        private class StateInteractObject : TriggerState {
            internal StateInteractObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000090}, arg2: 0)) {
                    return new State개구리보이기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State개구리보이기 : TriggerState {
            internal State개구리보이기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetActor(triggerId: 101, visible: true, initialSequence: "Idle_A");
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10000090}, arg2: 1)) {
                    return new StateWaitStart(context);
                }

                return null;
            }

            public override void OnExit() {
                context.SetActor(triggerId: 101, visible: false, initialSequence: "Idle_A");
            }
        }
    }
}
