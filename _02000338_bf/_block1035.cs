namespace Maple2.Trigger._02000338_bf {
    public static class _block1035 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1035}, arg2: true, arg3: 0, arg4: 0, arg5: 0f);
            }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {10035})) {
                    context.State = new State준비(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State준비 : TriggerState {
            internal State준비(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    context.State = new State진행1(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State진행1 : TriggerState {
            internal State진행1(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {1035}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override void Execute() { }

            public override void OnExit() { }
        }
    }
}