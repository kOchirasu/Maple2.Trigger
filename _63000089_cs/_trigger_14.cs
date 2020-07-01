namespace Maple2.Trigger._63000089_cs {
    public static class _trigger_14 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {314}, arg2: false, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {114})) {
                    return new State발판14(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판14 : TriggerState {
            internal State발판14(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {314}, arg2: true, arg3: 0, arg4: 0, arg5: 2f);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {114})) {
                    return new State발판14끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판14끝 : TriggerState {
            internal State발판14끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "414", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "414")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}