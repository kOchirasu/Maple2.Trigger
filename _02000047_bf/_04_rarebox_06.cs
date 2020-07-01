namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_06 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {406}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {206})) {
                    return new State발판06(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판06 : TriggerState {
            internal State발판06(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {406}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {206})) {
                    return new State발판06끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판06끝 : TriggerState {
            internal State발판06끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "506", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "506")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}