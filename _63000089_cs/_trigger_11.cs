namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_11 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {311}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {111})) {
                    return new State발판11(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판11 : TriggerState {
            internal State발판11(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {311}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {111})) {
                    return new State발판11끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판11끝 : TriggerState {
            internal State발판11끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "411", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "411")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}