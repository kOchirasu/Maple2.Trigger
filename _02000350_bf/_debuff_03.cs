namespace Maple2.Trigger._02000350_bf {
    public static class _debuff_03 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override TriggerState Execute() {
                if (context.UserDetected(arg1: new[] {104})) {
                    return new State버프(context);
                }

                return null;
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3600", arg2: 3600);
                context.AddBuff(arg1: new[] {104}, arg2: 70000071, arg3: 3, arg4: false, arg5: false);
            }

            public override TriggerState Execute() {
                if (context.TimeExpired(arg1: "3600")) {
                    return new State대기(context);
                }

                return null;
            }

            public override void OnExit() { }
        }
    }
}