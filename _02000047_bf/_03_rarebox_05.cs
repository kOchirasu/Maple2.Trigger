namespace Maple2.Trigger._02000047_bf {
    public static class _03_rarebox_05 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {305}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {105})) {
                    return new State발판05(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판05 : TriggerState {
            internal State발판05(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {305}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {105})) {
                    return new State발판05끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판05끝 : TriggerState {
            internal State발판05끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "405", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "405")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}