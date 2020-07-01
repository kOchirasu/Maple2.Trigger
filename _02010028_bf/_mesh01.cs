namespace Maple2.Trigger._02010028_bf {
    public static class _mesh01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005}, arg2: true, arg3: 0, arg4: 0,
                    arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000902}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000902}, arg2: 0)) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1000, 1001, 1002, 1003, 1004, 1005}, arg2: false, arg3: 0, arg4: 0,
                    arg5: 7f);
                context.SetTimer(arg1: "2", arg2: 3);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "2")) {
                    context.State = new State재사용대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재사용대기 : TriggerState {
            internal State재사용대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3", arg2: 4);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}