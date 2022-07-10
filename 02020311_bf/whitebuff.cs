namespace Maple2.Trigger._02020311_bf {
    public static class _whitebuff {
        public class StateStart : TriggerState {
            internal StateStart(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(interactIds: new []{12000407}, state: 0);
                context.SetInteractObject(interactIds: new []{12000407}, state: 1);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{801})) {
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateStart(context);
                }

                if (context.UserDetected(boxIds: new []{801})) {
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCheckObject : TriggerState {
            internal StateCheckObject(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.ObjectInteracted(interactIds: new []{12000407}, arg2: 0)) {
                    return new State오브젝트재Creation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State오브젝트재Creation : TriggerState {
            internal State오브젝트재Creation(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.SetInteractObject(interactIds: new []{12000407}, state: 1);
                    return new StateCheckObject(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
