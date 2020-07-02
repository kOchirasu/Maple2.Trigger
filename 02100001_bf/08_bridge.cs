namespace Maple2.Trigger._02100001_bf {
    public static class _08_bridge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3500, 3501}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {9500}) && context.UserDetected(arg1: new[] {9501})) {
                    return new StateBridgeOn(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateBridgeOn : TriggerState {
            internal StateBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3500, 3501}, arg2: true, arg3: 300, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
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
                context.SetMesh(arg1: new[] {3500, 3501}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}