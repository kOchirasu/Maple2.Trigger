namespace Maple2.Trigger._02100001_bf {
    public static class _06_bridge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3300, 3301, 3302}, visible: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState? Execute() {
                if (context.UserDetected(boxIds: new []{9300}) && context.UserDetected(boxIds: new []{9301})) {
                    return new StateBridgeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBridgeOn : TriggerState {
            internal StateBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3300, 3301, 3302}, visible: true, arg3: 300, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    return new StateBridgeOff(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBridgeOff : TriggerState {
            internal StateBridgeOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(triggerIds: new []{3300, 3301, 3302}, visible: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState? Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}
