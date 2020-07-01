namespace Maple2.Trigger._02000487_bf {
    public static class _main {
        public class StateReady : TriggerState {
            internal StateReady(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {6001}, arg2: false);
                context.SetMesh(arg1: new[] {6002}, arg2: false);
                context.SetMesh(arg1: new[] {6003}, arg2: false);
                context.SetMesh(arg1: new[] {6004}, arg2: false);
                context.SetMesh(arg1: new[] {6005}, arg2: false);
                context.SetMesh(arg1: new[] {6006}, arg2: false);
                context.SetMesh(arg1: new[] {6007}, arg2: false);
                context.SetMesh(arg1: new[] {6008}, arg2: false);
                context.SetMesh(arg1: new[] {6009}, arg2: false);
                context.SetMesh(arg1: new[] {6010}, arg2: false);
                context.SetMesh(arg1: new[] {6011}, arg2: false);
                context.SetMesh(arg1: new[] {6012}, arg2: false);
                context.SetMesh(arg1: new[] {6013}, arg2: false);
                context.SetMesh(arg1: new[] {6014}, arg2: false);
                context.SetMesh(arg1: new[] {6015}, arg2: false);
                context.SetMesh(arg1: new[] {6016}, arg2: false);
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

            public override void OnEnter() { }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}