namespace Maple2.Trigger._02100001_bf {
    public static class _07_bridge {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400, 3401}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {9400}) && context.UserDetected(arg1: new[] {9401})) {
                    context.State = new StateBridgeOn(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBridgeOn : TriggerState {
            internal StateBridgeOn(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400, 3401}, arg2: true, arg3: 300, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 5000)) {
                    context.State = new StateBridgeOff(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateBridgeOff : TriggerState {
            internal StateBridgeOff(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3400, 3401}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new StateWait(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}