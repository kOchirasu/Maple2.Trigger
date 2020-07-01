namespace Maple2.Trigger._02010026_bf {
    public static class _05_mesh09 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {50001})) {
                    return new State발판01(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판01 : TriggerState {
            internal State발판01(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {5001}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {50001})) {
                    return new State발판01끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판01끝 : TriggerState {
            internal State발판01끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}