namespace Maple2.Trigger._02010060_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001, 6002, 6003}, arg2: false);
            }

            public override void Execute() {
                if (context.GetUserCount(boxId: 700) == 1) {
                    context.State = new StateReady_Idle(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class StateReady_Idle : TriggerState {
            internal StateReady_Idle(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 1, arg4: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}