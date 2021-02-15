namespace Maple2.Trigger._02010028_bf {
    public static class _mesh01 {
        public class StateWait : TriggerState {
            internal StateWait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000902}, arg2: 1);
            }

            public override TriggerState Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000902}, arg2: 0)) {
                    return new StateCreation(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class StateCreation : TriggerState {
            internal StateCreation(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005}, arg2: false, arg3: 0, arg4: 0, arg5: 7f);
                context.SetTimer(arg1: "2", arg2: 3);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    return new State재사용Wait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State재사용Wait : TriggerState {
            internal State재사용Wait(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 4);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    return new StateWait(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}