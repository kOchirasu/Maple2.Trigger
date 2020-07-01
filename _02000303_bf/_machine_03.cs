namespace Maple2.Trigger._02000303_bf {
    public static class _machine_03 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {3003}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000577}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {3003}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // context.State = new State종료2(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}