namespace Maple2.Trigger._02020011_bf {
    public static class _block {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: true, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{101})) {
                    return new StateDelay(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay : TriggerState {
            internal StateDelay(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new State사라짐(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State사라짐 : TriggerState {
            internal State사라짐(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3000, 3001}, visible: false, arg5: 5f);
            }

            public override TriggerState? Execute() {
                if (!context.UserDetected(boxIds: new []{101})) {
                    return new StateDelay2(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateDelay2 : TriggerState {
            internal StateDelay2(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1500)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
