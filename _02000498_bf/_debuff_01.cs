namespace Maple2.Trigger._02000498_bf {
    public static class _debuff_01 {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {102})) {
                    context.State = new State버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State버프 : TriggerState {
            internal State버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.SetTimer(arg1: "3600", arg2: 3600);
                context.AddBuff(arg1: new[] {102}, arg2: 70000071, arg3: 1, arg4: false, arg5: false);
            }

            public override void Execute() {
                if (context.TimeExpired(arg1: "3600")) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}