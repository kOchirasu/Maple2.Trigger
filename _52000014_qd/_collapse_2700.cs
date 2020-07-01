namespace Maple2.Trigger._52000014_qd {
    public static class _collapse_2700 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {2700, 2701, 2702, 2703, 2704, 2705, 2706}, arg2: true, arg3: 0,
                    arg4: 0, arg5: 0f);
                context.SetEffect(arg1: new[] {12700}, arg2: false);
                context.SetEffect(arg1: new[] {22700}, arg2: false);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {92700})) {
                    context.State = new State무너짐01(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State무너짐01 : TriggerState {
            internal State무너짐01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 10);
                context.SetEffect(arg1: new[] {12700}, arg2: true);
                context.SetEffect(arg1: new[] {22700}, arg2: true);
                context.SetRandomMesh(arg1: new[] {2700, 2701, 2702, 2703, 2704, 2705, 2706}, arg2: false, arg3: 7,
                    arg4: 300, arg5: 300);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State종료(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetEffect(arg1: new[] {12700}, arg2: false);
                context.SetEffect(arg1: new[] {22700}, arg2: false);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}