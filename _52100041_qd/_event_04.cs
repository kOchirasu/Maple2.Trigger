namespace Maple2.Trigger._52100041_qd {
    public static class _event_04 {
        public class StateIdle : TriggerState {
            internal StateIdle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1803}, arg2: true, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new[] {1804}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new[] {1805}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
                context.SetMesh(arg1: new[] {1806}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {705})) {
                    return new StateReady(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1803}, arg2: false, arg3: 0, arg4: 200, arg5: 85f);
                context.SetMesh(arg1: new[] {1804}, arg2: true, arg3: 0, arg4: 200, arg5: 85f);
                context.SetMesh(arg1: new[] {1805}, arg2: false, arg3: 0, arg4: 200, arg5: 0f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 15000)) {
                    return new StateReady_02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_02 : TriggerState {
            internal StateReady_02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1803}, arg2: false, arg3: 0, arg4: 200, arg5: 5f);
                context.SetMesh(arg1: new[] {1804}, arg2: true, arg3: 0, arg4: 200, arg5: 5f);
                context.SetMesh(arg1: new[] {1806}, arg2: true, arg3: 0, arg4: 200, arg5: 5f);
            }

            public override TriggerState Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    return new StateReady_03(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateReady_03 : TriggerState {
            internal StateReady_03(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1806}, arg2: false, arg3: 0, arg4: 200, arg5: 5f);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}