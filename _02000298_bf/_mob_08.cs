namespace Maple2.Trigger._02000298_bf {
    public static class _mob_08 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {109})) {
                    context.CreateMonster(arg1: new[] {1008}, arg2: false);
                    return new State종료(context);
                }

                if (context.UserDetected(arg1: new[] {110})) {
                    context.CreateMonster(arg1: new[] {1008}, arg2: false);
                    return new State종료(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State종료 : TriggerState {
            internal State종료(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "1800000", arg2: 1800000);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "1800000")) {
                    // return new State종료2(context);
                    return null;
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}