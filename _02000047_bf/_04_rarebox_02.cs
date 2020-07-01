namespace Maple2.Trigger._02000047_bf {
    public static class _04_rarebox_02 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {402}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {202})) {
                    return new State발판02(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판02 : TriggerState {
            internal State발판02(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {402}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {202})) {
                    return new State발판02끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판02끝 : TriggerState {
            internal State발판02끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "502", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "502")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}