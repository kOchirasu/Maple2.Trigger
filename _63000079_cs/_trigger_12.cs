namespace Maple2.Trigger._63000079_cs {
    public static class _trigger_12 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {312}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {112})) {
                    return new State발판12(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판12 : TriggerState {
            internal State발판12(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {312}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {112})) {
                    return new State발판12끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판12끝 : TriggerState {
            internal State발판12끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "412", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "412")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}