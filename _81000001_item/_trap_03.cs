namespace Maple2.Trigger._81000001_item {
    public static class _trap_03 {
        public class State시작 : TriggerState {
            internal State시작(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetInteractObject(arg1: new[] {10000128}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000128}, arg2: 0)) {
                    context.SetMesh(arg1: new[] {601, 602, 603, 604}, arg2: false, arg3: 0, arg4: 0);
                    context.State = new State완료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State완료 : TriggerState {
            internal State완료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "128", arg2: 5, arg3: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "128")) {
                    context.SetMesh(arg1: new[] {601, 602, 603, 604}, arg2: true, arg3: 0, arg4: 0);
                    context.State = new State시작(context);
                    return;
                }
            }

            public override void OnExit() {
                context.ResetTimer(arg1: "128");
            }
        }
    }
}