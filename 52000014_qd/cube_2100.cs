namespace Maple2.Trigger._52000014_qd {
    public static class _cube_2100 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2100, 2104}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {12100}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {92100})) {
                    return new State무너짐01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(id: "1", arg2: 5);
                context.SetEffect(arg1: new[] {12100}, arg2: true);
                context.SetMesh(arg1: new[] {2100}, arg2: false, arg3: 0, arg4: 0, arg5: 1f);
                context.SetMesh(arg1: new[] {2104}, arg2: false, arg3: 1000, arg4: 0, arg5: 1f);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new StateEnd(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateEnd : TriggerState {
            internal StateEnd(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12100}, arg2: false);
            }

            public override TriggerState Execute() {
                return null;
            }

            public override void OnExit() { }
        }
    }
}