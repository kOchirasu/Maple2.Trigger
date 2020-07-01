namespace Maple2.Trigger._02000047_bf {
    public static class _03_rarebox_04 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {304}, arg2: false);
            }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State발판04(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판04 : TriggerState {
            internal State발판04(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetMesh(arg1: new[] {304}, arg2: true);
            }

            public override TriggerState Execute() {
                if (!context.UserDetected(arg1: new[] {104})) {
                    return new State발판04끝(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State발판04끝 : TriggerState {
            internal State발판04끝(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "404", arg2: 2, arg3: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "404")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}