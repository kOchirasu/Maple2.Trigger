namespace Maple2.Trigger._02000040_bf {
    public static class _bridge {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302, 303}, arg2: false, arg3: 0, arg4: 0, arg5: 0f);
                context.SetInteractObject(arg1: new[] {10000319}, arg2: 1);
            }

            public override void Execute() {
                if (context.ObjectInteracted(arg1: new[] {10000319}, arg2: 0)) {
                    context.State = new State생성(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State생성 : TriggerState {
            internal State생성(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {301, 302, 303}, arg2: true, arg3: 0, arg4: 500, arg5: 2f);
                context.SetTimer(arg1: "3", arg2: 3, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3")) {
                    context.SetMesh(arg1: new[] {303, 302, 301}, arg2: false, arg3: 0, arg4: 500, arg5: 2f);
                    context.State = new State재사용대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State재사용대기 : TriggerState {
            internal State재사용대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "10", arg2: 10, arg3: false, arg4: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "10")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}