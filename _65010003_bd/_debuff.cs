namespace Maple2.Trigger._65010003_bd {
    public static class _debuff {
        public class State대기 : TriggerState {
            internal State대기(ITriggerContext context) : base(context) { }

            public override void OnEnter() { }

            public override void Execute() {
                if (context.UserDetected(arg1: new[] {101})) {
                    context.State = new State디버프(context);
                    return;
                }
            }

            public override void OnExit() { }
        }

        private class State디버프 : TriggerState {
            internal State디버프(ITriggerContext context) : base(context) { }

            public override void OnEnter() {
                context.AddBuff(arg1: new[] {101}, arg2: 70000040, arg3: 1, arg4: false, arg5: true);
            }

            public override void Execute() {
                if (context.WaitTick(waitTick: 1000)) {
                    context.State = new State대기(context);
                    return;
                }
            }

            public override void OnExit() { }
        }
    }
}