namespace Maple2.Trigger._02100001_bf {
    public static class _02_move {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001241}, state: 1);
                context.SetBreakable(triggerIds: new []{4500}, enabled: false);
                context.SetVisibleBreakableObject(triggerIds: new []{4500}, arg2: true);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001241}, arg2: 0)) {
                    return new StateMoveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveStart : TriggerState {
            internal StateMoveStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4500}, enabled: true);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 7000)) {
                    return new StateMoveStop(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateMoveStop : TriggerState {
            internal StateMoveStop(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetBreakable(triggerIds: new []{4500}, enabled: false);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateReset(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReset : TriggerState {
            internal StateReset(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{10001241}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{10001241}, arg2: 0)) {
                    return new StateMoveStart(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
